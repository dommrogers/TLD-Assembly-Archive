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

	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static void Init()
	{
	}

	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallerCount(Count = 0)]
	private static void CreatePersistentDataFolders()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	private static string GetPersistentDataPath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	private static string GetPersistentDataPathForHardDrive()
	{
		return null;
	}

	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static string GetBaseFolderPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private static string GetPathModifier()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "CopyFiles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private static void MaybeCopyPersistentDataToExperimentalBuild(string sourcePath, string destPath)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "MaybeCopyPersistentDataToExperimentalBuild")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void CopyFiles(string sourcePath, string destPath)
	{
	}

	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
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
