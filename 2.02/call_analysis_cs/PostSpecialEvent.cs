using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;

public static class PostSpecialEvent
{
	private static bool s_HasManagedSaveData;

	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "IsUnlocked")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NowhereToHide), Member = "PostEventDeleteSaveSlot")]
	[CallerCount(Count = 1)]
	public static void ManageSaveData()
	{
	}
}
