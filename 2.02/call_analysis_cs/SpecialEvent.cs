using System;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;

public static class SpecialEvent
{
	private const bool SPECIAL_EVENT_ACTIVE = false;

	private static readonly DateTime EVENT_END_DATE;

	private static bool s_DebugEventActiveOverride;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void Debug_DisableEvent()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerExit")]
	public static bool IgnoreInteriorTemperatureTriggers()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnNewSandbox4DON")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesBaseExperienceMode")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlotsFourDaysOfNight")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Update")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableSpecialEvent")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	public static bool IsActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForEvent")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsCurrentExperienceMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static ExperienceModeType GetBaseExperienceMode()
	{
		return default(ExperienceModeType);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "AddMenuItem")]
	public static string GetSandboxMenuDescSuffix()
	{
		return null;
	}

	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool MatchesBaseExperienceMode(ExperienceModeType xpMode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SelectRegion), Member = "OnClickBack")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "SetExperienceModeIcon")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "GetNumDosesRequired")]
	[CalledBy(Type = typeof(StruggleDamageEvent), Member = "GetChance")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void EatingComplete(GearItem itemEaten)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}
}
