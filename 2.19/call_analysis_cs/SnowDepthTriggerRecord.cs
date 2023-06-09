using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class SnowDepthTriggerRecord
{
	public SnowDepth m_SnowDepthObject;

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public SnowDepthTriggerRecord(SnowDepth sd)
	{
	}

	public abstract float GetDepthFracAtPosition(Vector3 pos);

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected float GetScaledDepthFrac(float frac)
	{
		return 0f;
	}
}
