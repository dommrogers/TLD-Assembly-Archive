using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class uConsoleLog
{
	private static List<string> m_Log;

	private static string m_Filename;

	private static int m_MaxNumberOfLines;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Clear()
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "Log")]
	[CalledBy(Type = typeof(uConsole), Member = "ShowHelp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "SearchForCommand")]
	[CalledBy(Type = typeof(uConsoleLog), Member = "HandleLogMessagesFromUnity")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowVersion")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoStrings")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoString")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoBool")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoFloat")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoInteger")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoNothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoStrings")]
	public static void Add(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	public static int GetNumLines()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLine(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Save()
	{
	}

	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Restore()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public static void HandleLogMessagesFromUnity(string logString, string stackTrace, LogType type)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public uConsoleLog()
	{
	}
}
