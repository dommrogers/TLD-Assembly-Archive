using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthCapsuleRecord : SnowDepthTriggerRecord
{
	private CapsuleCollider m_Capsule;

	[DeduplicatedMethod]
	[CallerCount(Count = 83)]
	public SnowDepthCapsuleRecord(SnowDepth sd, CapsuleCollider capsule)
		: base(null)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "NearestPoint")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return default(float);
	}
}
