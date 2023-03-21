using Cpp2ILInjected.CallAnalysis;

public class HungerSaveDataProxy
{
	public float m_CurrentReserveCaloriesProxy;

	public float m_NumSecondsSinceLastVoiceOver;

	public bool m_StarvingInLog;

	public float m_NumHoursStarving;

	public float m_FatiguePenalty;

	public HungerLevel m_HungerLevelForPreviousVoiceOver;

	public float m_CaloriesEatenToday;

	public float m_CaloriesExpendedToday;

	public bool m_SuppressVoiceOver;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public HungerSaveDataProxy()
	{
	}
}
