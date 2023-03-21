using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class GlobalMesh
{
	private static Mesh ms_Mesh;

	private static bool ms_DoubleSided;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public static Mesh Get()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	public static void Destroy()
	{
	}
}
