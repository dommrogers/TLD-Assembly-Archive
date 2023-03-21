using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BoundingSphereFromPoints
{
	public static float m_Radius;

	public static Vector3 m_Center;

	private static float m_RadiusEpsilon;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetSplineBoundingRadius")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "SetSphere")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "SetSphere")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "SetSphere")]
	public static void Calculate(Vector3[] points, int length, int supportCount, int index)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsUnknownMethods(Count = 1)]
	private static void SetSphere(Vector3 O, Vector3 A)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsUnknownMethods(Count = 1)]
	private static void SetSphere(Vector3 O, Vector3 A, Vector3 B)
	{
	}

	[CalledBy(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void SetSphere(Vector3 O, Vector3 A, Vector3 B, Vector3 C)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BoundingSphereFromPoints()
	{
	}
}
