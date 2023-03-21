using System;
using Cpp2ILInjected.CallAnalysis;

public static class SpecialEvent
{
	private const bool SPECIAL_EVENT_ACTIVE = false;

	private static readonly DateTime EVENT_END_DATE;

	private static bool s_DebugEventActiveOverride;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Debug_DisableEvent()
	{
	}

	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IgnoreInteriorTemperatureTriggers()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableSpecialEvent")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnNewSandbox4DON")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlotsFourDaysOfNight")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesBaseExperienceMode")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForEvent")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsCurrentExperienceMode()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static ExperienceModeType GetBaseExperienceMode()
	{
		return default(ExperienceModeType);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static ExperienceModeType GetExperienceMode()
	{
		return default(ExperienceModeType);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetMainMenuDescLocId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetMainMenuLabelLocId()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "AddMenuItem")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetSandboxMenuDescSuffix()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool MatchesBaseExperienceMode(ExperienceModeType xpMode)
	{
		return false;
	}

	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "SetExperienceModeIcon")]
	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "OnClickBack")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void EatingComplete(GearItem itemEaten)
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}
}
