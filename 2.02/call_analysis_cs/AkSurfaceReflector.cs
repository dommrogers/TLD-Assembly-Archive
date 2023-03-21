using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkSurfaceReflector : MonoBehaviour
{
	public AcousticTexture AcousticTexture;

	public bool EnableDiffraction;

	public bool EnableDiffractionOnBoundaryEdges;

	private MeshFilter MeshFilter;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[CallsUnknownMethods(Count = 1)]
	public static ulong GetAkGeometrySetID(MeshFilter meshFilter)
	{
		return 0uL;
	}

	[CalledBy(Type = typeof(AkSurfaceReflector), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(AkBaseArray<>), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(AkAcousticSurface), Member = "set_strName")]
	[Calls(Type = typeof(AkVertex), Member = "set_X")]
	[Calls(Type = typeof(AkVertex), Member = "set_Y")]
	[Calls(Type = typeof(AkVertex), Member = "set_Z")]
	[Calls(Type = typeof(AkTriangle), Member = "set_point0")]
	[Calls(Type = typeof(AkTriangle), Member = "set_point1")]
	[Calls(Type = typeof(AkTriangle), Member = "set_point2")]
	[Calls(Type = typeof(AkTriangle), Member = "set_surface")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallsUnknownMethods(Count = 108)]
	public static void AddGeometrySet(AcousticTexture acousticTexture, MeshFilter meshFilter, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges)
	{
	}

	[CalledBy(Type = typeof(AkSurfaceReflector), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void RemoveGeometrySet(MeshFilter meshFilter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkSurfaceReflector()
	{
	}
}
