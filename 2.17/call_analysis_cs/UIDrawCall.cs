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
			return 0;
		}
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = "set_renderQueue")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int sortingOrder
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Renderer), Member = "set_sortingOrder")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public int finalRenderQueue
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public Transform cachedTransform
	{
		[CalledBy(Type = typeof(UIPanel), Member = "UpdateDrawCalls")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Material baseMaterial
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Material dynamicMaterial
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UITexture), Member = "set_mainTexture")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Material), Member = "set_mainTexture")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public Shader shader
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
		[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
		[CalledBy(Type = typeof(UITexture), Member = "set_shader")]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public int triangles
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public bool isClipped
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void CreateMaterial()
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UIDrawCall), Member = "CreateMaterial")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private Material RebuildMaterial()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "get_clipCount")]
	[Calls(Type = typeof(UIDrawCall), Member = "RebuildMaterial")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateMaterials()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(Mesh), Member = "Clear")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Mesh), Member = "MarkDynamic")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_colors32")]
	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(UIDrawCall), Member = "GenerateCachedIndexBuffer")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(MeshFilter), Member = "set_mesh")]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 11)]
	public void UpdateGeometry(int widgetCount)
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "UpdateGeometry")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDrawCall), Member = "UpdateMaterials")]
	[Calls(Type = typeof(Material), Member = "set_mainTextureOffset")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(NGUIMath), Member = "WrapAngle")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UIDrawCall), Member = "SetClipping")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void OnWillRenderObject()
	{
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "OnWillRenderObject")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIDrawCall), Member = "Create")]
	public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIDrawCall), Member = "Create")]
	[Calls(Type = typeof(UIRect), Member = "get_cachedGameObject")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_baseMaterial")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_mainTexture")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_renderQueue")]
	[Calls(Type = typeof(UIDrawCall), Member = "set_sortingOrder")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIDrawCall), Member = "Create")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static UIDrawCall Create(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void ClearAll()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void ReleaseAll()
	{
	}

	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ReleaseInactive()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static int Count(UIPanel panel)
	{
		return 0;
	}

	[CalledBy(Type = typeof(UIPanel), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPanel), Member = "UpdateSelf")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillAllDrawCalls")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BetterList<>), Member = "Remove")]
	[Calls(Type = typeof(NGUITools), Member = "DestroyImmediate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void Destroy(UIDrawCall dc)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public UIDrawCall()
	{
	}
}
