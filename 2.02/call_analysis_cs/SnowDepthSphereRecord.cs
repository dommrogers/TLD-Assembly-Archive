using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthSphereRecord : SnowDepthTriggerRecord
{
	private SphereCollider m_Sphere;

	[DeduplicatedMethod]
	[CallerCount(Count = 83)]
	public SnowDepthSphereRecord(SnowDepth sd, SphereCollider sphere)
		: base(null)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsUnknownMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return default(float);
	}
}
