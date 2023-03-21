using Cpp2ILInjected.CallAnalysis;

public class uConsoleCommandFile
{
	private static bool m_ProcessedMainConfigFile;

	private static string[] m_PendingScriptCommands;

	private static float m_ApplyScriptCommandsTime;

	private static int m_ScriptCommandIndex;

	private static string s_LastPathConfigFile;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void DoFrame()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterPendingCommands(string[] commandLines)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void ReadConfigFile(string filename)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void ProcessScriptCommands()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public uConsoleCommandFile()
	{
	}
}
