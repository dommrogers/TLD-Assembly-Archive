using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Freezing : MonoBehaviour
{
	public float m_CurrentFreezingPerHour;

	public float m_CurrentWarmingPerHour;

	public float m_CurrentFreezing;

	public float m_MaxFreezing;

	public float m_TemperatureFreezingStarts;

	public float m_FreezingIncreasePerHourPerDegreeCelsius;

	public float m_WarmingIncreasePerHourPerDegreeCelsius;

	public float m_CalorieBurnMultiplier;

	public float m_SlightlyColdThreshold;

	public float m_ColdThreshold;

	public float m_VeryColdThreshold;

	public float m_FreezingThreshold;

	public float m_MaxTemperatureBonusFromRunning;

	public float m_NumGameMinutesToRampRunningTemperatureBonus;

	public float m_NumGameMinutesToHoldRunningTemperatureBonus;

	public float m_NumGameMinutesToRampDownRunningTemperatureBonus;

	public string m_SlightlyColdVoiceOver;

	public string m_ColdVoiceOver;

	public string m_VeryColdVoiceOver;

	public string m_FreezingVoiceOver;

	public string m_FreezingTeethChatter;

	public float m_MinSecondsBetweenVoiceOverVariations;

	public float m_TimeToDisplayFreezingWhenChanged;

	public float m_PercentModifierPerWetClothingItem;

	public static bool m_ShowRunningTempBonus;

	private FreezingLevel m_FreezingLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private float m_TimeDisableFreezingOnHUD;

	private int m_FreezingLevelLastStatusChange;

	private float m_TemperatureBonusFromRunning;

	private bool m_FreezingInLog;

	private float m_HoldRunningTemperatureBonusMinutes;

	private float m_HoursInRangeOfFire;

	private bool m_StartHasBeenCalled;

	private bool m_SuppressVoiceOver;

	private static FreezingSaveDataProxy m_FreezingSaveDataProxy;

	private uint m_FreezingTeethChatterSoundId;

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Freezing), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Freezing), Member = "UpdateTemperatureBonusFromRunning")]
	[Calls(Type = typeof(Freezing), Member = "UpdateHoursWithinRangeOfFire")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "MaybeUpdateFreezingStatusInLog")]
	[Calls(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Freezing), Member = "UpdateFreezingStatusOnHUD")]
	[Calls(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	private void Update()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "Start")]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public string GetFreezingStateString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetTemperatureBonusFromRunning()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPumpkinPieBuff")]
	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Apply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyFreezingBuff")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "ApplyFreezing")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddFreezing(float freezeValue)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFreezing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateFeelsLikeLabel")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateTemperatureLabels")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateFeelsLike")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[Calls(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(Weather), Member = "GetCurrentWindchill")]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	public float CalculateBodyTemperature()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	public void MaybePlayPlayerFreezingTeethChatter()
	{
	}

	[CalledBy(Type = typeof(StoneItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CallsUnknownMethods(Count = 5)]
	public void MaybeCancelPlayerFreezingTeethChatter()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Freezing), Member = "MaybeAdjustFreezingDueToNearbyFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void UpdateFreezingStatus()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayFreezingVoiceOver()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	private void MaybePlayPlayerFreezingVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	private FreezingLevel GetFreezingLevel()
	{
		return default(FreezingLevel);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateBodyTempStats(float bodyTemp)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void DisplayFreezingOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetFreezingTextForHud()
	{
		return null;
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void MaybeUpdateFreezingStatusLabel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateFreezingStatusOnHUD()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void MaybeUpdateFreezingStatusInLog()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfFullyBurningFire")]
	private void UpdateHoursWithinRangeOfFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHoursWithinRangeOfFire()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateTemperatureBonusFromRunning()
	{
	}

	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeAdjustFreezingDueToNearbyFire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Freezing()
	{
	}
}
