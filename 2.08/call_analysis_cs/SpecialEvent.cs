using System;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using TLD.TimeLib;

public static class SpecialEvent
{
	private const bool SPECIAL_EVENT_ACTIVE = false;

	private static readonly DateTime EVENT_END_DATE;

	private static bool s_DebugEventActiveOverride;

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void Debug_DisableEvent()
	{
	}

	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	public static bool IgnoreInteriorTemperatureTriggers()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableSpecialEvent")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesBaseExperienceMode")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	public static bool IsActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
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
	public static string GetMainMenuDescLocId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static string GetMainMenuLabelLocId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static string GetSandboxMenuDescSuffix()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	public static bool MatchesBaseExperienceMode(ExperienceModeType xpMode)
	{
		return false;
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void EatingComplete(GearItem itemEaten)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}
}
