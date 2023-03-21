using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeIn")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(Hypothermia), Member = "CheckForHypothermia")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void HypothermiaStart(string causeId, bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hypothermia_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Hypothermia), Member = "UpdateHypothermia")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
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

	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	public string GetCauseString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
	public string GetCauseLocalizationId()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Hypothermia), Member = "Update")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaEnd")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Hypothermia), Member = "GetNumHoursWarmForCure")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	private void UpdateHypothermia()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Hypothermia), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "RegionHasFullWetInnerLayer")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	private void CheckForHypothermia()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Hypothermia()
	{
	}
}
