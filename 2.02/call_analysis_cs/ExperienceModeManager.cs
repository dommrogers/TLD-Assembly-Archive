using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class ExperienceModeManager : MonoBehaviour
{
	private ExperienceMode[] m_ModeLookupTable;

	private CustomExperienceModeManager m_CustomModeManager;

	private bool m_HasInitializedSetupLookTable;

	private ExperienceMode[] m_ExperienceModeDefinitionList;

	private static ExperienceModeManagerSaveDataProxy m_ExperienceModeManagerSaveDataProxy;

	private static ExperienceModeType s_CurrentModeType;

	private static bool s_IsCustomBasedMode;

	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetupLookupTable")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetCurrentCustomModeString")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static ExperienceModeType GetCurrentExperienceModeType()
	{
		return default(ExperienceModeType);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "ShouldShowSpeakerName")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCurrentGameLabel")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "FindBackgroundAndLoadingText")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateLabels")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CalledBy(Type = typeof(CabinFever), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnNewSandbox")]
	public static bool IsCurrentEpisodeExperienceMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "MaybeInstantiateGameManager")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode_keep_inventory")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnNewSandbox4DON")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnNewSandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "OnNameStoryConfirmed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetupLookupTable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnNewSandbox4DON")]
	public void SetExperienceModeType(ExperienceModeType modeType)
	{
	}

	[CalledBy(Type = typeof(InternalUserReport._003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "SetLoadingScreenText")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public bool IsChallengeActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 48)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 15)]
	public ExperienceMode GetCurrentExperienceMode()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	public ExperienceMode GetSpecificExperienceMode(ExperienceModeType modeType)
	{
		return null;
	}

	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InternalUserReport._003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetXPModePopupListString")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnShareExperiencePopup")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "CreateStringFromCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	public string GetCurrentCustomModeString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Awake")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "SetValuesToMatchXPMode")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupCancelled")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(CustomExperienceModeManager), Member = "CreateCustomModeFromString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCodePopupConfirmed")]
	public bool SetCurrentCustomModeString(string inputString)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CustomExperienceMode), Member = "UpdateBaseValues")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 13)]
	public void SetupLookupTable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetDecayScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetCalorieBurnScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetThirstRateScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetFreezingRateScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetFatigueRateScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetConditonRecoveryFromRestScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetConditonRecoveryWhileAwakeScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetWeatherDurationScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetChanceOfBlizzardScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateUniStormDayLength")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateUniStormDayLength")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public float GetTimeOfDayScale()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSpawnRegionChanceActiveScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CalledBy(Type = typeof(GearItem), Member = "RollSpawnChance")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public float GetGearSpawnChanceScale()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(PrefabSpawn), Member = "SpawnObjects")]
	[CallsUnknownMethods(Count = 1)]
	public int GetReduceMaxItemsInContainer()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetChanceForEmptyContainer()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetClosestSpawnDistanceAfterTransitionScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetSmellRangeScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	public float GetStruggleTapStrenthScale()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStrugglePlayerDamageReceivedIntervalScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyClothingDamagePerSecond")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ClothingDamageEvent), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	public float GetStrugglePlayerClothingDamageScale()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyPlayerDamagePerSecond")]
	[CallsUnknownMethods(Count = 1)]
	public float GetStrugglePlayerDamageReceivedScale()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyBearDamageAfterStruggleEnds")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetStugglePlayerPercentLossFromBearScale()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[CallsUnknownMethods(Count = 1)]
	public float GetOutdoorTempDropCelcius(float numDays)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public float GetRespawnHoursScale(float numDays)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CallsUnknownMethods(Count = 1)]
	public float GetFishCatchTimeScale(float numDays)
	{
		return default(float);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetRepawnTime")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public float GetRadialRespawnTimeScale(float numDays)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNumHoursWarmForHypothermiaCureScale()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PackManager), Member = "Start")]
	[CalledBy(Type = typeof(PackManager), Member = "ArePacksAllowed")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	public bool GetWildlifeNotAttackUnprovoked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 1)]
	public bool GetWildlifeInterruptRest()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	public bool GetWeatherStartForceClear()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool GetWeatherWindForceCalm()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateCustomMode(ExperienceMode customMode)
	{
	}

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 5)]
	public CustomExperienceMode GetCustomMode()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool InCustomMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public float GetProportionalReduceMaxItems()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetCustomIndoorStartChance()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCustomAuroraChanceModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCustomWindSpeedModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	public float GetCustomWindChangeFrequencyModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCustomBloodScentModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
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

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoCustomModeModifiers")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public float GetCustomWolfFleeModifier(WolfType wolfType)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 3)]
	public float GetCustomPlantSpawnModifier()
	{
		return default(float);
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public float GetCustomWildlifeRespawnTimeModifier()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	public ExperienceModeType GetCustomLootXPType()
	{
		return default(ExperienceModeType);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_jump")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisodeFadeCallback")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public void RunInitCommandStory()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public ExperienceMode GetExperienceModeDefinition(ExperienceModeType xpModeType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private bool GetStandardModeWildlifeNotAttackUnprovoked()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private float GetWolfFleeModifier(CustomExperienceModeManager.CustomTunableNLMH tunable)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	private float GetCustomRegularWolfFleeModifier()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetCustomTimberWolfFleeModifier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ExperienceModeManager()
	{
	}
}
