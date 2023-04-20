using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Encryption;
using TLD.SaveState;
using UnityEngine;

public class SaveGameDataPC
{
	private enum ValidationStep
	{
		Prepare,
		Validate,
		Cleanup,
		Done
	}

	private struct VersionedDataInfo
	{
		public string m_Extension;

		public string m_Path;

		public int m_Revision;

		[CalledBy(Type = typeof(SaveGameDataPC), Member = "FindCandidate")]
		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Path), Member = "GetExtension")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(int), Member = "TryParse")]
		[CallsUnknownMethods(Count = 1)]
		public VersionedDataInfo(string path)
		{
		}
	}

	private static ValidationStep s_ValidationStep;

	private static List<string> s_ValidationFiles;

	private static int s_ValidationIndex;

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoDeleteOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	public static SaveGameOperationReturnValue DeleteData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadDataFromPath")]
	[Calls(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	public static SaveGameOperationReturnValue LoadData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	private static bool LoadDataFromPath(string path, out string data)
	{
		data = null;
		return false;
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadAllOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static SaveGameOperationReturnValue LoadAllSaves()
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoSaveOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	public static SaveGameOperationReturnValue SaveData(string name, string data)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoExistsOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	public static SaveGameOperationReturnValue DataExists(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool IsBusy()
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(FileStream), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private static bool CompressAndWriteString(string pathAndFilename, string dataAsString)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsLegacySettingsFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsLegacyProfileFilename")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	private static string GetFullPath(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "FindTargetFilePath")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(string), Member = "LastIndexOfAny")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void InitializeUserProfile()
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "FindCandidate")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "Copy")]
	private static bool UpdateTargetFile(string folderPath, string startsWith, string targetFilename, int currentRevision)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "FindCandidate")]
	private static bool FindTargetFilePath(string folderPath, string startsWith, int currentRevision, out string targetFilePath)
	{
		targetFilePath = null;
		return false;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "FindTargetFilePath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(VersionedDataInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static VersionedDataInfo? FindCandidate(string folderPath, string startsWith, int currentRevision)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsValidationActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "ValidateUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateUserInitialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Directory), Member = "EnumerateFiles")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void ValidateUserProfile()
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VersionedDataInfo), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadDataFromPath")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(MigrationHelper), Member = "MigrateProfile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileBadges")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateProfileAgainstFile(string path, int currentVersion)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateBestTime")]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateProfileChallengeData(ProfileState validationState)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void ValidateBestTime(string key, float validationTime)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 8)]
	private static void UpdateProfileBadges(ProfileState validationState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateProfileFeatData(ProfileState validationState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameDataPC()
	{
	}
}
