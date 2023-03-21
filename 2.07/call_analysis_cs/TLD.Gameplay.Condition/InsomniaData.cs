using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay.Condition;

public class InsomniaData : ScriptableObject
{
	public InsomniaCause m_Cause;

	public string m_InsomniaStartAudio;

	public LocalizedString m_InsomniaCausedByLocalizedId;

	public LocalizedString m_InsomniaRiskLocalizedId;

	public LocalizedString m_InsomniaRiskDescription;

	public LocalizedString m_InsomniaRiskTreatmentRequiredDescription;

	public LocalizedString m_InsomniaRiskHealedLocalizedId;

	public string m_InsomniaRiskIcoName;

	public float m_HoursRequiredToTurnRiskToAffliction;

	public float m_OutdoorRiskIncreaseSpeedModifier;

	public float m_IndoorRiskIncreaseSpeedModifier;

	public float m_SafePlaceRiskDecreaseSpeedModifier;

	public LocalizedString m_InsomniaAfflictionLocalizedId;

	public LocalizedString m_InsomniaAfflictionDescription;

	public LocalizedString m_InsomniaAfflictionTreatmentRequiredDescription;

	public LocalizedString m_InsomniaAfflictionHealedLocalizedId;

	public string m_InsomniaAfflictionIcoName;

	public int m_MinHoursRequiredToRemoveAffliction;

	public int m_MaxHoursRequiredToRemoveAffliction;

	public float m_ChaneOfGettingInterruptedSleep;

	public float m_MinChanceHowBadlySleepInterrupted;

	public float m_MaxChanceHowBadlySleepInterrupted;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public InsomniaData()
	{
	}
}
