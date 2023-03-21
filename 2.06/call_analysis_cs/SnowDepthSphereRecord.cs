using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthSphereRecord : SnowDepthTriggerRecord
{
	private SphereCollider m_Sphere;

	[DeduplicatedMethod]
	[CallerCount(Count = 224)]
	public SnowDepthSphereRecord(SnowDepth sd, SphereCollider sphere)
		: base(null)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return default(float);
	}
}
