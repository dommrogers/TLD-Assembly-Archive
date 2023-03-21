using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PersistentDataPath
{
	private const string SURVIVAL_PATH = "Survival";

	private const string NOSYNC_ADD = "NoSync";

	public static string m_PathSeparator;

	public static string m_Path;

	public static string m_PathNoSync;

	public static string m_LegacyPath;

	public static string m_LegacyPathNoSync;

	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	public static void Init()
	{
	}

	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	private static void CreatePersistentDataFolders()
	{
	}

	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetPersistentDataPath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	private static string GetPersistentDataPathForHardDrive()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	public static string GetBaseFolderPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private static string GetPathModifier()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	private static void MaybeCopyPersistentDataToExperimentalBuild(string sourcePath, string destPath)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	private static void CopyFiles(string sourcePath, string destPath)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void TryCreateDir(string path)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PersistentDataPath()
	{
	}
}
