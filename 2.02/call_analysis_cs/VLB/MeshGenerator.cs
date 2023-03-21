using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class MeshGenerator
{
	private const float kMinTruncatedRadius = 0.001f;

	[CallerCount(Count = 0)]
	private static float GetAngleOffset(int numSides)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[CallsUnknownMethods(Count = 1)]
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 75)]
	[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Angle")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateConeZ_RadiusAndAngle")]
	[CalledBy(Type = typeof(GlobalMesh), Member = "Get")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(MeshGenerator), Member = "ComputeBounds")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[CalledBy(Type = typeof(BeamGeometry), Member = "UpdateMaterialAndBounds")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[Calls(Type = typeof(Bounds), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
	{
		return default(Bounds);
	}

	[CallerCount(Count = 0)]
	public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Config), Member = "get_actualRenderingMode")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetSharedMeshVertexCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Config), Member = "get_actualRenderingMode")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	public static int GetSharedMeshIndicesCount()
	{
		return default(int);
	}
}
