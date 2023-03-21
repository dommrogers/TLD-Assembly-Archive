using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;

public static class PostSpecialEvent
{
	private static bool s_HasManagedSaveData;

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static void ManageSaveData()
	{
	}
}
