using Cpp2ILInjected.CallAnalysis;

public class SuffocatingSaveDataProxy
{
	public bool m_IsSuffocating;

	public bool m_HasSuffocatingRisk;

	public int m_SuffocatingTriggerCounter;

	public float m_TimeRemaining;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SuffocatingSaveDataProxy()
	{
	}
}
