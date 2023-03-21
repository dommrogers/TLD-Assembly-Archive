using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class uConsoleAutoComplete
{
	public static List<uConsoleCommandParameterSet> m_CommandParameterSets;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void CreateCommandParameterSet(string command, List<string> parameters)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void CreateCommandParameterSet(List<string> commands, List<string> parameters)
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static string GetBestCompletion(string partialCommand)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void DisplayPossibleMatches(string command)
	{
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void DisplayStringsStartingWithMatch(string match, List<string> list)
	{
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void DisplayParametersStartingWithMatch(string command, string parameter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static bool CommonCharacterAtIndex(int index, List<string> strings)
	{
		return false;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private static string GetBestMatchFromList(string pattern, List<string> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static string GetBestCommandWithParameterCompletion(string command, string partialParameter)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public uConsoleAutoComplete()
	{
	}
}
