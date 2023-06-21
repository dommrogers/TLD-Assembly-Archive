using Cpp2ILInjected.CallAnalysis;

public class MusicEventSaveData
{
	public float m_HappySuccessLastPlayTime;

	public float m_SorrowLastPlayTime;

	public float m_RopeClimbStressLastPlayTime;

	public float m_BeingStalkedLastPlayTime;

	public float m_NumHoursWithAffliction;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public MusicEventSaveData()
	{
	}
}
