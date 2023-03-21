using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MultiMeshCombiner : MB3_MeshCombiner
{
	[Serializable]
	public class CombinedMesh
	{
		public MB3_MeshCombinerSingle combinedMesh;

		public int extraSpace;

		public int numVertsInListToDelete;

		public int numVertsInListToAdd;

		public List<GameObject> gosToAdd;

		public List<int> gosToDelete;

		public List<GameObject> gosToUpdate;

		public bool isDirty;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = ".ctor")]
		[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_distributeAmongBakers")]
		[CallsUnknownMethods(Count = 35)]
		public CombinedMesh(int maxNumVertsInMesh, GameObject resultSceneObject, MB2_LogLevel ll)
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 12)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
		public bool isEmpty()
		{
			return default(bool);
		}
	}

	private static GameObject[] empty;

	private static int[] emptyIDs;

	public Dictionary<int, CombinedMesh> obj2MeshCombinerMap;

	public List<CombinedMesh> meshCombiners;

	private int _maxVertsInMesh;

	public override MB2_LogLevel LOG_LEVEL
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(MB2_LogLevel);
		}
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		set
		{
		}
	}

	public override MB2_ValidationLevel validationLevel
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(MB2_ValidationLevel);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	public int maxVertsInMesh
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(MBVersion), Member = "MaxMeshVertexCount")]
		[Calls(Type = typeof(MBVersion), Member = "MaxMeshVertexCount")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetNumObjectsInCombined()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsUnknownMethods(Count = 4)]
	public override int GetNumVerticesFor(GameObject go)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override int GetNumVerticesFor(int gameObjectID)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 12)]
	public override List<GameObject> GetObjectsInCombined()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public override int GetLightmapIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsUnknownMethods(Count = 2)]
	public override bool CombinedMeshContains(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_validate")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool _validateTextureBakeResults()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, GenerateUV2Delegate uv2GenerationMethod = null)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public override void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public override bool UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = "_bakeStep1")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = "_validate")]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = "_distributeAmongBakers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "AddDeleteGameObjectsByID")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = "_validateTextureBakeResults")]
	private bool _validate(GameObject[] gos, int[] deleteGOinstanceIDs)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 82)]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "AddDeleteGameObjectsByID")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = "_setMBValues")]
	[Calls(Type = typeof(CombinedMesh), Member = ".ctor")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetMesh")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	private void _distributeAmongBakers(GameObject[] gos, int[] deleteGOinstanceIDs)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SkinnedMeshRenderer), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetMesh")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "AddDeleteGameObjectsByID")]
	[CallsUnknownMethods(Count = 126)]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "BuildSceneMeshObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(MB2_Log), Member = "LogDebug")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	private bool _bakeStep1(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	public override void ClearBuffers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void ClearMesh()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MB_Utility), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public override void DestroyMesh()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 15)]
	public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "_distributeAmongBakers")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 24)]
	private void _setMBValues(MB3_MeshCombinerSingle targ)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 18)]
	public override List<Material> GetMaterialsOnTargetRenderer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public override void CheckIntegrity()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(MB3_TestBakeAllWithSameMaterial), Member = "testCombine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(MB3_MultiMeshBaker), Member = ".ctor")]
	[CallerCount(Count = 2)]
	public MB3_MultiMeshCombiner()
	{
	}
}
