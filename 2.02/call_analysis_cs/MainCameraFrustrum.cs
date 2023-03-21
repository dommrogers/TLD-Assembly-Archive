using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine;

public class MainCameraFrustrum
{
	public static Plane[] m_CapturePlanes;

	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[Calls(Type = typeof(Plane), Member = "SetNormalAndPosition")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	public static void RecalculateFrustumPlanes(Camera c)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Plane), Member = "Set3Points")]
	public static void RecalculateFrustumPlanes(Camera c, ref NativeArray<Plane> planes, float expandFovPercent = 0f)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(RenderObjectInstance), Member = "UpdateFrustumArrays")]
	[CallsUnknownMethods(Count = 14)]
	public static void RecalculateFrustumCorners(Camera c, ref NativeArray<Vector3> corners, float expandFovPercent = 0f)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public MainCameraFrustrum()
	{
	}
}
