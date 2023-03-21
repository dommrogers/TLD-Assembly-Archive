using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay.Condition;

public class Insomnia
{
	public InsomniaCause m_Cause;

	public InsomniaStatus m_InsomniaStatus;

	public LocalizedString m_InsomniaCausedByLocalizedId;

	public LocalizedString m_InsomniaRiskLocalizedId;

	public LocalizedString m_InsomniaRiskDescription;

	public LocalizedString m_InsomniaRiskTreatmentRequiredDescription;

	public LocalizedString m_InsomniaRiskHealedLocalizedId;

	public LocalizedString m_InsomniaAfflictionLocalizedId;

	public LocalizedString m_InsomniaAfflictionDescription;

	public LocalizedString m_InsomniaAfflictionTreatmentRequiredDescription;

	public int m_HoursRequiredToExitAffliction;

	private string m_InsomniaRiskIcoName;

	private float m_HoursRequiredToTurnRiskToAffliction;

	private float m_OutdoorRiskIncreaseSpeedModifier;

	private float m_InsideRiskIncreaseSpeedModifier;

	private float m_SafePlaceRiskDecreaseSpeedModifier;

	private LocalizedString m_InsomniaAfflictionHealedLocalizedId;

	private string m_InsomniaAfflictionIcoName;

	private int m_MinHoursRequiredToRemoveAffliction;

	private int m_MaxHoursRequiredToRemoveAffliction;

	private float m_StartTimeInGameHours;

	private float m_RiskProgress;

	private bool m_CanPassAffliction;

	private string m_InsomniaStartAudio;

	private float m_RemainingHours;

	private float m_TimeSpentIndoor;

	private float m_TimeSpentInsideSafePlace;

	private float m_ChaneOfGettingInterruptedSleep;

	private float m_MinChanceHowBadlySleepInterrupted;

	private float m_MaxChanceHowBadlySleepInterrupted;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Insomnia()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Insomnia(InsomniaData data)
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public InsomniaParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void Deserialize(InsomniaParamsSaveDataProxy saveDataProxy)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateRisk")]
	[Calls(Type = typeof(Insomnia), Member = "MaybeUpdateAffliction")]
	public void UpdateInsomnia()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetStatus(InsomniaStatus status)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetAfflictionHoursRemaining()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetRiskProgress()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void Destroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldInterruptSleep()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public float GetChanceOfHowBadlySleepIsInterrupted()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool AfflictionIsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool RiskIsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void StartRisk()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	private void ShowRiskNotification()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Insomnia), Member = "UpdateInsomnia")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CallerCount(Count = 3)]
	private void MaybeUpdateRisk()
	{
	}

	[CalledBy(Type = typeof(Insomnia), Member = "OnWeatherStageChanged")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void HealRisk()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Insomnia), Member = "ShowAfflictionNotification")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void StartAffliction()
	{
	}

	[CalledBy(Type = typeof(Insomnia), Member = "StartAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	private void ShowAfflictionNotification()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Insomnia), Member = "UpdateInsomnia")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CallerCount(Count = 3)]
	private void MaybeUpdateAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void HealAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void ApplyInsomniaExitEffects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Insomnia), Member = "HealRisk")]
	[CallsUnknownMethods(Count = 1)]
	private void OnWeatherStageChanged(WeatherSetStage current)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetRemainingHours()
	{
		return 0f;
	}
}
