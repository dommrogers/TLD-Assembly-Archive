using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MeshCombinerSingle : MB3_MeshCombiner
{
	[Serializable]
	public class SerializableIntArray
	{
		public int[] data;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public SerializableIntArray()
		{
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "GetSubmeshTrisWithShowHideApplied")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		public SerializableIntArray(int len)
		{
		}
	}

	[Serializable]
	public class MB_DynamicGameObject : IComparable<MB_DynamicGameObject>
	{
		public int instanceID;

		public string name;

		public int vertIdx;

		public int blendShapeIdx;

		public int numVerts;

		public int numBlendShapes;

		public int[] indexesOfBonesUsed;

		public int lightmapIndex;

		public Vector4 lightmapTilingOffset;

		public Vector3 meshSize;

		public bool show;

		public bool invertTriangles;

		public int[] submeshTriIdxs;

		public int[] submeshNumTris;

		public int[] targetSubmeshIdxs;

		public Rect[] uvRects;

		public Rect[] encapsulatingRect;

		public Rect[] sourceMaterialTiling;

		public Rect[] obUVRects;

		public bool _beingDeleted;

		public int _triangleIdxAdjustment;

		[NonSerialized]
		public SerializableIntArray[] _tmpSubmeshTris;

		[NonSerialized]
		public Transform[] _tmpCachedBones;

		[NonSerialized]
		public Matrix4x4[] _tmpCachedBindposes;

		[NonSerialized]
		public BoneWeight[] _tmpCachedBoneWeights;

		[NonSerialized]
		public int[] _tmpIndexesOfSourceBonesUsed;

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public int CompareTo(MB_DynamicGameObject b)
		{
			return 0;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_one")]
		[CallsDeduplicatedMethods(Count = 1)]
		public MB_DynamicGameObject()
		{
		}
	}

	public class MeshChannels
	{
		public Vector3[] vertices;

		public Vector3[] normals;

		public Vector4[] tangents;

		public Vector2[] uv0raw;

		public Vector2[] uv0modified;

		public Vector2[] uv2;

		public Vector2[] uv3;

		public Vector2[] uv4;

		public Color[] colors;

		public BoneWeight[] boneWeights;

		public Matrix4x4[] bindPoses;

		public int[] triangles;

		public MBBlendShape[] blendShapes;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MeshChannels()
		{
		}
	}

	[Serializable]
	public class MBBlendShapeFrame
	{
		public float frameWeight;

		public Vector3[] vertices;

		public Vector3[] normals;

		public Vector3[] tangents;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MBBlendShapeFrame()
		{
		}
	}

	[Serializable]
	public class MBBlendShape
	{
		public int gameObjectID;

		public string name;

		public int indexInSource;

		public MBBlendShapeFrame[] frames;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MBBlendShape()
		{
		}
	}

	public class MeshChannelsCache
	{
		private MB3_MeshCombinerSingle mc;

		protected Dictionary<int, MeshChannels> meshID2MeshChannels;

		private Vector2 _HALF_UV;

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObjects")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		public MeshChannelsCache(MB3_MeshCombinerSingle mcs)
		{
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(Mesh), Member = "get_vertices")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal Vector3[] GetVertices(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getMeshNormals")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal Vector3[] GetNormals(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getMeshTangents")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal Vector4[] GetTangents(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_collectOutOfBoundsUVRects2")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUVsFromMesh")]
		[CalledBy(Type = typeof(MeshChannelsCache), Member = "_getMeshTangents")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getMeshUVs")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal Vector2[] GetUv0Raw(Mesh m)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 12)]
		internal Vector2[] GetUv0Modified(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUV2FromMesh")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getMeshUV2s")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal Vector2[] GetUv2(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MBVersion), Member = "GetMeshUV3orUV4")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		internal Vector2[] GetUv3(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MBVersion), Member = "GetMeshUV3orUV4")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		internal Vector2[] GetUv4(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getMeshColors")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal Color[] GetColors(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_CollectBonesToAddForDGO")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getBindPoses")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		internal Matrix4x4[] GetBindposes(Renderer r)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_CollectBonesToAddForDGO")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getBoneWeights")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		internal BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(Mesh), Member = "get_triangles")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		internal int[] GetTriangles(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MBVersion), Member = "GetMajorVersion")]
		[Calls(Type = typeof(MBVersion), Member = "GetMinorVersion")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
		[Calls(Type = typeof(MBVersion), Member = "GetBlendShapeFrameCount")]
		[Calls(Type = typeof(Mesh), Member = "GetBlendShapeName")]
		[Calls(Type = typeof(MBVersion), Member = "GetBlendShapeFrameWeight")]
		[Calls(Type = typeof(MBVersion), Member = "GetBlendShapeFrameVertices")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 83)]
		internal MBBlendShape[] GetBlendShapes(Mesh m, int gameObjectID)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetColors")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "get_colors")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		private Color[] _getMeshColors(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetNormals")]
		[CalledBy(Type = typeof(MeshChannelsCache), Member = "_getMeshTangents")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Mesh), Member = "get_normals")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
		[Calls(Type = typeof(Mesh), Member = "RecalculateNormals")]
		[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		private Vector3[] _getMeshNormals(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetTangents")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "get_tangents")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(Mesh), Member = "get_vertices")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv0Raw")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_getMeshNormals")]
		[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
		[Calls(Type = typeof(MeshChannelsCache), Member = "_generateTangents")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 6)]
		private Vector4[] _getMeshTangents(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetUv0Raw")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "get_uv")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		private Vector2[] _getMeshUVs(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetUv2")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Mesh), Member = "get_uv2")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 9)]
		private Vector2[] _getMeshUV2s(Mesh m)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetBindposes")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		public static Matrix4x4[] _getBindPoses(Renderer r)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "GetBoneWeights")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		public static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
		{
			return null;
		}

		[CalledBy(Type = typeof(MeshChannelsCache), Member = "_getMeshTangents")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Vector3), Member = "get_normalized")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 49)]
		private void _generateTangents(int[] triangles, Vector3[] verts, Vector2[] uvs, Vector3[] normals, Vector4[] outTangents)
		{
		}
	}

	public struct BoneAndBindpose
	{
		public Transform bone;

		public Matrix4x4 bindPose;

		[CallerCount(Count = 0)]
		public BoneAndBindpose(Transform t, Matrix4x4 bp)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Matrix4x4), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[Calls(Type = typeof(Matrix4x4), Member = "get_Item")]
		[CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public GameObject[] _goToAdd;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass49_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_1
	{
		public int i;

		public _003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass49_1()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		[CallsUnknownMethods(Count = 3)]
		internal bool _003C_addToCombined_003Eb__0(int o)
		{
			return false;
		}
	}

	protected List<GameObject> objectsInCombinedMesh;

	private int lightmapIndex;

	private List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

	private Dictionary<int, MB_DynamicGameObject> _instance2combined_map;

	private Vector3[] verts;

	private Vector3[] normals;

	private Vector4[] tangents;

	private Vector2[] uvs;

	private Vector2[] uv2s;

	private Vector2[] uv3s;

	private Vector2[] uv4s;

	private Color[] colors;

	private Matrix4x4[] bindPoses;

	private Transform[] bones;

	internal MBBlendShape[] blendShapes;

	internal MBBlendShape[] blendShapesInCombined;

	private SerializableIntArray[] submeshTris;

	private Mesh _mesh;

	private BoneWeight[] boneWeights;

	private GameObject[] empty;

	private int[] emptyIDs;

	public override MB2_TextureBakeResults textureBakeResults
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public override MB_RenderType renderType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public override GameObject resultSceneObject
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Debug), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private MB_DynamicGameObject instance2Combined_MapGet(int gameObjectID)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void instance2Combined_MapAdd(int gameObjectID, MB_DynamicGameObject dgo)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void instance2Combined_MapRemove(int gameObjectID)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool instance2Combined_MapTryGetValue(int gameObjectID, out MB_DynamicGameObject dgo)
	{
		dgo = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int instance2Combined_MapCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void instance2Combined_MapClear()
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_showHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool instance2Combined_MapContainsKey(int gameObjectID)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetNumObjectsInCombined()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override List<GameObject> GetObjectsInCombined()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneMeshObject")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_distributeAmongBakers")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_bakeStep1")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Mesh GetMesh()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public void SetMesh(Mesh m)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Transform[] GetBones()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override int GetLightmapIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetNumVerticesFor(GameObject go)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override int GetNumVerticesFor(int instanceID)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 30)]
	public override Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_showHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetMesh")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapClear")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapAdd")]
	[Calls(Type = typeof(SerializableIntArray), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 55)]
	private void _initialize(int numResultMats)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OrderedDictionary), Member = "Contains")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Item")]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 72)]
	private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv0Raw")]
	[Calls(Type = typeof(MB_Utility), Member = "hasOutOfBoundsUVs")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 34)]
	private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults, MeshChannelsCache meshChannelCache)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool _validateTextureBakeResults()
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	private bool _validateMeshFlags()
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshBaker), Member = "ShowHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ShowHideGameObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapContainsKey")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	private bool _showHide(GameObject[] goToShow, GameObject[] goToHide)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "AddDeleteGameObjectsByID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_validateTextureBakeResults")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_validateMeshFlags")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "ValidateTargRendererAndMeshAndResultSceneObj")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MB2_TextureBakeResults), Member = "DoAnyResultMatsUseConsiderMeshUVs")]
	[Calls(Type = typeof(bool), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSourceMatsToSubmeshIdxMap")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_buildBoneIdx2dgoMap")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapTryGetValue")]
	[Calls(Type = typeof(MeshChannelsCache), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapContainsKey")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB_DynamicGameObject), Member = ".ctor")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(MBVersion), Member = "IsRunningAndMeshNotReadWriteable")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Item")]
	[Calls(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mesh), Member = "get_blendShapeCount")]
	[Calls(Type = typeof(MB_Utility), Member = "GetRenderer")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_CollectBonesToAddForDGO")]
	[Calls(Type = typeof(Renderer), Member = "get_lightmapIndex")]
	[Calls(Type = typeof(MBVersion), Member = "GetActive")]
	[Calls(Type = typeof(MBVersion), Member = "GetLightmapTilingOffset")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_collectMaterialTriangles")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_collectOutOfBoundsUVRects2")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "IsMirrored")]
	[Calls(Type = typeof(MB_Utility), Member = "DisableRendererInSource")]
	[Calls(Type = typeof(MBVersion), Member = "MaxMeshVertexCount")]
	[Calls(Type = typeof(SerializableIntArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapRemove")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetVertices")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetNormals")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetTangents")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector4), Member = "op_Implicit")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUVsFromMesh")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUV2FromMesh")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv3")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv4")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetColors")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetBlendShapes")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_AddBonesToNewBonesArrayAndAdjustBWIndexes")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapAdd")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyUV2unchangedToSeparateRects")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 991)]
	private bool _addToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv0Raw")]
	[Calls(Type = typeof(Mesh), Member = "GetTriangles")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_TextureCombinerMerging), Member = "BuildTransformMeshUV2AtlasRect")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 45)]
	private void _copyAndAdjustUVsFromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv2")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void _copyAndAdjustUV2FromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MB3_MeshCombiner), Member = "UpdateSkinnedMeshApproximateBoundsFromBonesStatic")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	public override void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MB3_MeshCombiner), Member = "UpdateSkinnedMeshApproximateBoundsFromBoundsStatic")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private int _getNumBones(Renderer r)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_CollectBonesToAddForDGO")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private Transform[] _getBones(Renderer r)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "ValidateTargRendererAndMeshAndResultSceneObj")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MBVersion), Member = "MeshClear")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetSubmeshTrisWithShowHideApplied")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_numNonZeroLengthSubmeshTris")]
	[Calls(Type = typeof(Mesh), Member = "set_subMeshCount")]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateMaterialsOnTargetRenderer")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 32)]
	public virtual void ApplyShowHide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "ValidateTargRendererAndMeshAndResultSceneObj")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(MBVersion), Member = "SetMeshIndexFormatAndClearMesh")]
	[Calls(Type = typeof(Vector3), Member = "op_Addition")]
	[Calls(Type = typeof(Vector3), Member = "op_Division")]
	[Calls(Type = typeof(Vector3), Member = "op_Subtraction")]
	[Calls(Type = typeof(Transform), Member = "set_position_Injected")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Mesh), Member = "SetArrayForChannel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetSubmeshTrisWithShowHideApplied")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_numNonZeroLengthSubmeshTris")]
	[Calls(Type = typeof(Mesh), Member = "set_subMeshCount")]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateMaterialsOnTargetRenderer")]
	[Calls(Type = typeof(MBVersion), Member = "MeshAssignUV3")]
	[Calls(Type = typeof(MBVersion), Member = "MeshAssignUV4")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GenerateUV2Delegate), Member = "Invoke")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_updateWhenOffscreen")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_updateWhenOffscreen")]
	[Calls(Type = typeof(Mesh), Member = "set_bindposes")]
	[Calls(Type = typeof(MBVersion), Member = "GetMajorVersion")]
	[Calls(Type = typeof(MBVersion), Member = "GetMinorVersion")]
	[Calls(Type = typeof(MBVersion), Member = "ClearBlendShapes")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "instance2Combined_MapGet")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(MBVersion), Member = "AddBlendShapeFrame")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_ZeroArray")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(MBVersion), Member = "OptimizeMesh")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 141)]
	public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, GenerateUV2Delegate uv2GenerationMethod = null)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ApplyShowHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private int _numNonZeroLengthSubmeshTris(SerializableIntArray[] subTris)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ApplyShowHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void _updateMaterialsOnTargetRenderer(SerializableIntArray[] subTris, int numNonZeroLengthSubmeshTris)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ApplyShowHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializableIntArray), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 59)]
	public SerializableIntArray[] GetSubmeshTrisWithShowHideApplied()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_initialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MeshChannelsCache), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSourceMatsToSubmeshIdxMap")]
	[Calls(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObject")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 33)]
	private bool _updateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount")]
	[Calls(Type = typeof(OrderedDictionary), Member = "get_Item")]
	[Calls(Type = typeof(MB2_TextureBakeResults.Material2AtlasRectangleMapper), Member = "TryMapMaterialToUVRect")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUVsFromMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_copyAndAdjustUV2FromMesh")]
	[Calls(Type = typeof(MB_Utility), Member = "GetRenderer")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetBoneWeights")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_getBones")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetVertices")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetNormals")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetTangents")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetColors")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv3")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetUv4")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 148)]
	private bool _updateGameObject(GameObject go, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo, MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResultsCache, OrderedDictionary sourceMats2submeshIdx_map, MB2_TextureBakeResults.Material2AtlasRectangleMapper mat2rect_map)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_showHide")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneMeshObject")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_sharedMesh")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_bones")]
	[Calls(Type = typeof(Renderer), Member = "set_lightmapIndex")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 20)]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool CombinedMeshContains(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public override void ClearBuffers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(MBVersion), Member = "MeshClear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public override void ClearMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public override void DestroyMesh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ApplyShowHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public bool ValidateTargRendererAndMeshAndResultSceneObj()
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_updateGameObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(OrderedDictionary), Member = "Contains")]
	[Calls(Type = typeof(OrderedDictionary), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private OrderedDictionary BuildSourceMatsToSubmeshIdxMap(int numResultMats)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneMeshObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(bool), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_bones")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "get_updateWhenOffscreen")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_updateWhenOffscreen")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_ConfigureSceneHierarch")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 25)]
	internal static Renderer BuildSceneHierarchPreBake(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, bool createNewChild = false, GameObject[] objsToBeAdded = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_ConfigureSceneHierarch")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 45)]
	public static void BuildPrefabHierarchy(MB3_MeshCombinerSingle mom, GameObject instantiatedPrefabRoot, Mesh m, bool createNewChild = false, GameObject[] objsToBeAdded = null)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneHierarchPreBake")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildPrefabHierarchy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Renderer), Member = "set_lightmapIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 30)]
	private static void _ConfigureSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, MeshRenderer mr, MeshFilter mf, SkinnedMeshRenderer smr, Mesh m, GameObject[] objsToBeAdded = null)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBaker), Member = "BuildSceneMeshObject")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "AddDeleteGameObjectsByID")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_bakeStep1")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetMesh")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneHierarchPreBake")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void BuildSceneMeshObject(GameObject[] gos = null, bool createNewChild = false)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRow")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsMirrored(Matrix4x4 tm)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet<>), Member = "ExceptWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 47)]
	public override void CheckIntegrity()
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void _ZeroArray(Vector3[] arr, int idx, int length)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetBindposes")]
	[Calls(Type = typeof(MeshChannelsCache), Member = "GetBoneWeights")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "_getBones")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 60)]
	private void _CollectBonesToAddForDGO(MB_DynamicGameObject dgo, Dictionary<Transform, int> bone2idx, HashSet<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Renderer r, MeshChannelsCache meshChannelCache)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 57)]
	private void _CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(HashSet<int> boneIdxsToDeleteHS, HashSet<BoneAndBindpose> bonesToAdd, Transform[] nbones, Matrix4x4[] nbindPoses, BoneWeight[] nboneWeights, int totalDeleteVerts)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 71)]
	private void _AddBonesToNewBonesArrayAndAdjustBWIndexes(MB_DynamicGameObject dgo, Renderer r, int vertsIdx, Transform[] nbones, BoneWeight[] nboneWeights, MeshChannelsCache meshChannelCache)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector2), Member = "get_one")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 60)]
	private void _copyUV2unchangedToSeparateRects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public override List<Material> GetMaterialsOnTargetRenderer()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshBaker), Member = ".ctor")]
	[CalledBy(Type = typeof(MB3_TestBakeAllWithSameMaterial), Member = "testCombine")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner.CombinedMesh), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public MB3_MeshCombinerSingle()
	{
	}
}
