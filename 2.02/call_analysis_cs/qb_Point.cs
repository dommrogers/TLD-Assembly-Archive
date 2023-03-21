using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class qb_Point
{
	public Vector3 position;

	public Vector3 upVector;

	public Vector3 dirVector;

	public Quaternion rotation;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public qb_Point()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public qb_Point(Vector3 incomingPos, Vector3 incomingUpVector, Vector3 incomingDirVector)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void UpdatePoint(Vector3 incomingPos, Vector3 incomingUpVector, Vector3 incomingDirVector)
	{
	}
}
