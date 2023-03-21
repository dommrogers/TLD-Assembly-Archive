using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SaveGameData
{
	public static readonly int MAX_COMPRESS_DECOMPRESS_BUFFER_LEN;

	public static readonly int SAVE_OPERATION_TIMEOUT_SECONDS;

	public static byte[] m_CompressDecompressBuffer;

	public static SaveGameOperationData m_CurrentAsyncSaveGameOperation;

	public static List<SaveGameOperationData> m_PendingSaveGameOperations;

	private static string m_LoadingPriorityPattern;

	public static string s_ProfileFilename;

	public static string s_SettingsFilename;

	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DeleteData(string name)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CallerCount(Count = 0)]
	public static void InitializeUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool IsValidationActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	public static void ValidateUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadAllSaves()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	public static void LoadData(string name)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void SaveData(string name, string displayName, string data)
	{
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	public static void SaveGameDataProcess()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	public static bool IsSaving()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsAnyOperationPending()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	public static int GetNumPendingOperations(SaveGameOperationType opType, string pattern)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.WaitSaveOperation._003CWaitSaveOperationComplete_003Ed__3), Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	public static bool AsyncOperationInProgress(SaveGameOperationType opType, string pattern)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetLoadingPriorityPattern(string pattern)
	{
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static SaveGameOperationReturnValue DoSaveOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	private static SaveGameOperationReturnValue DoLoadOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	private static SaveGameOperationReturnValue DoLoadAllOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	private static SaveGameOperationReturnValue DoDeleteOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DeleteData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadAllSaves")]
	private static bool SaveGameOperationAlreadyPending(SaveGameOperationType operationType, string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static SaveGameOperationData GetNextPendingSaveGameOperation()
	{
		return default(SaveGameOperationData);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	private static void CullPendingSaveGameOperations(List<string> m_Whitelist)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static void MaybeDisplayErrorNotification(SaveGameOperationData opData, SaveGameOperationReturnValue returnValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateCurrentAsyncOperationTime()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SaveGameData()
	{
	}
}
