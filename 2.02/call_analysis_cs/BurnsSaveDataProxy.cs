using Cpp2ILInjected.CallAnalysis;

public class BurnsSaveDataProxy
{
	public bool m_Active;

	public float m_ElapsedHours;

	public float m_DurationHours;

	public bool m_PainKillersTaken;

	public bool m_BandageApplied;

	public int m_NumBurnRemindersPlayed;

	public float m_SecondsUntilNextBurnReminder;

	public string m_CauseLocID;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public BurnsSaveDataProxy()
	{
	}
}
