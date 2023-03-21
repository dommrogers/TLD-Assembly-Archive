using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
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

	private struct UserDataInfo
	{
		public string m_Extension;

		public string m_Path;

		public int m_Revision;

		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
		[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(Path), Member = "GetExtension")]
		public UserDataInfo(string path)
		{
		}
	}

	private const string COMMON_PREFIX = "user";

	private static ValidationStep s_ValidationStep;

	private static List<string> s_ValidationFiles;

	private static int s_ValidationIndex;

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoDeleteOperation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static SaveGameOperationReturnValue DeleteData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(System.IO.FileSystemEnumerableFactory), Member = "CreateFileNameIterator")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UserDataInfo), Member = ".ctor")]
	private static void UpdateTargetFile(string path, string startsWith, string filename, int currentRevision)
	{
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameData), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public static void InitializeUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsValidationActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadOperation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	public static SaveGameOperationReturnValue LoadData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadAllOperation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
	public static SaveGameOperationReturnValue LoadAllSaves()
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoSaveOperation")]
	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static SaveGameOperationReturnValue SaveData(string name, string data)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameData), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(System.IO.FileSystemEnumerableFactory), Member = "CreateFileNameIterator")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	public static void ValidateUserProfile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsBusy()
	{
		return default(bool);
	}

	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(FileStream), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LZF), Member = "lzf_compress")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "Delete")]
	private static bool CompressAndWriteString(string pathAndFilename, string dataAsString)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetFullPath(string name)
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	private static float ValidateTimeWithDefaultValueAsInfinity(float profileValue, float valueToValidateWith)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static float ValidateLongestTimeWithDefaultValueAsZero(float profileValue, float valueToValidateWith)
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static float ValidateShortestTime(float profileValue, float valueToValidateWith)
	{
		return default(float);
	}

	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallsUnknownMethods(Count = 20)]
	private static void UpdateProfileChallengeData(ProfileState validationState)
	{
	}

	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static void UpdateProfileEventData(ProfileState validationState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateProfileFeatData(ProfileState validationState)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileEventData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(UserDataInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "TryToFindAndReplaceInvalidNowhereToHideEnumEntry")]
	private static void UpdateProfileAgainstFile(string path, int currentVersion)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SaveGameDataPC()
	{
	}
}
