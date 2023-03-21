using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoundingSphereFromPoints
{
	public static float m_Radius;

	public static Vector3 m_Center;

	private static float m_RadiusEpsilon;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "SetSphere")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "SetSphere")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "SetSphere")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetSplineBoundingRadius")]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsUnknownMethods(Count = 33)]
	public static void Calculate(Vector3[] points, int length, int supportCount, int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void SetSphere(Vector3 O, Vector3 A)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	private static void SetSphere(Vector3 O, Vector3 A, Vector3 B)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	private static void SetSphere(Vector3 O, Vector3 A, Vector3 B, Vector3 C)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BoundingSphereFromPoints()
	{
	}
}
