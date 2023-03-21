using Cpp2ILInjected.CallAnalysis;

public class HeadacheParams
{
	public float m_HeadacheDurationHours;

	public float m_HeadachePulseFrequencyStart;

	public float m_HeadachePulseFrequencyEnd;

	public float m_StartTimeInGameHours;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public HeadacheParams()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public HeadacheParams(HeadacheParams rhs)
	{
	}
}
