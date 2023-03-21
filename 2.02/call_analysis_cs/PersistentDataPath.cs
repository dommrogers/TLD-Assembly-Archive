using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PersistentDataPath
{
	public static string m_PathSeparator;

	public static string m_Path;

	public static string m_PathNoSync;

	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	private static void CreatePersistentDataFolders()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static string GetPersistentDataPath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetPersistentDataPathForHardDrive()
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentDataPath), Member = "CopyFiles")]
	private static void MaybeCopyPersistentDataToExperimentalBuild(string sourcePath, string destPath)
	{
	}

	[CalledBy(Type = typeof(PersistentDataPath), Member = "MaybeCopyPersistentDataToExperimentalBuild")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	private static void CopyFiles(string sourcePath, string destPath)
	{
	}

	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void TryCreateDir(string path)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PersistentDataPath()
	{
	}
}
