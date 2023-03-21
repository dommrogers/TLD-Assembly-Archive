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

		[Calls(Type = typeof(int), Member = "TryParse")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Path), Member = "GetExtension")]
		[CallerCount(Count = 2)]
		public VersionedDataInfo(string path)
		{
		}
	}

	private static ValidationStep s_ValidationStep;

	private static List<string> s_ValidationFiles;

	private static int s_ValidationIndex;

	[CalledBy(Type = typeof(SaveGameData), Member = "DoDeleteOperation")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static SaveGameOperationReturnValue DeleteData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadDataFromPath")]
	[Calls(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadOperation")]
	public static SaveGameOperationReturnValue LoadData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	private static bool LoadDataFromPath(string path, out string data)
	{
		data = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadAllOperation")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	public static SaveGameOperationReturnValue LoadAllSaves()
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoSaveOperation")]
	public static SaveGameOperationReturnValue SaveData(string name, string data)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "DoExistsOperation")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
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
	[CallerCount(Count = 0)]
	public static bool IsBusy()
	{
		return default(bool);
	}

	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(FileStream), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	private static bool CompressAndWriteString(string pathAndFilename, string dataAsString)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
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
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public static void InitializeUserProfile()
	{
	}

	[Calls(Type = typeof(File), Member = "Copy")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(VersionedDataInfo), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Path), Member = "ChangeExtension")]
	[Calls(Type = typeof(Path), Member = "GetFileName")]
	[Calls(Type = typeof(Directory), Member = "InternalEnumeratePaths")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateUserInitialization")]
	[CalledBy(Type = typeof(SaveGameData), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Directory), Member = "EnumerateFiles")]
	[Calls(Type = typeof(Directory), Member = "EnumerateFiles")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	public static void ValidateUserProfile()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileBadges")]
	[Calls(Type = typeof(VersionedDataInfo), Member = ".ctor")]
	[Calls(Type = typeof(MigrationHelper), Member = "MigrateProfile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "LoadDataFromPath")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void UpdateProfileAgainstFile(string path, int currentVersion)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateBestTime")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallsUnknownMethods(Count = 4)]
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

	[CallsUnknownMethods(Count = 9)]
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
