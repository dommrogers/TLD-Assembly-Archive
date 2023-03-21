using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class MainCameraFrustrum
{
	public static Plane[] m_CapturePlanes;

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	public static void RecalculateFrustumPlanes(Camera c)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 1)]
	public static void RecalculateFrustumPlanes(Camera c, ref NativeArray<Plane> planes, float expandFovPercent = 0f)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallsUnknownMethods(Count = 12)]
	public static void RecalculateFrustumCorners(Camera c, ref NativeArray<Vector3> corners, float expandFovPercent = 0f)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public MainCameraFrustrum()
	{
	}
}
