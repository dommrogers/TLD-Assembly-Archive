using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthCapsuleRecord : SnowDepthTriggerRecord
{
	private CapsuleCollider m_Capsule;

	[DeduplicatedMethod]
	[CallerCount(Count = 230)]
	public SnowDepthCapsuleRecord(SnowDepth sd, CapsuleCollider capsule)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "NearestPoint")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
