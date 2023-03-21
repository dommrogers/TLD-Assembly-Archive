using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PersistentDataPath
{
	public static string m_PathSeparator;

	public static string m_Path;

	public static string m_PathNoSync;

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "TryCreateDir")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void CreatePersistentDataFolders()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetPersistentDataPath()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetPersistentDataPathForHardDrive()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(PersistentDataPath), Member = "CopyFiles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void MaybeCopyPersistentDataToExperimentalBuild(string sourcePath, string destPath)
	{
	}

	[CalledBy(Type = typeof(PersistentDataPath), Member = "MaybeCopyPersistentDataToExperimentalBuild")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	private static void CopyFiles(string sourcePath, string destPath)
	{
	}

	[CalledBy(Type = typeof(PersistentDataPath), Member = "Init")]
	[CalledBy(Type = typeof(PersistentDataPath), Member = "CreatePersistentDataFolders")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void TryCreateDir(string path)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PersistentDataPath()
	{
	}
}
