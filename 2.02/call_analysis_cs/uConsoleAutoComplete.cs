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

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "Initialize")]
	public static void CreateCommandParameterSet(List<string> commands, List<string> parameters)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 6)]
	public static string GetBestCompletion(string partialCommand)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "AutoComplete")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	public static void DisplayPossibleMatches(string command)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayParametersStartingWithMatch")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "Log")]
	public static void DisplayStringsStartingWithMatch(string match, List<string> list)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "DisplayPossibleMatches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "DisplayStringsStartingWithMatch")]
	private static void DisplayParametersStartingWithMatch(string command, string parameter)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 0)]
	private static bool CommonCharacterAtIndex(int index, List<string> strings)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCommandWithParameterCompletion")]
	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static string GetBestMatchFromList(string pattern, List<string> list)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleAutoComplete), Member = "GetBestCompletion")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsoleAutoComplete), Member = "GetBestMatchFromList")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	private static string GetBestCommandWithParameterCompletion(string command, string partialParameter)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public uConsoleAutoComplete()
	{
	}
}
