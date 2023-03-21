using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;

public static class PostSpecialEvent
{
	private static bool s_HasManagedSaveData;

	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	public static void ManageSaveData()
	{
	}
}
