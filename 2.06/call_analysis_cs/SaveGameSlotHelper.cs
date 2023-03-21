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
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	private static void RefreshStorySaveSlots()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	private static void RefreshSandboxSaveSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(SaveSlotInfo), Member = "IsLoadable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CallerCount(Count = 2)]
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

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 0)]
	public static SaveSlotInfo GetCurrentSaveSlotInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSelectionUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSelectedSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallsUnknownMethods(Count = 2)]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, string saveName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static void DeleteSaveSlotInfo(SaveSlotInfo ssi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
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
