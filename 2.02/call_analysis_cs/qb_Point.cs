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
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public qb_Point()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public qb_Point(Vector3 incomingPos, Vector3 incomingUpVector, Vector3 incomingDirVector)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void UpdatePoint(Vector3 incomingPos, Vector3 incomingUpVector, Vector3 incomingDirVector)
	{
	}
}
