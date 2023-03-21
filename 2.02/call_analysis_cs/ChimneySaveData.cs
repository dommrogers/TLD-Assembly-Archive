using Cpp2ILInjected.CallAnalysis;

public class ChimneySaveData
{
	public float m_LifetimeGameMinues;

	public float m_HoursPlayed;

	public string m_Guid;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ChimneySaveData()
	{
	}
}
