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

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(InteriorTemperatureTrigger), Member = "OnTriggerExit")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	public static bool IgnoreInteriorTemperatureTriggers()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableSpecialEvent")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "MatchesBaseExperienceMode")]
	public static bool IsActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 0)]
	public static bool IsCurrentExperienceMode()
	{
		return default(bool);
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
		return default(bool);
	}

	[CalledBy(Type = typeof(SpecialEvent), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IgnoreInteriorTemperatureTriggers")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "GetExperienceMode")]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void EatingComplete(GearItem itemEaten)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(ServerTime), Member = "GetServerTime")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetDailyTimerLabel(UILabel dayLabel, UILabel timerLabel)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}
}
