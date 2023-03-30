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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CreateCommandParameterSet(List<string> commands, List<string> parameters)
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetBestCompletion(string partialCommand)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisplayPossibleMatches(string command)
	{
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisplayStringsStartingWithMatch(string match, List<string> list)
	{
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private static void DisplayParametersStartingWithMatch(string command, string parameter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private static bool CommonCharacterAtIndex(int index, List<string> strings)
	{
		return false;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static string GetBestMatchFromList(string pattern, List<string> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private static string GetBestCommandWithParameterCompletion(string command, string partialParameter)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleAutoComplete()
	{
	}
}
