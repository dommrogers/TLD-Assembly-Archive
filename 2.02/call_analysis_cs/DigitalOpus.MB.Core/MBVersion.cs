using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MBVersion
{
	private static MBVersionInterface _MBVersion;

	[CallerCount(Count = 23)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 2)]
	private static MBVersionInterface _CreateMBVersionConcrete()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsUnknownMethods(Count = 2)]
	public static string version()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_TextureCombiner._003CCombineTexturesIntoAtlasesCoroutine_003Ed__68), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_TextureCombiner._003CCombineTexturesIntoAtlasesCoroutine_003Ed__68), Member = "MoveNext")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	public static int GetMajorVersion()
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CalledBy(Type = typeof(MB3_TextureCombiner._003CCombineTexturesIntoAtlasesCoroutine_003Ed__68), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetMinorVersion()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	public static bool GetActive(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetActive(GameObject go, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetActiveRecursively(GameObject go, bool isActive)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetUv3")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetUv4")]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ClearMesh")]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ApplyShowHide")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MBVersionConcrete), Member = "SetMeshIndexFormatAndClearMesh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MBVersionConcrete), Member = "SetMeshIndexFormatAndClearMesh")]
	[CalledBy(Type = typeof(MBVersionConcrete), Member = "SetMeshIndexFormatAndClearMesh")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MBVersionConcrete), Member = "SetMeshIndexFormatAndClearMesh")]
	public static void MeshClear(Mesh m, bool t)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsUnknownMethods(Count = 2)]
	public static void MeshAssignUV3(Mesh m, Vector2[] uv3s)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	public static void MeshAssignUV4(Mesh m, Vector2[] uv4s)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallsUnknownMethods(Count = 2)]
	public static Vector4 GetLightmapTilingOffset(Renderer r)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsUnknownMethods(Count = 2)]
	public static Transform[] GetBones(Renderer r)
	{
		return null;
	}

	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void OptimizeMesh(Mesh m)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	public static int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
	{
		return default(int);
	}

	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	public static void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearBlendShapes(Mesh m)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallsUnknownMethods(Count = 2)]
	public static void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "set_maxVertsInMesh")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "set_maxVertsInMesh")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	public static int MaxMeshVertexCount()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MBVersion()
	{
	}
}
