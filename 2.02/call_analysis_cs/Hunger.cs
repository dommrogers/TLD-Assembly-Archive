using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Hunger : MonoBehaviour
{
	public float m_CurrentReserveCalories;

	public float m_CaloriesEatenToday;

	public float m_CaloriesExpendedToday;

	private float m_ReserveCaloriesAccumulator;

	public float m_SlightlyHungryCalorieThreshold;

	public float m_HungryCalorieThreshold;

	public float m_VeryHungryCalorieThreshold;

	public float m_StarvingCalorieThreshold;

	public string m_SlightlyHungryVoiceOver;

	public string m_HungryVoiceOver;

	public string m_VeryHungryVoiceOver;

	public string m_StarvingVoiceOver;

	public float m_MinSecondsBetweenVoiceOverVariations;

	public float m_TimeToDisplayCaloriesWhenChanged;

	public float m_TimeToDisplayHungerWhenChanged;

	public float m_HoursStarvingBeforeFatiguePenalty;

	public float m_FatiguePenaltyPerHourIncrease;

	public float m_FatiguePenaltyPerHourDecrease;

	public float m_MaxFatiguePenalty;

	public float m_HungerStartsAtCalories;

	public float m_MaxReserveCalories;

	public float m_MaxDeficitCalories;

	public float m_StartingReserveCalories;

	public float m_CalorieBurnPerHourSleeping;

	public float m_CalorieBurnPerHourStanding;

	public float m_CalorieBurnPerHourWalking;

	public float m_CalorieBurnPerHourSprinting;

	public float m_CalorieBurnPerHourBreakingDown;

	public float m_CalorieBurnPerHourBuildingSnowShelter;

	public float m_CalorieBurnPerHourRepairingSnowShelter;

	public float m_CalorieBurnPerHourDismantlingSnowShelter;

	public float m_CalorieBurnPerHourBuildingLeanTo;

	public float m_CalorieBurnPerHourRepairingLeanTo;

	public float m_CalorieBurnPerHourDismantlingLeanTo;

	public float m_CalorieBurnPerHourRotatingLeanTo;

	public float m_CalorieBurnPerHourHarvestingCarcass;

	public float m_CalorieBurnPerHourClimbing;

	private float m_CurrentCalorieBurnPerHour;

	private HungerLevel m_HungerLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private FoodItem m_FoodItemProvidingCalories;

	private float m_CaloriesToAddOverTime;

	private float m_CaloriesLeftToAdd;

	private float m_CalroiesToAddOverTimeDuration;

	private float m_TimeDisableCaloriesOnHUD;

	private float m_TimeDisableHungerOnHUD;

	private int m_HungerLevelLastStatusChange;

	private float m_NumHoursStarving;

	private float m_FatiguePenalty;

	private bool m_StarvingInLog;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressVoiceOver;

	private static HungerSaveDataProxy m_HungerSaveDataProxy;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Hunger), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Hunger), Member = "UpdateFatiguePenalty")]
	[Calls(Type = typeof(Hunger), Member = "UpdateStarvingStatusOnHUD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hunger), Member = "UpdateCaloriesOnHUD")]
	[Calls(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Hunger), Member = "MaybeUpdateStarvingStatusInLog")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Hunger), Member = "MaybePlayPlayerHungryVoiceOver")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Hunger), Member = "Start")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 6)]
	public void AddReserveCalories(float calories)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveReserveCalories(float calories)
	{
	}

	[CallerCount(Count = 0)]
	public void AddReserveCaloriesOverTime(FoodItem fi, float calories, float timeSeconds)
	{
	}

	[CallerCount(Count = 0)]
	public void ResetFoodItemProvingCalories()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsEatingInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void ClearAddReserveCaloriesOverTime()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAddingCaloriesOverTime()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	public bool ItemBeingEatenAffectsThirst()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public FoodItem GetItemBeingEaten()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetCaloriesToAddOverTime()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsStarving()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void SetCalorieBurnPerHour(float burnRate)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCalorieReserves()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentCalorieBurnPerHour()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void DisplayCaloriesOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetFatiguePenalty()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hunger), Member = "RemoveReserveCalories")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void UpdateCalorieReserves()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayHungerVoiceOver()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybePlayPlayerHungryVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	private HungerLevel GetHungerLevel()
	{
		return default(HungerLevel);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallsUnknownMethods(Count = 60)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateCaloriesOnHUD()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void DisplayHungerOnHUDForTime(float seconds)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetHungerTextForHud()
	{
		return null;
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void MaybeUpdateStarvingStatusLabel()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private string GetHungerIconName(int currHungerLevel)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 37)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void UpdateStarvingStatusOnHUD()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float CalculateNextCaloriesThresholdForDisplayOnHud()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void MaybeUpdateStarvingStatusInLog()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFatiguePenalty()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Hunger()
	{
	}
}
