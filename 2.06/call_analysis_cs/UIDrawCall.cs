using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIDrawCall : MonoBehaviour
{
	public enum Clipping
	{
		None = 0,
		TextureMask = 1,
		SoftClip = 3,
		ConstrainButDontClip = 4
	}

	public delegate void OnRenderCallback(Material mat);

	public static Action<UIDrawCall> s_OnPostCreate;

	private static BetterList<UIDrawCall> mActiveList;

	private static BetterList<UIDrawCall> mInactiveList;

	[NonSerialized]
	public int widgetCount;

	[NonSerialized]
	public int depthStart;

	[NonSerialized]
	public int depthEnd;

	[NonSerialized]
	public UIPanel manager;

	[NonSerialized]
	public UIPanel panel;

	[NonSerialized]
	public Texture2D clipTexture;

	[NonSerialized]
	public bool alwaysOnScreen;

	[NonSerialized]
	public BetterList<Vector3> verts;

	[NonSerialized]
	public BetterList<Vector3> norms;

	[NonSerialized]
	public BetterList<Vector4> tans;

	[NonSerialized]
	public BetterList<Vector2> uvs;

	[NonSerialized]
	public BetterList<Color32> cols;

	private Material mMaterial;

	private Texture mTexture;

	private Shader mShader;

	private int mClipCount;

	private Transform mTrans;

	private Mesh mMesh;

	private MeshFilter mFilter;

	private MeshRenderer mRenderer;

	private Material mDynamicMat;

	private int[] mIndices;

	private bool mRebuildMat;

	private bool mLegacyShader;

	private int mRenderQueue;

	private int mTriangles;

	[NonSerialized]
	public bool isDirty;

	[NonSerialized]
	private bool mTextureClip;

	public OnRenderCallback onRender;

	private const int maxIndexBufferCache = 10;

	private static List<int[]> mCache;

	private static int[] ClipRange;

	private static int[] ClipArgs;

	public static BetterList<UIDrawCall> list
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public static BetterList<UIDrawCall> activeList
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public static BetterList<UIDrawCall> inactiveList
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public int renderQueue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Material), Member = "set_renderQueue")]
		set
		{
		}
	}

	public int sortingOrder
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[Calls(Type = typeof(Renderer), Member = "set_sortingOrder")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public int finalRenderQueue
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(int);
		}
	}

	public Transform cachedTransform
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
	}

	public Material baseMaterial
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Material dynamicMaterial
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Texture mainTexture
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITexture), Member = "set_mainTexture")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = "set_mainTexture")]
		set
		{
		}
	}

	public Shader shader
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(UITexture), Member = "set_shader")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		set
		{
		}
	}

	public int triangles
	{
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public bool isClipped
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Substring")]
	private void CreateMaterial()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private Material RebuildMaterial()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[Calls(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	private void UpdateMaterials()
	{
	}

	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[Calls(Type = typeof(Mesh), Member = "set_colors32")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "Clear")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[Calls(Type = typeof(Mesh), Member = "set_colors32")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(UIDrawCall), Member = "GenerateCachedIndexBuffer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(MeshFilter), Member = "set_mesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[Calls(Type = typeof(Mesh), Member = "Clear")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(Mesh), Member = "Clear")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Mesh), Member = "MarkDynamic")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void UpdateGeometry(int widgetCount)
	{
	}

	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		return null;
	}

	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(NGUIMath), Member = "WrapAngle")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(NGUIMath), Member = "WrapAngle")]
	[Calls(Type = typeof(NGUIMath), Member = "WrapAngle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UIDrawCall), Member = "SetClipping")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnWillRenderObject()
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[Calls(Type = typeof(UIDrawCall), Member = "Create")]
	[CallerCount(Count = 1)]
	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIDrawCall), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIDrawCall), Member = "set_renderQueue")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_sortingOrder")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_mainTexture")]
	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
	private static UIDrawCall Create(string name)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "ReleaseAll")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void ClearAll()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIDrawCall), Member = "ClearAll")]
	public static void ReleaseAll()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void ReleaseInactive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public static int Count(UIPanel panel)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Destroy(UIDrawCall dc)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 26)]
	public UIDrawCall()
	{
	}
}
