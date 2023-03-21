using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class BloodLoss : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_ChanceBloodLossAfterFall;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_HPDrainPerHour;

	public float m_HPDrainPerHourBandaged;

	public float m_FatigueIncreasePerHour;

	public float m_FatigueIncreasePerHourBandaged;

	public GameObject m_BandagePrefab;

	public float m_HPThresholdForSound;

	public float m_ScentIntensity;

	public GameplayTag m_UseMinimumTimeForSave;

	public string m_SoundToPlayAboveThreshold;

	public string m_SoundToPlayBelowThreshold;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private List<string> m_CausesLocIDs;

	private List<int> m_Locations;

	private List<float> m_ElapsedHoursList;

	private List<float> m_DurationHoursList;

	private bool m_StartHasBeenCalled;

	private bool m_ForceNoDamage;

	private bool m_ShouldOverrideArea;

	private AfflictionBodyArea m_OverrideArea;

	private static BloodLossSaveDataProxy m_BloodLossSaveDataProxy;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossEnd")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODHours")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BloodLoss), Member = "MaybeApplyDamage")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Enum), Member = "GetValues")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public bool LocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void BloodLossStartOverrideArea(AfflictionBodyArea area, string cause, bool displayIcon, AfflictionOptions options = (AfflictionOptions)3)
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "MaybeBulletDamage")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateDetectionStage")]
	[CalledBy(Type = typeof(FallDamage), Member = "ApplyFallDamage")]
	[CalledBy(Type = typeof(FallDamage), Member = "MaybeBloodLoss")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blood_loss_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blood_loss_nofx")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BearFadeFinish")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(BloodLossEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blood_loss")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blood_loss")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(DamageProtection), Member = "GetBodyAreasToPreventBloodLoss")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
	public void BloodLossStart(string cause, bool displayIcon, AfflictionOptions options = (AfflictionOptions)3)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(BloodLoss), Member = "ApplyBandage")]
	[CalledBy(Type = typeof(BloodLoss), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	public void BloodLossEnd(int index)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blood_loss_cure")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	public void Cure()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasBloodLoss()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	public bool RequiresBandage()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BloodLoss), Member = "BloodLossEnd")]
	public void ApplyBandage(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(RiskOfInfectionEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(BloodLoss), Member = "GetLocationOfLastAdded")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BearFadeFinish")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[CallerCount(Count = 0)]
	public AfflictionBodyArea GetLocationOfLastAdded()
	{
		return default(AfflictionBodyArea);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetNoDamage()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetNoDamage(bool noDamage)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateBloodLoss(int index)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BloodLoss), Member = "Update")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeApplyDamage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public BloodLoss()
	{
	}
}
