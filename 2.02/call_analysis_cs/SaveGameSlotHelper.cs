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
		[CallsDeduplicatedMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	public static void ClearSaveSlotsLists()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Story), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RefreshSaveUI")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	public static void RefreshSaveSlots(SaveSlotType saveSlotType, bool forceRefresh = false)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	private static void RefreshStorySaveSlots()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	private static void RefreshSandboxSaveSlots()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[CallsDeduplicatedMethods(Count = 3)]
	private static void RefreshChallengeSaveSlots()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	public static void RefreshSaveSlotsFourDaysOfNight()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "NameStory")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "AddSavesOfTypeToMenu")]
	public static int GetNumSaveSlots(SaveSlotType saveSlotType)
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickResume")]
	public static bool HasSaveSlots(SaveSlotType saveSlotType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	public static SaveSlotInfo GetCurrentSaveSlotInfo()
	{
		return null;
	}

	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "NameStory")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, string saveName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void DeleteSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	public static void DeleteSaveSlotInfo(SaveSlotInfo ssi)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	private static List<SaveSlotInfo> GetSaveSlotInfoList(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void NotifySaveGameSlotsUpdated()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SaveGameSlotHelper()
	{
	}
}
