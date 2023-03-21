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
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[Calls(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeIn")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 5)]
	public void HypothermiaStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia_cure")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	public void HypothermiaEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
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

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool GetSuppressHypothermia()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Hypothermia), Member = "Update")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateHypothermia()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Hypothermia), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullWetInnerLayer")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void CheckForHypothermia()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Hypothermia), Member = "GetWarmTimeAmountRemaining")]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public float GetNumHoursWarmForCure()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Hypothermia()
	{
	}
}
