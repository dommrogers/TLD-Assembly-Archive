using System;
using System.Collections.Generic;
using System.Globalization;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private SaveSlotTypeEqualityComparer()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Equals(SaveSlotType x, SaveSlotType y)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public int GetHashCode(SaveSlotType saveSlotType)
		{
			return 0;
		}
	}

	private class SaveSlotCounter
	{
		private const string TOTAL = "total";

		private readonly Dictionary<string, int> m_Counts;

		private readonly Dictionary<string, object> m_Events;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
		}

		[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public void AddSlot(string name)
		{
		}

		[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public Dictionary<string, object> FinalizeEventData()
		{
			return null;
		}

		[CalledBy(Type = typeof(SaveGameSlots), Member = ".cctor")]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 11)]
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
			return 0;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "CompareTo")]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CGetSortedSaveSlots_003Eb__23_0(SaveSlotInfo x, SaveSlotInfo y)
		{
			return 0;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[CallsUnknownMethods(Count = 1)]
	public static void Init()
	{
	}

	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ReInit()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "LoadAllSlots")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateUserInitialization")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadSaveFromCommandLine")]
	[CalledBy(Type = typeof(EmptyScene), Member = "StartNewGameFromCommandLine")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "ReloadSaves")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadAllSavedGameFiles()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnNewChallenge")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnNewSandbox")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public static uint GetUnusedGameId()
	{
		return 0u;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "CloudFileRequiresSync")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static bool IsValidSavedGameName(string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public static bool SaveExists(SaveSlotType slotType, uint gameId)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void GetSlotDataFor(SaveSlotType slotType, ref List<SlotData> slots)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlotsForEpisodes")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetNewestSaveSlotForActiveGame")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "PopulateSaveFiles")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "LoadSelectedSave")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickChallenges")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotPrefix")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	public static bool SlotsAreLoading(SaveSlotType slotType)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickChallenges")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSlotPrefix")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SaveGameData), Member = "AddLoadingPriorityPattern")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLoadingPriority(SaveSlotType slotType)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveUserDefinedSlotName")]
	[CalledBy(TypeFullName = "SaveGameSystem.<SaveGameCoroutine>d__53", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static bool WriteSlotToDisk(string slotName)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearSlotDisplayName")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void WriteSlotToDisk(SlotData slot, Timestamp timestampState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static bool HasSaveSlot(string slotname)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotId")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool CreateSlotFromData(string dataAsString, string filename)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void AddSlotData(SlotData sd)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "Init")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReInit")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SlotData), Member = ".ctor")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 6)]
	public static SlotData CreateSlot(string slotname, SaveSlotType gameMode, uint gameId, Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReInit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearAutoSave()
	{
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "FindNewestAssociatedSaveSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasCheckpointSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static bool DeleteSlot(string slotName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(SaveSlotCounter), Member = "AddSlot")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SaveSlotCounter), Member = "FinalizeEventData")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	public static void SendAnalytics()
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 7)]
	private static SlotData FindNewestAssociatedSaveSlot(SlotData source)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CallsUnknownMethods(Count = 5)]
	private static void RebaseMatchingSaves(SlotData source, SlotData target)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 4)]
	private static bool HasCheckpointSave(SlotData slot)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CallsUnknownMethods(Count = 4)]
	private static void ReassignCheckpointSaves(SlotData source, SlotData target)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeleteAllSlotsForGameId(uint gameId)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteAllSlotsForGameId")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearSlotDisplayName")]
	[CallsUnknownMethods(Count = 3)]
	private static void DeleteSlot(SlotData slotData)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	public static bool CopyData(string sourceSlotname, string destSlotname, SaveSlotType gameMode = SaveSlotType.UNKNOWN)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public static List<string> GetExtraInstancesOfFilename(string slotname, string filename)
	{
		return null;
	}

	[CalledBy(TypeFullName = "HUDManager.<WaitToShowLocationReveal>d__22", Member = "MoveNext")]
	[CalledBy(Type = typeof(HUDManager), Member = "CheckIfLoadingNewLocation")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSwitchToUninstancedFilename")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(BaseState), Member = "HasData")]
	public static bool HasFilenameInSlot(string slotname, string filename)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void DeleteFileFromSlot(string slotname, string filename)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryLoadDataFromSlot<T>(string slotname, string filename, out T data)
	{
		data = default(T);
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(InaccessibleGearContainer), Member = "LoadSceneIntoNearestContainer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static bool TryLoadDataFromSlotUsingGuid<T>(string slotname, string guid, out T data)
	{
		data = default(T);
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotId")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool FindOrCreateSlotData(string slotname, SaveSlotType gameMode, Episode episode, uint saveId, out SlotData slot)
	{
		slot = null;
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(TypeFullName = "SaveGameSystem.<SaveScreenshotDataCoroutine>d__115", Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static bool SaveDataToSlot(SlotData slot, string key, object data)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Break")]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[Calls(TypeFullName = "System.Number", Member = "FormatUInt32")]
	[CallsUnknownMethods(Count = 2)]
	public static string BuildSlotName(Episode episode, SaveSlotType slotType, uint n)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static SaveSlotType GetSaveSlotTypeFromName(string name)
	{
		return default(SaveSlotType);
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static string GetSlotPrefix(SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSetUserDefinedName")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetUserDefinedSlotName(string slotName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static bool SetUserDefinedSlotName(string slotName, string displayName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnRenameExistingChallengeConfirmed")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnRenameExistingSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnRenameExistingStoryConfirmed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void SaveUserDefinedSlotName(string slotName, string newUserDefinedName)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxComplete")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetSlotDisplayName(string slotName, string displayName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearSlotDisplayName(string slotName)
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "MaybeAddGUIDToPrevSceneSave")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseState), Member = "HasData")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SlotData), Member = "Lock")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void AddGUIDToPrevSceneSave(string slotName, string sceneName, string guid)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 12)]
	public static string GetOldestAutosaveName(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshStorySaveSlots")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	public static string GetBaseNameForSave(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 5)]
	public static void SetBaseNameForSave(string name, string basename)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "RebaseMatchingSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "ReassignCheckpointSaves")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetBaseNameForSave(SlotData dest, SlotData source)
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "ConfigureMenu")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetNumSaveSlotsInUse()
	{
		return 0;
	}

	[CallerCount(Count = 43)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BaseState), Member = "TryGetData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "FillSaveSlotInfo")]
	[Calls(Type = typeof(EpisodeManager), Member = "NextEpisodeIsUnlocked")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[CallsUnknownMethods(Count = 6)]
	public static SaveSlotInfo CreateSaveSlotInfo(SlotData slot)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetGameModeFromName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FillSaveSlotInfo(string slotName, SaveSlotInfo saveSlotInfo)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void PrepareSaveSlotForLoad(string slotName, SaveSlotInfo saveSlotInfo)
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "PostEventConvertSaveSlot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(BaseState), Member = "TryGetData")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(ExperienceModeManagerSaveDataProxy), Member = "StringToExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateSlotGameMode(string slotName, ExperienceModeType currentMode, ExperienceModeType newMode)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Regex), Member = "Replace")]
	[Calls(Type = typeof(uint), Member = "TryParse")]
	[CallsUnknownMethods(Count = 1)]
	private static uint GetSaveSlotId(string name)
	{
		return 0u;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameSlots()
	{
	}
}
