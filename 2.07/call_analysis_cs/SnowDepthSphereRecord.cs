using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthSphereRecord : SnowDepthTriggerRecord
{
	private SphereCollider m_Sphere;

	[DeduplicatedMethod]
	[CallerCount(Count = 263)]
	public SnowDepthSphereRecord(SnowDepth sd, SphereCollider sphere)
		: base(null)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return default(float);
	}
}
