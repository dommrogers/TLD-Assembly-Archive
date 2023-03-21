using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
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

		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
		[Calls(Type = typeof(int), Member = "TryParse")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Path), Member = "GetExtension")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "Substring")]
		public VersionedDataInfo(string path)
		{
		}
	}

	private static ValidationStep s_ValidationStep;

	private static List<string> s_ValidationFiles;

	private static int s_ValidationIndex;

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoDeleteOperation")]
	public static SaveGameOperationReturnValue DeleteData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadOperation")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadDataFromPath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	public static SaveGameOperationReturnValue LoadData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	private static bool LoadDataFromPath(string path, out string data)
	{
		data = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadAllOperation")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[CallsUnknownMethods(Count = 4)]
	public static SaveGameOperationReturnValue LoadAllSaves()
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoSaveOperation")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	public static SaveGameOperationReturnValue SaveData(string name, string data)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoExistsOperation")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static SaveGameOperationReturnValue DataExists(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool IsBusy()
	{
		return default(bool);
	}

	[Calls(Type = typeof(File), Member = "Exists")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(FileStream), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	private static bool CompressAndWriteString(string pathAndFilename, string dataAsString)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsLegacyProfileFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
	[CallerCount(Count = 4)]
	private static string GetFullPath(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CalledBy(Type = typeof(SaveGameData), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	public static void InitializeUserProfile()
	{
	}

	[Calls(Type = typeof(File), Member = "Copy")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VersionedDataInfo), Member = ".ctor")]
	private static bool UpdateTargetFile(string folderPath, string startsWith, string targetFilename, int currentRevision)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsValidationActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Directory), Member = "EnumerateFiles")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateUserInitialization")]
	[CalledBy(Type = typeof(SaveGameData), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Directory), Member = "EnumerateFiles")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	public static void ValidateUserProfile()
	{
	}

	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileBadges")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadDataFromPath")]
	[Calls(Type = typeof(MigrationHelper), Member = "MigrateProfile")]
	[Calls(Type = typeof(VersionedDataInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void UpdateProfileAgainstFile(string path, int currentVersion)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateBestTime")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateProfileChallengeData(ProfileState validationState)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private static void ValidateBestTime(string key, float validationTime)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadge")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	private static void UpdateProfileBadges(ProfileState validationState)
	{
	}

	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void UpdateProfileFeatData(ProfileState validationState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameDataPC()
	{
	}
}
