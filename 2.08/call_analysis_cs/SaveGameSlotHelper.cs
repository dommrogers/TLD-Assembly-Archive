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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "SyncDone")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 5)]
	public static void ClearSaveSlotsLists()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RefreshSaveUI")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallerCount(Count = 1)]
	public static void RefreshSaveSlots(SaveSlotType saveSlotType, bool forceRefresh = false)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	private static void RefreshStorySaveSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	private static void RefreshSandboxSaveSlots()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CallsUnknownMethods(Count = 6)]
	private static void RefreshChallengeSaveSlots()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static int GetNumSaveSlots(SaveSlotType saveSlotType)
	{
		return default(int);
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, string saveName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static void DeleteSaveSlotInfo(SaveSlotInfo ssi)
	{
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	private static List<SaveSlotInfo> GetSaveSlotInfoList(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void NotifySaveGameSlotsUpdated()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SaveGameSlotHelper()
	{
	}
}
