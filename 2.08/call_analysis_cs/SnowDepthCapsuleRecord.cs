using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthCapsuleRecord : SnowDepthTriggerRecord
{
	private CapsuleCollider m_Capsule;

	[DeduplicatedMethod]
	[CallerCount(Count = 263)]
	public SnowDepthCapsuleRecord(SnowDepth sd, CapsuleCollider capsule)
		: base(null)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "NearestPoint")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallerCount(Count = 0)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return default(float);
	}
}
