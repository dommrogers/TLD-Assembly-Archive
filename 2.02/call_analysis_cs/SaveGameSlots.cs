using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using UnityEngine;

public class SaveGameSlots
{
	public enum Timestamp
	{
		Update,
		Unchanged
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SaveSlotInfo> _003C_003E9__21_0;

		public static Comparison<SaveSlotInfo> _003C_003E9__22_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGetSortedSaveSlotsForEpisodes_003Eb__21_0(SaveSlotInfo x, SaveSlotInfo y)
		{
			return default(int);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGetSortedSaveSlots_003Eb__22_0(SaveSlotInfo x, SaveSlotInfo y)
		{
			return default(int);
		}
	}

	public static string AUTOSAVE_SLOT_NAME;

	public static string SANDBOX_SLOT_PREFIX;

	public static string STORY_SLOT_PREFIX;

	public static string CHALLENGE_SLOT_PREFIX;

	public static string CHECKPOINT_SLOT_PREFIX;

	public static string AUTOSAVE_SLOT_PREFIX;

	public static string QUICKSAVE_SLOT_PREFIX;

	public static int MAX_AUTOSAVES;

	public static int MAX_SAVESLOTS;

	private static SlotData m_AutoSaveSlot;

	private static List<SlotData> m_SaveSlots;

	private static HashSet<string> m_InvalidSlots;

	private static Dictionary<string, string> m_SlotDisplayNames;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Init()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void ReInit()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "LoadAllSlots")]
	public static void LoadAllSavedGameFiles()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode_keep_inventory")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnNewSandbox4DON")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnNewSandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnNewChallenge")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	public static uint GetUnusedGameId()
	{
		return default(uint);
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "CloudFileRequiresSync")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static bool IsValidSavedGameName(string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool SaveExists(SaveSlotType slotType, uint gameId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void GetSlotDataFor(SaveSlotType slotType, ref List<SlotData> slots)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetNewestSaveSlotForActiveGame")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[CallsUnknownMethods(Count = 20)]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnChallenges")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnFourDaysOfNight")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotPrefix")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	public static bool SlotsAreLoading(SaveSlotType slotType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnChallenges")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnFourDaysOfNight")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotPrefix")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public static void SetLoadingPriority(SaveSlotType slotType)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem._003CSaveGameCoroutine_003Ed__95), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	public static bool WriteSlotToDisk(string slotName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearSlotDisplayName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	public static void WriteSlotToDisk(SlotData slot, Timestamp timestampState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static bool HasSaveSlot(string slotname)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static DateTime GetTimestampForSlot(string slotname)
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddInvalidSlotName(string name)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotId")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotTypeFromName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static bool CreateSlotFromData(string dataAsString, string resourceName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	public static void AddSlotData(SlotData sd)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static List<string> GetSlotFilesInCreationOrder(string slotname)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "Init")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReInit")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallsUnknownMethods(Count = 16)]
	public static SlotData CreateSlot(string slotname, SaveSlotType gameMode, uint gameId, Episode episode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReInit")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void ClearAutoSave()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[Calls(Type = typeof(SaveGameSlots), Member = "FindNewestAssociatedSaveSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasCheckpointSave")]
	public static bool DeleteSlot(string slotName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(Utils), Member = "XPModeIsChallenge")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void SendAnalytics()
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private static SlotData FindNewestAssociatedSaveSlot(SlotData source)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static void RebaseMatchingSaves(SlotData source, SlotData target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsUnknownMethods(Count = 4)]
	private static bool HasCheckpointSave(SlotData slot)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	private static void ReassignCheckpointSaves(SlotData source, SlotData target)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[CallsUnknownMethods(Count = 4)]
	public static void DeleteAllSlotsForGameId(uint gameId)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteAllSlotsForGameId")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearSlotDisplayName")]
	private static void DeleteSlot(SlotData slotData)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	public static bool CopyData(string sourceSlotname, string destSlotname, SaveSlotType gameMode = SaveSlotType.UNKNOWN)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static List<string> GetExtraInstancesOfFilename(string slotname, string filename)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(HUDManager), Member = "CheckIfLoadingNewLocation")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSwitchToUninstancedFilename")]
	[CallsUnknownMethods(Count = 1)]
	public static bool HasFilenameInSlot(string slotname, string filename)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void DeleteFileFromSlot(string slotname, string filename)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "PrepareSaveSlotForLoad")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreBootData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetBootData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FillLegacySaveSlotInfo")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "TryFillSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string LoadDataFromSlot(string slotname, string filename)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	public static string LoadDataFromSlotUsingGuid(string slotname, string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveScreenshotDataCoroutine_003Ed__57), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotId")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool SaveDataToSlot(SaveSlotType gameMode, Episode episode, uint saveId, string slotname, string filename, string data)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Break")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static string BuildSlotName(Episode episode, SaveSlotType slotType, uint n)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static SaveSlotType GetSaveSlotTypeFromName(string name)
	{
		return default(SaveSlotType);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static string GetSlotPrefix(SaveSlotType slotType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSetUserDefinedName")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetUserDefinedSlotName(string slotName)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool SetUserDefinedSlotName(string slotName, string displayName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnRenameExistingSandboxConfirmed")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void SaveUserDefinedSlotName(string slotName, string newUserDefinedName)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 3)]
	public static void SetSlotDisplayName(string slotName, string displayName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void ClearSlotDisplayName(string slotName)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CalledBy(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[CallsUnknownMethods(Count = 16)]
	public static void AddGUIDToPrevSceneSave(string slotName, string sceneName, string guid)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static string GetOldestAutosaveName(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CalledBy(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	public static string GetBaseNameForSave(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static void SetBaseNameForSave(string name, string basename)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	public static void SetBaseNameForSave(SlotData dest, SlotData source)
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "ConfigureMenu")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	public static int GetNumSaveSlotsInUse()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 31)]
	public static SlotData GetSaveSlotFromName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static string GetCloudResourceName(string slotname)
	{
		return null;
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "FillLegacySaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveIsCompatible")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "TryFillSaveSlotInfo")]
	public static SaveSlotInfo CreateSaveSlotInfo(SlotData slot)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	private static bool TryFillSaveSlotInfo(string slotName, SaveSlotInfo saveSlotInfo)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private static void FillLegacySaveSlotInfo(string slotName, SaveSlotInfo saveSlotInfo)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "StringAllNullTerminators")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void PrepareSaveSlotForLoad(string slotName, SaveSlotInfo saveSlotInfo)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "StringAllNullTerminators")]
	public static void UpdateSlotGameMode(string slotName, ExperienceModeType currentMode, ExperienceModeType newMode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt32")]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private static uint GetSaveSlotId(string name)
	{
		return default(uint);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SaveGameSlots()
	{
	}
}
