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

	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void DeleteData(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
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

	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadAllSaves()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadUserSettings")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	public static void LoadData(string name)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSettings")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void SaveData(string name, string displayName, string data)
	{
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "InitializeUser")]
	[CallsUnknownMethods(Count = 2)]
	public static void DataExists(string name)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	public static void SaveGameDataProcess()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__38), Member = "MoveNext")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__38), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static int GetNumPendingOperations(SaveGameOperationType opType, string pattern)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
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
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	public static void AddLoadingPriorityPattern(string pattern)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[CallsUnknownMethods(Count = 3)]
	private static bool DoesNameMatchPattern(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	private static SaveGameOperationReturnValue DoSaveOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DeleteData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadAllSaves")]
	private static bool SaveGameOperationAlreadyPending(SaveGameOperationType operationType, string name)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "DoesNameMatchPattern")]
	private static SaveGameOperationData GetNextPendingSaveGameOperation()
	{
		return default(SaveGameOperationData);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static void CullPendingSaveGameOperations(List<string> m_Whitelist)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameData()
	{
	}
}
