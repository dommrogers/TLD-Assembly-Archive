using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

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
	[Calls(Type = typeof(WintersEmbrace), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public static void EatingComplete(GearItem itemEaten)
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "EatingComplete")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public static void PostEventConvertSaveSlot(string slotName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WintersEmbrace), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Utils), Member = "StringAllNullTerminators")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static void CheckSaveSlotForMissedBadges(string slotName)
	{
	}
}
