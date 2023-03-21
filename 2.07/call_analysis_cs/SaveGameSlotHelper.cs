using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public class SaveGameSlotHelper
{
	private static List<SaveSlotInfo> m_StorySaveSlots;

	private static List<SaveSlotInfo> m_SandboxSlots;

	private static List<SaveSlotInfo> m_ChallengeSaveSlots;

	public static event Action OnSaveGameSlotsUpdated
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "SyncDone")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	public static void ClearSaveSlotsLists()
	{
	}

	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RefreshSaveUI")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallerCount(Count = 1)]
	public static void RefreshSaveSlots(SaveSlotType saveSlotType, bool forceRefresh = false)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	private static void RefreshStorySaveSlots()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	private static void RefreshSandboxSaveSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	private static void RefreshChallengeSaveSlots()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static int GetNumSaveSlots(SaveSlotType saveSlotType)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static bool HasSaveSlots(SaveSlotType saveSlotType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	public static SaveSlotInfo GetCurrentSaveSlotInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[CallsUnknownMethods(Count = 3)]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, string saveName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static void DeleteSaveSlotInfo(SaveSlotInfo ssi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	private static List<SaveSlotInfo> GetSaveSlotInfoList(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void NotifySaveGameSlotsUpdated()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameSlotHelper()
	{
	}
}
