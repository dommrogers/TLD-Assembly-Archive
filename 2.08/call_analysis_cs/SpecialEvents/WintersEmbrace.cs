using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;

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
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return false;
	}

	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[Calls(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	public static void PostEventConvertSaveSlot(string slotName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void CheckSaveSlotForMissedBadges(string slotName)
	{
	}
}
