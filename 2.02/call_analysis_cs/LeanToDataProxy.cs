using Cpp2ILInjected.CallAnalysis;

public class LeanToDataProxy
{
	public float m_NormalizedCondition;

	public float m_HoursPlayed;

	public float m_HoursRuined;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public LeanToDataProxy()
	{
	}
}
