using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[StructLayout(0, Size = 1)]
internal struct JobVisUtils
{
	public enum PlaneTestResult
	{
		Front,
		Back,
		Intersect
	}

	public enum FrustumPlanesId
	{
		Left,
		Right,
		Bottom,
		Top,
		Near,
		Far,
		None
	}

	public enum FrustumPointsId
	{
		FarBottomLeft,
		FarTopLeft,
		FarTopRight,
		FarBottomRight,
		NearBottomLeft,
		NearTopLeft,
		NearTopRight,
		NearBottomRight
	}

	private static readonly FrustumPointsId[,,] frustumCornersTable;

	private static readonly FrustumPlanesId[,] frustumNeighborTable;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "Normalize")]
	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	public static byte FrustrumDotJob(float4 pointPos, float4 camPos, float4 camDir)
	{
		return default(byte);
	}

	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	public static byte FrustumCamera(Bounds bounds, NativeSlice<Plane> frustumPlanes, bool testShadows, NativeSlice<Plane> lightPlanes, int lightPlanesCount)
	{
		return default(byte);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[CalledBy(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[CallsUnknownMethods(Count = 7)]
	private static FrustumPointsId GetCorner(FrustumPlanesId _fpPlanea, FrustumPlanesId _fpPlaneab, int index)
	{
		return default(FrustumPointsId);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[CallsUnknownMethods(Count = 5)]
	private static FrustumPlanesId GetNeighbor(FrustumPlanesId _fpPlane, int index)
	{
		return default(FrustumPlanesId);
	}

	[Calls(Type = typeof(Plane), Member = "GetDistanceToPoint")]
	[CalledBy(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static PlaneTestResult TestPlaneAABB(ref Bounds bounds, ref Plane plane)
	{
		return default(PlaneTestResult);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlaneAABB")]
	[CalledBy(Type = typeof(JobVisUtils), Member = "FrustumCamera")]
	[CalledBy(Type = typeof(JobVisUtils), Member = "FrustumCamera")]
	[CallsUnknownMethods(Count = 1)]
	private static bool TestPlanesAABBInternal(NativeSlice<Plane> planes, int planesCount, ref Bounds bounds)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(JobVisUtils), Member = "GetCorner")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobVisUtils), Member = "GetNeighbor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JobVisUtils), Member = "GetCorner")]
	public static int UpdateDirectionalLightCullingPlanes(Vector3 lightDirection, NativeArray<Plane> frustumPlanes, ref NativeArray<Plane> lightPlanes, NativeArray<Vector3> corners)
	{
		return default(int);
	}
}
