using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Hypothermia : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_HoursSpentFreezingRequired;

	public float m_HPDrainPerHour;

	public float m_FatigueIncreasePerHour;

	public float m_NumHoursWarmForCure;

	public float m_HypothermiaRatePercentIncreasePerInnerWetItem;

	public string m_HypothermiaVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_Active;

	private float m_ElapsedHours;

	private float m_ElapsedWarmTime;

	private string m_CauseLocID;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressHypothermia;

	private static HypothermiaSaveDataProxy m_HypothermiaSaveDataProxy;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeIn")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void HypothermiaStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void HypothermiaEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasHypothermia()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasHypothermiaRisk()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public float GetHypothermiaRiskValue()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[CallerCount(Count = 1)]
	public float GetWarmTimeAmountRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string GetCauseString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public string GetCauseLocalizationId()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SetWarmingUp(bool isWarming)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressHypothermia(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool GetSuppressHypothermia()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Hypothermia), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateHypothermia()
	{
	}

	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullWetInnerLayer")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Hypothermia), Member = "Update")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 5)]
	private void CheckForHypothermia()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Hypothermia), Member = "GetWarmTimeAmountRemaining")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 3)]
	public float GetNumHoursWarmForCure()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Hypothermia()
	{
	}
}
