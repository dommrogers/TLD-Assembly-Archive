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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void ClearSaveSlotsLists()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "Enable")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "RefreshSaveUI")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void RefreshSaveSlots(SaveSlotType saveSlotType, bool forceRefresh = false)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static void RefreshStorySaveSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void RefreshSandboxSaveSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void RefreshChallengeSaveSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void RefreshSaveSlotsFourDaysOfNight()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "NameStory")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetNumSaveSlots(SaveSlotType saveSlotType)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickResume")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool HasSaveSlots(SaveSlotType saveSlotType)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SaveSlotInfo GetCurrentSaveSlotInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "NameStory")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickResume")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, string saveName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void DeleteSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "DeleteSaveSlot")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "DeleteSaveSlot")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfoList")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void DeleteSaveSlotInfo(SaveSlotInfo ssi)
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetNumSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "HasSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 7)]
	public SaveGameSlotHelper()
	{
	}
}
