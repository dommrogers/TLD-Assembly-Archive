using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class MainCameraFrustrum
{
	public static Plane[] m_CapturePlanes;

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 33)]
	public static void RecalculateFrustumPlanes(Camera c)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 15)]
	public static void RecalculateFrustumPlanes(Camera c, ref NativeArray<Plane> planes, float expandFovPercent = 0f)
	{
	}

	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 14)]
	public static void RecalculateFrustumCorners(Camera c, ref NativeArray<Vector3> corners, float expandFovPercent = 0f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public MainCameraFrustrum()
	{
	}
}
