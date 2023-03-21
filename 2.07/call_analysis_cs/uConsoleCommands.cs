using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class uConsoleCommands
{
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	public static void ShowVersion()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(uConsole), Member = "ShowHelp")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static void SearchForCommand()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "ShowHelp")]
	[Calls(Type = typeof(uConsole), Member = "ShowHelp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 13)]
	public static void ShowHelp()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static void Quit()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleCommands()
	{
	}
}
