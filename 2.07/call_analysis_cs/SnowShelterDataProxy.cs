using Cpp2ILInjected.CallAnalysis;

public class SnowShelterDataProxy
{
	public float m_NormalizedCondition;

	public float m_HoursPlayed;

	public float m_HoursRuined;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SnowShelterDataProxy()
	{
	}
}
