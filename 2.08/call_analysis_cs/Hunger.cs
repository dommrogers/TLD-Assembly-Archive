using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Hunger), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Hunger), Member = "MaybePlayPlayerHungryVoiceOver")]
	[Calls(Type = typeof(Hunger), Member = "UpdateFatiguePenalty")]
	[Calls(Type = typeof(Hunger), Member = "UpdateStarvingStatusOnHUD")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Hunger), Member = "UpdateCaloriesOnHUD")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Hunger), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Hunger), Member = "UpdateCalorieReserves")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 4)]
	public void AddReserveCalories(float calories)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[CalledBy(Type = typeof(Panel_GenericProgressBar), Member = "UpdateActiveBars")]
	[CallerCount(Count = 2)]
	public bool ItemBeingEatenAffectsThirst()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FoodItem GetItemBeingEaten()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetCaloriesToAddOverTime()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsStarving()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Hunger), Member = "AddReserveCalories")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Thirst), Member = "AddThirst")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateCalorieReserves()
	{
	}

	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallerCount(Count = 0)]
	private bool ShouldPlayHungerVoiceOver()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybePlayPlayerHungryVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	private HungerLevel GetHungerLevel()
	{
		return default(HungerLevel);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	private void UpdateCaloriesOnHUD(Panel_HUD hud)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void DisplayHungerOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetHungerTextForHud()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void MaybeUpdateStarvingStatusLabel(Panel_HUD hud)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private string GetHungerIconName(int currHungerLevel)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateStarvingStatusOnHUD(Panel_HUD hud)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private float CalculateNextCaloriesThresholdForDisplayOnHud()
	{
		return default(float);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void MaybeUpdateStarvingStatusInLog()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Hunger), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFatiguePenalty()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Hunger()
	{
	}
}
