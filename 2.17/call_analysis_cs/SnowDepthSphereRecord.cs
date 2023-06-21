using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthSphereRecord : SnowDepthTriggerRecord
{
	private SphereCollider m_Sphere;

	[DeduplicatedMethod]
	[CallerCount(Count = 234)]
	public SnowDepthSphereRecord(SnowDepth sd, SphereCollider sphere)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
