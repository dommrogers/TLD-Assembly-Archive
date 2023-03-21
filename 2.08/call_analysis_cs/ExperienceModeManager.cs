using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Events;
using TLD.Gameplay;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ExperienceModeManager : MonoBehaviour
{
	private const ExperienceModeType DefaultExperienceModeType = ExperienceModeType.Voyageur;

	private GameEvent m_ExperienceModeChanged;

	private AssetLabelReference m_GameModeLabel;

	private readonly List<GameModeConfig> m_AvailableGameModes;

	private static readonly ExperienceModeManagerSaveDataProxy m_ExperienceModeManagerSaveDataProxy;

	private static GameModeConfig s_CurrentGameMode;

	private static ExperienceModeManager _003CInstance_003Ek__BackingField;

	public static ExperienceModeManager Instance
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "get_CurrentMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "FillSaveSlotInfo")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameModeConfig GetGameModeFromName(string gameModeName)
	{
		return null;
	}

	[CallerCount(Count = 102)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static ExperienceModeType GetCurrentExperienceModeType()
	{
		return default(ExperienceModeType);
	}

	[CallerCount(Count = 0)]
	public static GameModeConfig GetCurrentGameModeConfig()
	{
		return null;
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameEvent), Member = "Post")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	public void SetGameModeConfig(GameModeConfig gameModeConfig)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetLoadingScreenText")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	public bool IsChallengeActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 62)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public ExperienceMode GetCurrentExperienceMode()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CallsUnknownMethods(Count = 2)]
	public ExperienceMode GetSpecificExperienceMode(ExperienceModeType modeType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateCustomModeFromString")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool SetCurrentCustomModeString(string inputString)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetDecayScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetCalorieBurnScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public float GetThirstRateScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetFreezingRateScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetFatigueRateScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public float GetConditonRecoveryFromRestScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetConditonRecoveryWhileAwakeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWeatherDurationScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public float GetChanceOfBlizzardScale()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateUniStormDayLength")]
	[CallsUnknownMethods(Count = 1)]
	public float GetTimeOfDayScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 2)]
	public float GetSpawnRegionChanceActiveScale()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CallsUnknownMethods(Count = 1)]
	public float GetGearSpawnChanceScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetReduceMaxItemsInContainer()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public int GetChanceForEmptyContainer()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public float GetClosestSpawnDistanceAfterTransitionScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSmellRangeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStruggleTapStrenthScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStugglePlayerPercentLossFromBearScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public float GetOutdoorTempDropCelcius(float numDays)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRespawnHoursScale(float numDays)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public float GetFishCatchTimeScale(float numDays)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRadialRespawnTimeScale(float numDays)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNumHoursWarmForHypothermiaCureScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "Start")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "ArePacksAllowed")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "InCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	public bool GetWildlifeNotAttackUnprovoked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool GetWildlifeInterruptRest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	public bool GetWeatherStartForceClear()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool GetWeatherWindForceCalm()
	{
		return default(bool);
	}

	[CallerCount(Count = 23)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public CustomExperienceMode GetCustomMode()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "InCustomMode")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool InCustomMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	public float GetProportionalReduceMaxItems()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	public float GetCustomAuroraChanceModifier()
	{
		return default(float);
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetCustomWindSpeedModifier()
	{
		return default(float);
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetCustomWindChangeFrequencyModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	public float GetCustomBloodScentModifier()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	public float GetCustomWildlifeDetectionModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCustomWolfFleeModifier(WolfType wolfType)
	{
		return default(float);
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetCustomPlantSpawnModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	public float GetCustomWildlifeRespawnTimeModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallsUnknownMethods(Count = 1)]
	public ExperienceModeType GetCustomLootXPType()
	{
		return default(ExperienceModeType);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void RunInitCommandStory()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private T GetExperienceModeDefinition<T>() where T : ExperienceMode
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "CreateStringFromCustomMode")]
	private string GetCurrentCustomModeString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool GetStandardModeWildlifeNotAttackUnprovoked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 2)]
	private float GetCustomRegularWolfFleeModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 0)]
	private float GetCustomTimberWolfFleeModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public ExperienceModeManager()
	{
	}
}
