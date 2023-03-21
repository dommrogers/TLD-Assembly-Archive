using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class uConsoleCommandFile
{
	private static bool m_ProcessedMainConfigFile;

	private static string[] m_PendingScriptCommands;

	private static float m_ApplyScriptCommandsTime;

	private static int m_ScriptCommandIndex;

	private static string s_LastPathConfigFile;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void DoFrame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public static void RegisterPendingCommands(string[] commandLines)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private static void ReadConfigFile(string filename)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private static void ProcessScriptCommands()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public uConsoleCommandFile()
	{
	}
}
