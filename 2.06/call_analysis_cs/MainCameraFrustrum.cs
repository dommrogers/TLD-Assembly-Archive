using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class MainCameraFrustrum
{
	public static Plane[] m_CapturePlanes;

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	public static void RecalculateFrustumPlanes(Camera c)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallsUnknownMethods(Count = 13)]
	public static void RecalculateFrustumPlanes(Camera c, ref NativeArray<Plane> planes, float expandFovPercent = 0f)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	public static void RecalculateFrustumCorners(Camera c, ref NativeArray<Vector3> corners, float expandFovPercent = 0f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MainCameraFrustrum()
	{
	}
}
