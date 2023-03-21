using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public class MBVersion
{
	private static MBVersionInterface _MBVersion;

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static MBVersionInterface _CreateMBVersionConcrete()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static string version()
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<CombineTexturesIntoAtlasesCoroutine>d__68", Member = "MoveNext")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetMajorVersion()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombiner.<CombineTexturesIntoAtlasesCoroutine>d__68", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetMinorVersion()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetActive(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetActive(GameObject go, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetActiveRecursively(GameObject go, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetUv3")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetUv4")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
	{
		return null;
	}

	[CalledBy(Type = typeof(MBVersionConcrete), Member = "SetMeshIndexFormatAndClearMesh")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ApplyShowHide")]
	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "ClearMesh")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void MeshClear(Mesh m, bool t)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void MeshAssignUV3(Mesh m, Vector2[] uv3s)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void MeshAssignUV4(Mesh m, Vector2[] uv4s)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector4 GetLightmapTilingOffset(Renderer r)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static Transform[] GetBones(Renderer r)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OptimizeMesh(Mesh m)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle.MeshChannelsCache), Member = "GetBlendShapes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearBlendShapes(Mesh m)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "_addToCombined")]
	[CalledBy(Type = typeof(MB3_MultiMeshCombiner), Member = "set_maxVertsInMesh")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int MaxMeshVertexCount()
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshCombinerSingle), Member = "Apply")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MBVersion), Member = "_CreateMBVersionConcrete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MBVersion()
	{
	}
}
