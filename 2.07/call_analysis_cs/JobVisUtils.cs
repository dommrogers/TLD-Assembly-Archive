using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
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

	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static byte FrustrumDotJob(float4 pointPos, float4 camPos, float4 camDir)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobVisUtils), Member = "TestPlanesAABBInternal")]
	public static byte FrustumCamera(Bounds bounds, NativeSlice<Plane> frustumPlanes, bool testShadows, NativeSlice<Plane> lightPlanes, int lightPlanesCount)
	{
		return 0;
	}

	[CalledBy(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static FrustumPointsId GetCorner(FrustumPlanesId _fpPlanea, FrustumPlanesId _fpPlaneab, int index)
	{
		return default(FrustumPointsId);
	}

	[CalledBy(Type = typeof(JobVisUtils), Member = "UpdateDirectionalLightCullingPlanes")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static FrustumPlanesId GetNeighbor(FrustumPlanesId _fpPlane, int index)
	{
		return default(FrustumPlanesId);
	}

	[CallerCount(Count = 0)]
	private static PlaneTestResult TestPlaneAABB(ref Bounds bounds, ref Plane plane)
	{
		return default(PlaneTestResult);
	}

	[CalledBy(Type = typeof(JobVisUtils), Member = "FrustumCamera")]
	[CalledBy(Type = typeof(RenderObjectInstanceJob), Member = "Execute")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static bool TestPlanesAABBInternal(NativeSlice<Plane> planes, int planesCount, ref Bounds bounds)
	{
		return false;
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobVisUtils), Member = "GetNeighbor")]
	[Calls(Type = typeof(JobVisUtils), Member = "GetCorner")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int UpdateDirectionalLightCullingPlanes(Vector3 lightDirection, NativeArray<Plane> frustumPlanes, ref NativeArray<Plane> lightPlanes, NativeArray<Vector3> corners)
	{
		return 0;
	}
}
