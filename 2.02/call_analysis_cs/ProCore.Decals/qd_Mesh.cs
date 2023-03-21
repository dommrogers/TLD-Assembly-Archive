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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(qd_Decal), Member = "SetUVRect")]
	[Calls(Type = typeof(qd_Mesh), Member = "DecalMesh")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public static GameObject CreateDecal(string decalId, Material mat, Rect uvCoords, float scale, Material fullscreenDecalMaterial)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(qd_Mesh), Member = "CreateDecal")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Mesh), Member = "set_uv2")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_tangents")]
	[Calls(Type = typeof(Mesh), Member = "set_normals")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CalledBy(Type = typeof(qd_Decal), Member = "Verify")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public static Mesh DecalMesh(string name, Material mat, Rect uvCoords, float scale)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public qd_Mesh()
	{
	}
}
