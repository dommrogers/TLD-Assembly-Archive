using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthCapsuleRecord : SnowDepthTriggerRecord
{
	private CapsuleCollider m_Capsule;

	[DeduplicatedMethod]
	[CallerCount(Count = 224)]
	public SnowDepthCapsuleRecord(SnowDepth sd, CapsuleCollider capsule)
		: base(null)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "NearestPoint")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return default(float);
	}
}
