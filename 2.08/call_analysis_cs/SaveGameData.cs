using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.News;
using UnityEngine;

public class SaveGameData
{
	public static readonly int MAX_COMPRESS_DECOMPRESS_BUFFER_LEN;

	public static readonly int SAVE_OPERATION_TIMEOUT_SECONDS;

	public static byte[] m_CompressDecompressBuffer;

	public static SaveGameOperationData m_CurrentAsyncSaveGameOperation;

	public static List<SaveGameOperationData> m_PendingSaveGameOperations;

	private static List<string> m_LoadingPriorityPatterns;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeleteData(string name)
	{
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CallerCount(Count = 0)]
	public static void InitializeUserProfile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool ShouldValidateUserProfile()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsValidationActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	public static void ValidateUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadAllSaves()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadUserSettings")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallerCount(Count = 4)]
	public static void LoadData(string name)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSettings")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallerCount(Count = 7)]
	public static void SaveData(string name, string displayName, string data)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "InitializeUser")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadUserProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 5)]
	public static void DataExists(string name)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void SaveGameDataProcess()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__38), Member = "MoveNext")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__38), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 6)]
	public static bool IsSaving()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAnyOperationPending()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(SaveGameData), Member = "IsSaving")]
	public static int GetNumPendingOperations(SaveGameOperationType opType, string pattern)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	public static bool AsyncOperationInProgress(SaveGameOperationType opType, string pattern)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearLoadingPriorityPattern()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	public static void AddLoadingPriorityPattern(string pattern)
	{
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 4)]
	private static bool DoesNameMatchPattern(string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CallerCount(Count = 0)]
	private static SaveGameOperationReturnValue DoSaveOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	private static SaveGameOperationReturnValue DoLoadOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	private static SaveGameOperationReturnValue DoLoadAllOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	private static SaveGameOperationReturnValue DoDeleteOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	private static SaveGameOperationReturnValue DoExistsOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DeleteData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadAllSaves")]
	private static bool SaveGameOperationAlreadyPending(SaveGameOperationType operationType, string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SaveGameData), Member = "DoesNameMatchPattern")]
	[CallerCount(Count = 1)]
	private static SaveGameOperationData GetNextPendingSaveGameOperation()
	{
		return default(SaveGameOperationData);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private static void CullPendingSaveGameOperations(List<string> m_Whitelist)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
	private static void MaybeDisplayErrorNotification(SaveGameOperationData opData, SaveGameOperationReturnValue returnValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateCurrentAsyncOperationTime()
	{
	}

	[CallerCount(Count = 0)]
	public static void MarkCurrentAsyncOperationFinished()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public SaveGameData()
	{
	}
}
