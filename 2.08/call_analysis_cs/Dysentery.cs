using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Dysentery : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_ChanceDysenteryAfterDrinkingUnsafeWater;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_HPDrainPerHour;

	public float m_FatigueIncreasePerHour;

	public float m_ThirstIncreasePerHour;

	public GameObject m_AntibioticsPrefab;

	public float m_NumLitersCleanWaterForCure;

	public float m_NumHoursRestForCure;

	public string m_DysenteryVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_Active;

	private float m_ElapsedHours;

	private float m_DurationHours;

	private bool m_AntibioticsTaken;

	private float m_ElapsedRest;

	private float m_CleanWaterConsumedLiters;

	private bool m_StartHasBeenCalled;

	private static DysenterySaveDataProxy m_DysenterySaveDataProxy;

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
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
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
	[Calls(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dysentery_nofx")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dysentery")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	public void DysenteryStart(bool displayIcon, bool nofx = false)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dysentery_cure")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateDysentery")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	public void DysenteryEnd()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasDysentery()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public bool HasTakenAntibiotics()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public float GetRestAmountRemaining()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public float GetWaterAmountRemaining()
	{
		return default(float);
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(UIToggle), Member = "Set")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void UpdateRemedyItems(GameObject[] items)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void TakeAntibiotics()
	{
	}

	[CallerCount(Count = 0)]
	public void DrinkCleanWater(float numLiters)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void AddRest(float hours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public bool RollForDysentery()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public float GetWaterRemainingForCureLiters()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Dysentery), Member = "Update")]
	[Calls(Type = typeof(Dysentery), Member = "DysenteryEnd")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(Fatigue), Member = "AddFatigue")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void UpdateDysentery()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Dysentery()
	{
	}
}
