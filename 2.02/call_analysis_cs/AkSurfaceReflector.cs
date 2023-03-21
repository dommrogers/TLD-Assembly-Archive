using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkSurfaceReflector : MonoBehaviour
{
	public AcousticTexture AcousticTexture;

	public bool EnableDiffraction;

	public bool EnableDiffractionOnBoundaryEdges;

	private MeshFilter MeshFilter;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallerCount(Count = 0)]
	public static ulong GetAkGeometrySetID(MeshFilter meshFilter)
	{
		return default(ulong);
	}

	[Calls(Type = typeof(AkVertex), Member = "set_Z")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(AkTriangle), Member = "set_surface")]
	[Calls(Type = typeof(AkTriangle), Member = "set_point2")]
	[Calls(Type = typeof(AkTriangle), Member = "set_point1")]
	[Calls(Type = typeof(AkTriangle), Member = "set_point0")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(AkVertex), Member = "set_Y")]
	[Calls(Type = typeof(AkVertex), Member = "set_X")]
	[Calls(Type = typeof(AkAcousticSurface), Member = "set_strName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(AkSurfaceReflector), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 108)]
	public static void AddGeometrySet(AcousticTexture acousticTexture, MeshFilter meshFilter, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CalledBy(Type = typeof(AkSurfaceReflector), Member = "OnDisable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	public static void RemoveGeometrySet(MeshFilter meshFilter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSurfaceReflector), Member = "AddGeometrySet")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSurfaceReflector), Member = "RemoveGeometrySet")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AkSurfaceReflector()
	{
	}
}
