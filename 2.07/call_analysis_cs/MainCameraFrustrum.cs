using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class MainCameraFrustrum
{
	public static Plane[] m_CapturePlanes;

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	public static void RecalculateFrustumPlanes(Camera c)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static void RecalculateFrustumPlanes(Camera c, ref NativeArray<Plane> planes, float expandFovPercent = 0f)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
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
