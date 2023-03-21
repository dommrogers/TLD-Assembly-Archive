using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class GlobalMesh
{
	private static Mesh ms_Mesh;

	private static bool ms_DoubleSided;

	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Config), Member = "get_actualRenderingMode")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static Mesh Get()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	public static void Destroy()
	{
	}
}
