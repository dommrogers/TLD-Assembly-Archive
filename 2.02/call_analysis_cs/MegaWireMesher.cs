using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class MegaWireMesher
{
	public bool show;

	private static Vector3[] tan1;

	private static Vector3[] tan2;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void BuildMesh(MegaWire rope, MegaWireSpan span)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Vector3), Member = "OrthoNormalize")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[CallsUnknownMethods(Count = 60)]
	public static void BuildTangents(Mesh mesh, Vector3[] verts, Vector2[] uvs, Vector3[] norms, int[] tris)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MegaWireMesher()
	{
	}
}
