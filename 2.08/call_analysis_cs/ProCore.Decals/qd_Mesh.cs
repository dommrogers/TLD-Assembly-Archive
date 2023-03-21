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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(qd_Decal), Member = "SetUVRect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static GameObject CreateDecal(string decalId, Material mat, Rect uvCoords, float scale, Material fullscreenDecalMaterial)
	{
		return null;
	}

	[CalledBy(Type = typeof(qd_Decal), Member = "Verify")]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	public static Mesh DecalMesh(string name, Material mat, Rect uvCoords, float scale)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public qd_Mesh()
	{
	}
}
