using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Condition;

public class InsomniaParamsSaveDataProxy
{
	public InsomniaCause m_Cause;

	public InsomniaStatus m_InsomniaStatus;

	public LocalizedString m_InsomniaCausedByLocalizedId;

	public LocalizedString m_InsomniaRiskLocalizedId;

	public LocalizedString m_InsomniaRiskDescription;

	public LocalizedString m_InsomniaRiskTreatmentRequiredDescription;

	public LocalizedString m_InsomniaRiskHealedLocalizedId;

	public string m_InsomniaRiskIcoName;

	public float m_HoursRequiredToTurnRiskToAffliction;

	public float m_OutdoorRiskIncreaseSpeedModifier;

	public float m_InsideRiskDecreaseSpeedModifier;

	public float m_SafePlaceRiskDecreaseSpeedModifier;

	public LocalizedString m_InsomniaAfflictionLocalizedId;

	public LocalizedString m_InsomniaAfflictionDescription;

	public LocalizedString m_InsomniaAfflictionTreatmentRequiredDescription;

	public LocalizedString m_InsomniaAfflictionHealedLocalizedId;

	public string m_InsomniaAfflictionIcoName;

	public int m_MinHoursRequiredToRemoveAffliction;

	public int m_MaxHoursRequiredToRemoveAffliction;

	public float m_StartTimeInGameHours;

	public int m_HoursRequiredToExitAffliction;

	public float m_RiskProgress;

	public bool m_CanUpdateAffliction;

	public string m_InsomniaStartAudio;

	public float m_RemainingHours;

	public float m_TimeSpentIndoor;

	public float m_TimeSpentInsideSafePlace;

	public float m_ChaneOfGettingInterruptedSleep;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public InsomniaParamsSaveDataProxy()
	{
	}
}
