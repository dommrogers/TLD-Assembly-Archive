using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SnowDepthBoxRecord : SnowDepthTriggerRecord
{
	private BoxCollider m_Box;

	[DeduplicatedMethod]
	[CallerCount(Count = 230)]
	public SnowDepthBoxRecord(SnowDepth sd, BoxCollider box)
		: base(null)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public override float GetDepthFracAtPosition(Vector3 position)
	{
		return 0f;
	}
}
