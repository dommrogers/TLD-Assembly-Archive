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

	[CalledBy(Type = typeof(Hunger), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[Calls(Type = typeof(Hunger), Member = "UpdateCaloriesOnHUD")]
	[Calls(Type = typeof(Hunger), Member = "UpdateStarvingStatusOnHUD")]
	[Calls(Type = typeof(Hunger), Member = "UpdateFatiguePenalty")]
	[Calls(Type = typeof(Hunger), Member = "MaybePlayPlayerHungryVoiceOver")]
	[Calls(Type = typeof(Hunger), Member = "MaybeUpdateStarvingStatusInLog")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hunger), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void AddReserveCalories(float calories)
	{
	}

	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsEatingInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void ClearAddReserveCaloriesOverTime()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsAddingCaloriesOverTime()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool ItemBeingEatenAffectsThirst()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public FoodItem GetItemBeingEaten()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCaloriesToAddOverTime()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool IsStarving()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void SetCalorieBurnPerHour(float burnRate)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCalorieReserves()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCurrentCalorieBurnPerHour()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void DisplayCaloriesOnHUDForTime(float seconds)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetFatiguePenalty()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hunger), Member = "RemoveReserveCalories")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateCalorieReserves()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldPlayHungerVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void MaybePlayPlayerHungryVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	private HungerLevel GetHungerLevel()
	{
		return default(HungerLevel);
	}

	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 60)]
	private void UpdateCaloriesOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisplayHungerOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetHungerTextForHud()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeUpdateStarvingStatusLabel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetHungerIconName(int currHungerLevel)
	{
		return null;
	}

	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 37)]
	private void UpdateStarvingStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float CalculateNextCaloriesThresholdForDisplayOnHud()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateStarvingStatusInLog()
	{
	}

	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFatiguePenalty()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Hunger()
	{
	}
}
