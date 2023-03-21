using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CustomExperienceMode : ExperienceMode
{
	public bool m_AllowInteriorStartingSpawn;

	public bool m_SurvivorVoiceOver;

	public bool m_WeakIce;

	public bool m_UseMinAirTempValue;

	public bool m_EnableDysentery;

	public bool m_EnableSprains;

	public bool m_EnableFoodPoisoning;

	public bool m_EnableBrokenRibs;

	public bool m_LimitedRest;

	public bool m_AdjustFreezingDueToNearbyFire;

	public bool m_InterruptIfFreezingWhileSleeping;

	public bool m_RiflesInWorld;

	public bool m_RevolversInWorld;

	public bool m_IsBirchBarkTreeCraftable;

	public CustomExperienceModeManager.CustomTunableLMHV m_BaseWorldDifficulty;

	public CustomExperienceModeManager.CustomTunableNLMH m_StruggleClothingDamageBonus;

	public CustomExperienceModeManager.CustomTunableDayNightMultiplier m_DayNightLengthMultiplier;

	public CustomExperienceModeManager.CustomTunableLMHV m_WeatherChangeFrequency;

	public CustomExperienceModeManager.CustomTunableNLMH m_StrugglePlayerStrengthBonus;

	public CustomExperienceModeManager.CustomTunableNLMH m_GradualTempReductionRate;

	public CustomExperienceModeManager.CustomTunableNLMH m_AuroraFrequency;

	public CustomExperienceModeManager.CustomTunableLMHV m_CalorieBurnRate;

	public CustomExperienceModeManager.CustomTunableLMHV m_ThirstIncrease;

	public CustomExperienceModeManager.CustomTunableLMHV m_FatigueIncrease;

	public CustomExperienceModeManager.CustomTunableLMHV m_FreezingIncrease;

	public CustomExperienceModeManager.CustomTunableLMHV m_HoursWarmthToCureHypothermia;

	public CustomExperienceModeManager.CustomTunableLMHV m_ItemDecayRate;

	public CustomExperienceModeManager.CustomTunableLMHV m_ItemSpawnChance;

	public CustomExperienceModeManager.CustomTunableNLMH m_ReduceWildlifePopOverTime;

	public CustomExperienceModeManager.CustomTunableNLMH m_EmptyContainerChance;

	public CustomExperienceModeManager.CustomTunableLMHV m_StickBranchStoneSpawnFrequency;

	public CustomExperienceModeManager.CustomTunableLMHV m_StartingGear;

	public CustomExperienceModeManager.CustomTunableNLMH m_StruggleDamageReceivedBonus;

	public CustomExperienceModeManager.CustomTunableNLMH m_ScentIncreaseFromMeatBlood;

	public CustomExperienceModeManager.CustomTunableNLMH m_WolfFleeChance;

	public CustomExperienceModeManager.CustomTunableLMH m_TimberWolfPackFear;

	public CustomExperienceModeManager.CustomTunableLMHV m_StruggleDamageEventSeverity;

	public CustomExperienceModeManager.CustomTunableLMHV m_WildlifeSmellRange;

	public CustomExperienceModeManager.CustomTunableLMHV m_WildlifeSpawnFrequency;

	public bool m_WildlifeNotAttackUnprovoked;

	public bool m_NoPredatorsFirstDay;

	public bool m_CabinFeverEnabled;

	public bool m_ParasitesEnabled;

	public CustomExperienceModeManager.CustomTunableNLMHV m_ConditionRecoveryRest;

	public CustomExperienceModeManager.CustomTunableNLMHV m_ConditionRecoveryAwake;

	public CustomExperienceModeManager.CustomTunableNLMHV m_FrosbiteRisk;

	public CustomExperienceModeManager.CustomTunableNLMHV m_RabbitSpawnChance;

	public CustomExperienceModeManager.CustomTunableNLMHV m_BearSpawnChance;

	public CustomExperienceModeManager.CustomTunableNLMHV m_BlizzardFrequency;

	public CustomExperienceModeManager.CustomTunableNLMHV m_DeerSpawnChance;

	public CustomExperienceModeManager.CustomTunableNLMHV m_FishSpawnChance;

	public CustomExperienceModeManager.CustomTunableNLMHV m_WolfSpawnChance;

	public CustomExperienceModeManager.CustomTunableNLMHV m_TimberWolfSpawnChance;

	public CustomExperienceModeManager.CustomTunableTimeOfDay m_StartTimeOfDay;

	public bool m_WildlifeInterruptRest;

	public CustomExperienceModeManager.CustomTunableLMH m_WindVariability;

	public CustomExperienceModeManager.CustomTunableLMH m_PlantSpawnFrequency;

	public CustomExperienceModeManager.CustomTunableNLH m_ReduceMaxItemsContainers;

	public CustomExperienceModeManager.CustomTunableWeather m_StartWeather;

	public CustomExperienceModeManager.CustomTunableDistance m_WolfSpawnDistance;

	public CustomExperienceModeManager.CustomTunableDistance m_WildlifeDetectionRange;

	public CustomExperienceModeManager.CustomTunableNLMHV m_MooseSpawnChance;

	public bool m_EndlessNight;

	[NonSerialized]
	public int m_Version;

	public const int CURRENT_VERSION = 1;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "SetupLookupTable")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBaseXPModesSortedByDifficultyAsc")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public bool UpdateBaseValues()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public CustomExperienceModeManager.CustomTunableNLMHV GetWolfSpawnChance(WolfType wolfType)
	{
		return default(CustomExperienceModeManager.CustomTunableNLMHV);
	}

	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 99)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsDeduplicatedMethods(Count = 79)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	public void SendAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	protected override void AwakeInternal()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[CallsUnknownMethods(Count = 16)]
	private List<ExperienceMode> GetBaseXPModesSortedByDifficultyAsc()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CustomExperienceMode()
	{
	}
}
