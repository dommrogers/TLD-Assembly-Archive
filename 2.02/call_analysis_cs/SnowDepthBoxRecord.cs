using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthBoxRecord : SnowDepthTriggerRecord
{
	private BoxCollider m_Box;

	[DeduplicatedMethod]
	[CallerCount(Count = 88)]
	public SnowDepthBoxRecord(SnowDepth sd, BoxCollider box)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
