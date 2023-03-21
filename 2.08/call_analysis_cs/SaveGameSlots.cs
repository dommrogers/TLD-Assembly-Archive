using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using TLD.Encryption;
using TLD.SaveState;
using TLD.Serialization;
using UnityEngine;

public class SaveGameSlots
{
	public enum Timestamp
	{
		Update,
		Unchanged
	}

	private class SaveSlotTypeEqualityComparer : IEqualityComparer<SaveSlotType>
	{
		public static readonly SaveSlotTypeEqualityComparer Comparer;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		private SaveSlotTypeEqualityComparer()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(SaveSlotType x, SaveSlotType y)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public int GetHashCode(SaveSlotType saveSlotType)
		{
			return default(int);
		}
	}

	private class SaveSlotCounter
	{
		private const string TOTAL = "total";

		private readonly Dictionary<string, int> m_Counts;

		private readonly Dictionary<string, object> m_Events;

		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public void Reset()
		{
		}

		[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		public void AddSlot(string name)
		{
		}

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
		[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
		[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
		[CallsUnknownMethods(Count = 3)]
		public Dictionary<string, object> FinalizeEventData()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SaveGameSlots), Member = ".cctor")]
		[CalledBy(Type = typeof(SaveGameSlots), Member = ".cctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(SaveGameSlots), Member = ".cctor")]
		public SaveSlotCounter()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SaveSlotInfo> _003C_003E9__22_0;

		public static Comparison<SaveSlotInfo> _003C_003E9__23_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGetSortedSaveSlotsForEpisodes_003Eb__22_0(SaveSlotInfo x, SaveSlotInfo y)
		{
			return default(int);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(DateTime), Member = "CompareTo")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal int _003CGetSortedSaveSlots_003Eb__23_0(SaveSlotInfo x, SaveSlotInfo y)
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

	private static readonly Dictionary<SaveSlotType, SaveSlotCounter> s_SaveSlotCounters;

	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Init()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "SyncDone")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ReInit()
	{
	}

	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "SyncDone")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateUserInitialization")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "LoadAllSlots")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	public static void LoadAllSavedGameFiles()
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnNewSandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnNewChallenge")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallsUnknownMethods(Count = 4)]
	public static uint GetUnusedGameId()
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "CloudFileRequiresSync")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 2)]
	public static bool IsValidSavedGameName(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallsUnknownMethods(Count = 4)]
	public static bool SaveExists(SaveSlotType slotType, uint gameId)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public static void GetSlotDataFor(SaveSlotType slotType, ref List<SlotData> slots)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetNewestSaveSlotForActiveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateSaveFiles")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "LoadSelectedSave")]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickChallenges")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotPrefix")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	public static bool SlotsAreLoading(SaveSlotType slotType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickChallenges")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotPrefix")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameData), Member = "AddLoadingPriorityPattern")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLoadingPriority(SaveSlotType slotType)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveGameCoroutine_003Ed__53), Member = "MoveNext")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static bool WriteSlotToDisk(string slotName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearSlotDisplayName")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	public static void WriteSlotToDisk(SlotData slot, Timestamp timestampState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static bool HasSaveSlot(string slotname)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static DateTime GetTimestampForSlot(string slotname)
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddInvalidSlotName(string name)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotId")]
	public static bool CreateSlotFromData(string dataAsString, string filename)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public static void AddSlotData(SlotData sd)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReInit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "Init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(BaseState), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static SlotData CreateSlot(string slotname, SaveSlotType gameMode, uint gameId, Episode episode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReInit")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static void ClearAutoSave()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasCheckpointSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[Calls(Type = typeof(SaveGameSlots), Member = "FindNewestAssociatedSaveSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	public static bool DeleteSlot(string slotName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(SaveSlotCounter), Member = "FinalizeEventData")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(SaveSlotCounter), Member = "FinalizeEventData")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(SaveSlotCounter), Member = "FinalizeEventData")]
	[Calls(Type = typeof(SaveSlotCounter), Member = "AddSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	public static void SendAnalytics()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	private static SlotData FindNewestAssociatedSaveSlot(SlotData source)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsUnknownMethods(Count = 5)]
	private static void RebaseMatchingSaves(SlotData source, SlotData target)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	private static bool HasCheckpointSave(SlotData slot)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsUnknownMethods(Count = 5)]
	private static void ReassignCheckpointSaves(SlotData source, SlotData target)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	public static void DeleteAllSlotsForGameId(uint gameId)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearSlotDisplayName")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteAllSlotsForGameId")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[CallsUnknownMethods(Count = 3)]
	private static void DeleteSlot(SlotData slotData)
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool CopyData(string sourceSlotname, string destSlotname, SaveSlotType gameMode = SaveSlotType.UNKNOWN)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static List<string> GetExtraInstancesOfFilename(string slotname, string filename)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSwitchToUninstancedFilename")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__27), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HUDManager), Member = "CheckIfLoadingNewLocation")]
	public static bool HasFilenameInSlot(string slotname, string filename)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeleteFileFromSlot(string slotname, string filename)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static bool TryLoadDataFromSlot<T>(string slotname, string filename, out T data)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref data) = null;
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool TryLoadDataFromSlotUsingGuid<T>(string slotname, string guid, out T data)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref data) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotId")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	public static bool FindOrCreateSlotData(string slotname, SaveSlotType gameMode, Episode episode, uint saveId, out SlotData slot)
	{
		slot = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem._003CSaveScreenshotDataCoroutine_003Ed__115), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	public static bool SaveDataToSlot(SlotData slot, string key, object data)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Break")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string BuildSlotName(Episode episode, SaveSlotType slotType, uint n)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains")]
	public static SaveSlotType GetSaveSlotTypeFromName(string name)
	{
		return default(SaveSlotType);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static string GetSlotPrefix(SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSetUserDefinedName")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetUserDefinedSlotName(string slotName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	public static bool SetUserDefinedSlotName(string slotName, string displayName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void SaveUserDefinedSlotName(string slotName, string newUserDefinedName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxComplete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	public static void SetSlotDisplayName(string slotName, string displayName)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallsUnknownMethods(Count = 2)]
	public static void ClearSlotDisplayName(string slotName)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[Calls(Type = typeof(BaseState), Member = "HasData")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseState), Member = "HasData")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static void AddGUIDToPrevSceneSave(string slotName, string sceneName, string guid)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string GetOldestAutosaveName(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	public static string GetBaseNameForSave(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	public static void SetBaseNameForSave(string name, string basename)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetBaseNameForSave(SlotData dest, SlotData source)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	public static int GetNumSaveSlotsInUse()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static SlotData GetSaveSlotFromName(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static string GetCloudResourceName(string slotname)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "FillSaveSlotInfo")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	public static SaveSlotInfo CreateSaveSlotInfo(SlotData slot)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGameModeFromName")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallsUnknownMethods(Count = 1)]
	private static bool FillSaveSlotInfo(SlotData slot, SaveSlotInfo saveSlotInfo)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	public static void PrepareSaveSlotForLoad(string slotName, SaveSlotInfo saveSlotInfo)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "StringToExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void UpdateSlotGameMode(string slotName, ExperienceModeType currentMode, ExperienceModeType newMode)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt32")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private static uint GetSaveSlotId(string name)
	{
		return default(uint);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameSlots()
	{
	}
}
