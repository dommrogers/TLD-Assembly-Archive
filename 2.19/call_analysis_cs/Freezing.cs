using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
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
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Freezing), Member = "UpdateHoursWithinRangeOfFire")]
	[Calls(Type = typeof(Freezing), Member = "UpdateTemperatureBonusFromRunning")]
	[Calls(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[Calls(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Freezing), Member = "UpdateFreezingStatusOnHUD")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public string GetFreezingStateString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetTemperatureBonusFromRunning()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Apply")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyPumpkinPieBuff")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ApplyFreezingBuff")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "ApplyFreezing")]
	[CalledBy(Type = typeof(FoodStatEffect), Member = "Apply")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public void AddFreezing(float freezeValue)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsFreezing()
	{
		return false;
	}

	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateTemperatureOnHUD")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateFeelsLike")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateTemperatureLabels")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "UpdateFeelsLikeLabel")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateFeelsLikeLabel")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(Rest), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(PassTime), Member = "GetBedWarmthBonusCelsius")]
	[Calls(Type = typeof(Weather), Member = "GetCurrentWindchill")]
	[CallsUnknownMethods(Count = 3)]
	public float CalculateBodyTemperature()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void SetSuppressVoiceOver(bool suppress)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybePlayPlayerFreezingTeethChatter()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomEnd")]
	[CalledBy(Type = typeof(StoneItem), Member = "ZoomEnd")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeCancelPlayerFreezingTeethChatter()
	{
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "CalculateBodyTemperature")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Freezing), Member = "MaybeAdjustFreezingDueToNearbyFire")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateFreezingStatus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	private bool ShouldPlayFreezingVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Condition), Member = "CanPlayConditionVO")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 5)]
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
	private string GetFreezingTextForHud()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeUpdateFreezingStatusLabel(Panel_HUD hud)
	{
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateFreezingStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeUpdateFreezingStatusInLog()
	{
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateHoursWithinRangeOfFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetHoursWithinRangeOfFire()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Freezing), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateTemperatureBonusFromRunning()
	{
	}

	[CalledBy(Type = typeof(Freezing), Member = "UpdateFreezingStatus")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(FireManager), Member = "PointInRadiusOfBurningFire")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeAdjustFreezingDueToNearbyFire()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Freezing()
	{
	}
}
