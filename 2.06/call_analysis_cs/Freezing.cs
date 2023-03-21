using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
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

	public AK.Wwise.Event m_SlightlyColdAudio;

	public AK.Wwise.Event m_ColdAudio;

	public AK.Wwise.Event m_VeryColdAudio;

	public AK.Wwise.Event m_FreezingAudio;

	public AK.Wwise.Event m_FreezingTeethChatterAudio;

	public float m_MinSecondsBetweenVoiceOverVariations;

	private PanelReference<Panel_HUD> m_HUD;

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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Freezing), Member = "UpdateFreezingStatusOnHUD")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[Calls(Type = typeof(Freezing), Member = "UpdateTemperatureBonusFromRunning")]
	[Calls(Type = typeof(Freezing), Member = "UpdateHoursWithinRangeOfFire")]
	[Calls(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
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

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "ApplyFreezing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPumpkinPieBuff")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Apply")]
	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyFreezingBuff")]
	public void AddFreezing(float freezeValue)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFreezing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateFeelsLikeLabel")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateTemperatureLabels")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateFeelsLike")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[Calls(Type = typeof(Weather), Member = "GetCurrentWindchill")]
	[Calls(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	public float CalculateBodyTemperature()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybePlayPlayerFreezingTeethChatter()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomEnd")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	public void MaybeCancelPlayerFreezingTeethChatter()
	{
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Freezing), Member = "MaybeAdjustFreezingDueToNearbyFire")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateFreezingStatus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayFreezingVoiceOver()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybePlayPlayerFreezingVoiceOver()
	{
	}

	[CallerCount(Count = 0)]
	private FreezingLevel GetFreezingLevel()
	{
		return default(FreezingLevel);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateBodyTempStats(float bodyTemp)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisplayFreezingOnHUDForTime(float seconds)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private string GetFreezingTextForHud()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void MaybeUpdateFreezingStatusLabel(Panel_HUD hud)
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void UpdateFreezingStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateFreezingStatusInLog()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void UpdateHoursWithinRangeOfFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHoursWithinRangeOfFire()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateTemperatureBonusFromRunning()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeAdjustFreezingDueToNearbyFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Freezing()
	{
	}
}
