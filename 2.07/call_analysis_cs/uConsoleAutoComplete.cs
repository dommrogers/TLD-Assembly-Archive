using System;
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	public static void CreateCommandParameterSet(List<string> commands, List<string> parameters)
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 1)]
	public static string GetBestCompletion(string partialCommand)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisplayPossibleMatches(string command)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	public static void DisplayStringsStartingWithMatch(string match, List<string> list)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	private static void DisplayParametersStartingWithMatch(string command, string parameter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private static bool CommonCharacterAtIndex(int index, List<string> strings)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CallsUnknownMethods(Count = 5)]
	private static string GetBestMatchFromList(string pattern, List<string> list)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
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
