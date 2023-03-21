using System;
using System.Collections;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Tunable;
using TLD.Stats;
using UnityEngine;

namespace TLD.Gameplay;

public class CustomExperienceMode : ExperienceMode
{
	private const int SHARING_STRING_LEN = 20;

	private CustomExperienceModeTunableLookupTable m_LookupTable;

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

	public CustomTunableLMHV m_BaseWorldDifficulty;

	public CustomTunableNLMH m_StruggleClothingDamageBonus;

	public CustomTunableDayNightMultiplier m_DayNightLengthMultiplier;

	public CustomTunableLMHV m_WeatherChangeFrequency;

	public CustomTunableNLMH m_StrugglePlayerStrengthBonus;

	public CustomTunableNLMH m_GradualTempReductionRate;

	public CustomTunableNLMH m_AuroraFrequency;

	public CustomTunableLMHV m_CalorieBurnRate;

	public CustomTunableLMHV m_ThirstIncrease;

	public CustomTunableLMHV m_FatigueIncrease;

	public CustomTunableLMHV m_FreezingIncrease;

	public CustomTunableLMHV m_HoursWarmthToCureHypothermia;

	public CustomTunableLMHV m_ItemDecayRate;

	public CustomTunableLMHV m_ItemSpawnChance;

	public CustomTunableNLMH m_ReduceWildlifePopOverTime;

	public CustomTunableNLMH m_EmptyContainerChance;

	public CustomTunableLMHV m_StickBranchStoneSpawnFrequency;

	public CustomTunableLMHV m_StartingGear;

	public CustomTunableNLMH m_StruggleDamageReceivedBonus;

	public CustomTunableNLMH m_ScentIncreaseFromMeatBlood;

	public CustomTunableNLMH m_WolfFleeChance;

	public CustomTunableLMH m_TimberWolfPackFear;

	public CustomTunableLMHV m_StruggleDamageEventSeverity;

	public CustomTunableLMHV m_WildlifeSmellRange;

	public CustomTunableLMHV m_WildlifeSpawnFrequency;

	public bool m_WildlifeNotAttackUnprovoked;

	public bool m_NoPredatorsFirstDay;

	public bool m_CabinFeverEnabled;

	public bool m_ParasitesEnabled;

	public CustomTunableNLMHV m_ConditionRecoveryRest;

	public CustomTunableNLMHV m_ConditionRecoveryAwake;

	public CustomTunableNLMHV m_FrosbiteRisk;

	public CustomTunableNLMHV m_RabbitSpawnChance;

	public CustomTunableNLMHV m_BearSpawnChance;

	public CustomTunableNLMHV m_BlizzardFrequency;

	public CustomTunableNLMHV m_DeerSpawnChance;

	public CustomTunableNLMHV m_FishSpawnChance;

	public CustomTunableNLMHV m_WolfSpawnChance;

	public CustomTunableNLMHV m_TimberWolfSpawnChance;

	public CustomTunableTimeOfDay m_StartTimeOfDay;

	public bool m_WildlifeInterruptRest;

	public CustomTunableLMH m_WindVariability;

	public CustomTunableLMH m_PlantSpawnFrequency;

	public CustomTunableNLH m_ReduceMaxItemsContainers;

	public CustomTunableWeather m_StartWeather;

	public CustomTunableDistance m_WolfSpawnDistance;

	public CustomTunableDistance m_WildlifeDetectionRange;

	public CustomTunableNLMHV m_MooseSpawnChance;

	public bool m_EndlessNight;

	[NonSerialized]
	public int m_Version;

	public const int CURRENT_VERSION = 1;

	public override bool InterruptIfFreezingWhileSleeping
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public override bool AdjustFreezingDueToNearbyFire
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override PackSettings GetPackSettings()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetIndoorStartChance()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetAuroraChanceModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetWindSpeedModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetWindChangeFrequencyModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetBloodScentModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetWildlifeDetectionModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetPlantSpawnModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetWildlifeRespawnTimeModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetWolfFleeModifier(CustomTunableNLMH tunable)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetRegularWolfFleeModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetTimberWolfFleeModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetProportionalReduceMaxItems()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int GetSharingStringLengthWithDashes()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 115)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public bool UpdateBaseValues()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public CustomTunableNLMHV GetWolfSpawnChance(WolfType wolfType)
	{
		return default(CustomTunableNLMHV);
	}

	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsDeduplicatedMethods(Count = 83)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallerCount(Count = 1)]
	public void SendAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private ExperienceMode GetBaseDifficulty()
	{
		return null;
	}

	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Awake")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetValuesToMatchXPMode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomModeString")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	public static bool CreateCustomModeFromString(CustomExperienceMode customMode, string inputString)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "set_Item")]
	[Calls(Type = typeof(BitArray), Member = "set_Item")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(BitArray), Member = "set_Item")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(BitArray), Member = "set_Item")]
	[Calls(Type = typeof(BitArray), Member = "set_Item")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnShareExperiencePopup")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[CallsUnknownMethods(Count = 62)]
	[Calls(Type = typeof(BitArray), Member = "set_Item")]
	[Calls(Type = typeof(BitArray), Member = "get_Item")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	public static string CreateStringFromCustomMode(CustomExperienceMode customMode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	private static int BitsToDecimal(BitArray bitArray, int startIndex, int length)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallsUnknownMethods(Count = 14)]
	private static int[] ConvertDecToBase(int decimalValue, int baseValue, int size)
	{
		return null;
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	private static BitArray GetBitArrayFromDec(int decValue, int desiredLength)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public CustomExperienceMode()
	{
	}
}
