using Cpp2ILInjected.CallAnalysis;

public class SnareItemSaveDataProxy
{
	public float m_HoursPlayed;

	public float m_HoursAtLastRoll;

	public SnareState m_State;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SnareItemSaveDataProxy()
	{
	}
}
