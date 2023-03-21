using Cpp2ILInjected.CallAnalysis;

public class TimeOfDaySaveDataProxy
{
	public float m_TimeProxy;

	public float m_HoursPlayedNotPausedProxy;

	public int m_UniStormDayCounterProxy;

	public int m_UniStormMoonPhaseIndexProxy;

	public int m_UniStormDayNumberProxy;

	public int m_DayLastDawnStingerAudioPlayed;

	public int m_DayLastNightStingerAudioPlayed;

	public int m_DayLastDawnVoiceOverPlayed;

	public int m_DayLastNightVoiceOverPlayed;

	public int m_4DONCurrentDay;

	public bool m_LockedTOD;

	public string m_CurrentScene;

	public int m_DayEntered;

	public int m_HourEntered;

	public float m_ElapsedRealSecondsInScene;

	public float m_ElapsedGameHoursInScene;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public TimeOfDaySaveDataProxy()
	{
	}
}
