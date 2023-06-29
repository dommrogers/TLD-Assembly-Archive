using System;
using System.Collections;
using Cpp2ILInjected.CallAnalysis;
using TLD.AI;
using TLD.Gameplay.Tunable;
using TLD.GameplayTags;
using TLD.SaveState;
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
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public override bool AdjustFreezingDueToNearbyFire
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public override PackSettings GetPackSettings()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetIndoorStartChance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetAuroraChanceModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWindSpeedModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWindChangeFrequencyModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetBloodScentModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWildlifeDetectionModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPlantSpawnModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWildlifeRespawnTimeModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWolfFleeModifier(CustomTunableNLMH tunable)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRegularWolfFleeModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTimberWolfFleeModifier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetProportionalReduceMaxItems()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int GetSharingStringLengthWithDashes()
	{
		return 0;
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceMode), Member = "SetSpawnRegionLevel")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSpawnRegionLevels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceMode), Member = "SetSpawnRegionLevel")]
	private void UpdateSpawnRegionLevel(GameplayTag tag, CustomTunableNLMHV spawnChance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public ExperienceMode GetPilgrimExperienceMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public ExperienceMode GetVoyageurExperienceMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public ExperienceMode GetStalkerExperienceMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public ExperienceMode GetInterloperExperienceMode()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomXPSettingsFromUI")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "OnValidate")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CustomTunableLookup<, >), Member = "GetValue")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateSpawnRegionLevels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 98)]
	public bool UpdateBaseValues()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public CustomTunableNLMHV GetWolfSpawnChance(WolfType wolfType)
	{
		return default(CustomTunableNLMHV);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 78)]
	[CallsUnknownMethods(Count = 3)]
	public void SendAnalytics()
	{
	}

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private ExperienceMode GetBaseDifficulty()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetCustomModeString")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetValuesToMatchXPMode")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Awake")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Convert), Member = "FromBase64CharPtr")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "BitsToDecimal")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "ConvertDecToBase")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[CallsUnknownMethods(Count = 2)]
	public static bool CreateCustomModeFromString(CustomExperienceMode customMode, string inputString)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnShareExperiencePopup")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "DoMainScreenControls")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[CalledBy(TypeFullName = "InternalUserReport.<>c__DisplayClass7_0", Member = "<Send>b__1")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "GetBitArrayFromDec")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public static string CreateStringFromCustomMode(CustomExperienceMode customMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	private static int BitsToDecimal(BitArray bitArray, int startIndex, int length)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static int[] ConvertDecToBase(int decimalValue, int baseValue, int size)
	{
		return null;
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = ".ctor")]
	[Calls(Type = typeof(BitArray), Member = "Get")]
	[Calls(Type = typeof(BitArray), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
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
