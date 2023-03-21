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
		[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Path), Member = "GetExtension")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
		[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public UserDataInfo(string path)
		{
		}
	}

	private const string COMMON_PREFIX = "user";

	private static ValidationStep s_ValidationStep;

	private static List<string> s_ValidationFiles;

	private static int s_ValidationIndex;

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoDeleteOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static SaveGameOperationReturnValue DeleteData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.IO.FileSystemEnumerableFactory", Member = "CreateFileNameIterator")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UserDataInfo), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 33)]
	private static void UpdateTargetFile(string path, string startsWith, string filename, int currentRevision)
	{
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "InitializeUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateTargetFile")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void InitializeUserProfile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsValidationActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static SaveGameOperationReturnValue LoadData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoLoadAllOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(SaveGameSlots), Member = "IsValidSavedGameName")]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public static SaveGameOperationReturnValue LoadAllSaves()
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[CalledBy(Type = typeof(SaveGameData), Member = "DoSaveOperation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "CompressAndWriteString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static SaveGameOperationReturnValue SaveData(string name, string data)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CalledBy(Type = typeof(SaveGameData), Member = "ValidateUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	[Calls(TypeFullName = "System.IO.FileSystemEnumerableFactory", Member = "CreateFileNameIterator")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	public static void ValidateUserProfile()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private static bool CompressAndWriteString(string pathAndFilename, string dataAsString)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DeleteData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "SaveData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetFullPath(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float ValidateTimeWithDefaultValueAsInfinity(float profileValue, float valueToValidateWith)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float ValidateLongestTimeWithDefaultValueAsZero(float profileValue, float valueToValidateWith)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float ValidateShortestTime(float profileValue, float valueToValidateWith)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateTimeWithDefaultValueAsInfinity")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private static void UpdateProfileChallengeData(ProfileState validationState)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 49)]
	private static void UpdateProfileEventData(ProfileState validationState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateProfileFeatData(ProfileState validationState)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UserDataInfo), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToStringNoAlloc")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "TryToFindAndReplaceInvalidNowhereToHideEnumEntry")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileChallengeData")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "UpdateProfileEventData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FeatsManager), Member = "ValidateSaveData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateProfileAgainstFile(string path, int currentVersion)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SaveGameDataPC()
	{
	}
}
