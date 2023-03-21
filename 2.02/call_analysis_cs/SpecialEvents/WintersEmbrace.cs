using System;
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

	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WintersEmbrace), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void EatingComplete(GearItem itemEaten)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "EatingComplete")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsCurrentExperienceMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool MatchesExperienceMode(ExperienceModeType xpMode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	public static void PostEventConvertSaveSlot(string slotName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WintersEmbrace), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallsUnknownMethods(Count = 6)]
	public static void UpdateDaysSurvived(int numDaysSurvived)
	{
	}

	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "StringAllNullTerminators")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	private static void CheckSaveSlotForMissedBadges(string slotName)
	{
	}
}
