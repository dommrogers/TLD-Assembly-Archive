using Cpp2ILInjected.CallAnalysis;

namespace SpecialEvents;

public static class WintersEmbrace
{
	public const int BADGE_DAYS_TO_SURVIVE = 25;

	public const int BADGE_ITEMS_TO_CONSUME = 2;

	public const int BADGE_QUANTITY_TO_CONSUME = 25;

	public const ExperienceModeType EVENT_XPMODE = ExperienceModeType.EventWintersEmbrace;

	public const ExperienceModeType BASE_XPMODE = ExperienceModeType.Voyageur;

	private static readonly string[] ITEMS_TO_EAT_NAMES;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	public static bool IsCurrentExperienceMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[Calls(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	public static void PostEventConvertSaveSlot(string slotName)
	{
	}

	[Calls(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	private static void CheckSaveSlotForMissedBadges(string slotName)
	{
	}
}
