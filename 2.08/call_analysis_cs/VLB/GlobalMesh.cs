using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class GlobalMesh
{
	private static Mesh ms_Mesh;

	private static bool ms_DoubleSided;

	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 2)]
	public static Mesh Get()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
	public static void Destroy()
	{
	}
}
