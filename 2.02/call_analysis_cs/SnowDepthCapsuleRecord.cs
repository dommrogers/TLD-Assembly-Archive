using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthCapsuleRecord : SnowDepthTriggerRecord
{
	private CapsuleCollider m_Capsule;

	[DeduplicatedMethod]
	[CallerCount(Count = 88)]
	public SnowDepthCapsuleRecord(SnowDepth sd, CapsuleCollider capsule)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "NearestPoint")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 16)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
