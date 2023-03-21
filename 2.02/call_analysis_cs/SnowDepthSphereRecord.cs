using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthSphereRecord : SnowDepthTriggerRecord
{
	private SphereCollider m_Sphere;

	[DeduplicatedMethod]
	[CallerCount(Count = 88)]
	public SnowDepthSphereRecord(SnowDepth sd, SphereCollider sphere)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
