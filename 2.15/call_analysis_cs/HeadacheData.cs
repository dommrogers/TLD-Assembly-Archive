using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeadacheData : ScriptableObject
{
	public float m_HeadacheDurationHours;

	public float m_HeadachePulseFrequencyStart;

	public float m_HeadachePulseFrequencyEnd;

	public HeadacheCause m_Cause;

	public float m_HoursRequiredOutdoorToGetAffliction;

	public float m_HoursRequiredIndoorToExitAffliction;

	public string m_HeadachePulseEvent;

	public string m_HeadacheStartAudio;

	public string m_HeadacheAfflictionIcoName;

	public LocalizedString m_HeadacheLocalizedId;

	public LocalizedString m_HealedAfflictionLocalizedId;

	public LocalizedString m_HeadacheDescription;

	public LocalizedString m_TreatmentRequiredDescription;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public HeadacheData()
	{
	}
}
