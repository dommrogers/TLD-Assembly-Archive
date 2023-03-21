using Cpp2ILInjected.CallAnalysis;

public class uConsoleCommandFile
{
	private static bool m_ProcessedMainConfigFile;

	private static string[] m_PendingScriptCommands;

	private static float m_ApplyScriptCommandsTime;

	private static int m_ScriptCommandIndex;

	private static string s_LastPathConfigFile;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void DoFrame()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public static void RegisterPendingCommands(string[] commandLines)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private static void ReadConfigFile(string filename)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private static void ProcessScriptCommands()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public uConsoleCommandFile()
	{
	}
}
