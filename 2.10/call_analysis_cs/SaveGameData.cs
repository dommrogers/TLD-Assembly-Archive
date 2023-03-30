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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	public static void InitializeUserProfile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool ShouldValidateUserProfile()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsValidationActive()
	{
		return false;
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

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadData(string name)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSettings")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameOperationAlreadyPending")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 2)]
	public static void SaveData(string name, string displayName, string data)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadUserSettings")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "InitializeUser")]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static void DataExists(string name)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadAllSaves")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[Calls(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void SaveGameDataProcess()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[CalledBy(TypeFullName = "JumpManager.<OnSavingCoroutine>d__38", Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	public static bool IsSaving()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAnyOperationPending()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CalledBy(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.WaitSaveOperation.<WaitSaveOperationComplete>d__3", Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateCarousel")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetNumPendingOperations(SaveGameOperationType opType, string pattern)
	{
		return 0;
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "IsSaveSystemInitialized")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.WaitSaveOperation.<WaitSaveOperationComplete>d__3", Member = "MoveNext")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "IsSaveOperationInProgress")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	public static bool AsyncOperationInProgress(SaveGameOperationType opType, string pattern)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearLoadingPriorityPattern()
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void AddLoadingPriorityPattern(string pattern)
	{
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "GetNextPendingSaveGameOperation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 3)]
	private static bool DoesNameMatchPattern(string name)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "SaveData")]
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

	[CalledBy(Type = typeof(SaveGameData), Member = "DeleteData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadAllSaves")]
	[CalledBy(Type = typeof(SaveGameData), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 6)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static bool SaveGameOperationAlreadyPending(SaveGameOperationType operationType, string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "DoesNameMatchPattern")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static SaveGameOperationData GetNextPendingSaveGameOperation()
	{
		return default(SaveGameOperationData);
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private static void CullPendingSaveGameOperations(List<string> m_Whitelist)
	{
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 1)]
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
