using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireMesher
{
	public bool show;

	private static Vector3[] tan1;

	private static Vector3[] tan2;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public virtual void BuildMesh(MegaWire rope, MegaWireSpan span)
	{
	}

	[CalledBy(Type = typeof(MegaWireStrandedMesher), Member = "BuildMesh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Vector3), Member = "OrthoNormalize")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 60)]
	public static void BuildTangents(Mesh mesh, Vector3[] verts, Vector2[] uvs, Vector3[] norms, int[] tris)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MegaWireMesher()
	{
	}
}
