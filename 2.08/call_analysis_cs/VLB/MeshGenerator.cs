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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[CalledBy(Type = typeof(TriggerZone), Member = "ComputeZone")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Angle")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "GenerateConeZ_RadiusAndAngle")]
	[CalledBy(Type = typeof(GlobalMesh), Member = "Get")]
	[CalledBy(Type = typeof(BeamGeometry), Member = "RegenerateMesh")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[CallsUnknownMethods(Count = 1)]
	public static int GetSharedMeshVertexCount()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SRPHelper), Member = "get_renderPipelineType")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	public static int GetSharedMeshIndicesCount()
	{
		return default(int);
	}
}
