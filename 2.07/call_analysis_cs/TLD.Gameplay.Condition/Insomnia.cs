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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Insomnia(InsomniaData data)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public InsomniaParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
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
		return default(float);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float GetRiskProgress()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 3)]
	public void Destroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public bool ShouldInterruptSleep()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public float GetChanceOfHowBadlySleepIsInterrupted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool AfflictionIsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool RiskIsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaRisk")]
	[CallsUnknownMethods(Count = 4)]
	public void StartRisk()
	{
	}

	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void ShowRiskNotification()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Insomnia), Member = "UpdateInsomnia")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	private void MaybeUpdateRisk()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Insomnia), Member = "OnWeatherStageChanged")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void HealRisk()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "ApplyInsomniaAffliction")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Insomnia), Member = "ShowAfflictionNotification")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	public void StartAffliction()
	{
	}

	[CalledBy(Type = typeof(Insomnia), Member = "StartAffliction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void ShowAfflictionNotification()
	{
	}

	[CalledBy(Type = typeof(InsomniaManager), Member = "MaybeUpdateInsomnia")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Insomnia), Member = "UpdateInsomnia")]
	[CalledBy(Type = typeof(InsomniaManager), Member = "Update")]
	private void MaybeUpdateAffliction()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void HealAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void ApplyInsomniaExitEffects()
	{
	}

	[Calls(Type = typeof(Insomnia), Member = "HealRisk")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnWeatherStageChanged(WeatherSetStage current)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetRemainingHours()
	{
		return default(float);
	}
}
