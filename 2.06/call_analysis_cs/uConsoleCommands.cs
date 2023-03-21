using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class uConsoleCommands
{
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static void RegisterBuiltInCommands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearLogAndHistory()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	public static void ShowVersion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(uConsole), Member = "ShowHelp")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 5)]
	public static void SearchForCommand()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(uConsole), Member = "ShowHelp")]
	[Calls(Type = typeof(uConsole), Member = "ShowHelp")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public static void ShowHelp()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Quit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleCommands()
	{
	}
}
