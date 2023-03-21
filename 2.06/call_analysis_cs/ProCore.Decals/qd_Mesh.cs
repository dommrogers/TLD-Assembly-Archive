using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ProCore.Decals;

public class qd_Mesh
{
	private static int[] BILLBOARD_TRIANGLES;

	private static Vector3[] BILLBOARD_VERTICES;

	private static Vector3[] BILLBOARD_NORMALS;

	private static Vector4[] BILLBOARD_TANGENTS;

	private static Vector2[] BILLBOARD_UV2;

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(qd_Decal), Member = "SetUVRect")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static GameObject CreateDecal(string decalId, Material mat, Rect uvCoords, float scale, Material fullscreenDecalMaterial)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	[CalledBy(Type = typeof(qd_Decal), Member = "Verify")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	public static Mesh DecalMesh(string name, Material mat, Rect uvCoords, float scale)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public qd_Mesh()
	{
	}
}
