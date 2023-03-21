using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public abstract class SnowDepthTriggerRecord
{
	public SnowDepth m_SnowDepthObject;

	[DeduplicatedMethod]
	[CallerCount(Count = 265)]
	public SnowDepthTriggerRecord(SnowDepth sd)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract float GetDepthFracAtPosition(Vector3 pos);

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected float GetScaledDepthFrac(float frac)
	{
		return default(float);
	}
}
