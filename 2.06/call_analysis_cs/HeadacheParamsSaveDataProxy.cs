using Cpp2ILInjected.CallAnalysis;

public class HeadacheParamsSaveDataProxy
{
	public float m_TimeSpentIndoor;

	public float m_TimeSpentOutdoor;

	public float m_StartTimeInGameHours;

	public float m_LastHeadachePulseTime;

	public HeadacheStatus m_HeadacheStatus;

	public float m_HeadacheDurationHours;

	public float m_HeadachePulseFrequencyStart;

	public float m_HeadachePulseFrequencyEnd;

	public string m_HeadachePulseEvent;

	public string m_HeadacheStartAudio;

	public string m_HeadacheAfflictionIcoName;

	public float m_HoursRequiredOutdoorToGetAffliction;

	public float m_HoursRequiredIndoorToExitAffliction;

	public HeadacheCause m_Cause;

	public LocalizedString m_HeadacheLocalizedId;

	public LocalizedString m_HealedAfflictionLocalizedId;

	public LocalizedString m_HeadacheDescription;

	public LocalizedString m_TreatmentRequiredDescription;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public HeadacheParamsSaveDataProxy()
	{
	}
}
