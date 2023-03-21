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

	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	public static void CreateCommandParameterSet(List<string> commands, List<string> parameters)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetBestCompletion(string partialCommand)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallerCount(Count = 0)]
	public static void DisplayPossibleMatches(string command)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 2)]
	public static void DisplayStringsStartingWithMatch(string match, List<string> list)
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static void DisplayParametersStartingWithMatch(string command, string parameter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static bool CommonCharacterAtIndex(int index, List<string> strings)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	private static string GetBestMatchFromList(string pattern, List<string> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
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
