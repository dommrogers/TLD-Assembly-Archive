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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Clear()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsoleLog), Member = "HandleLogMessagesFromUnity")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "SearchForCommand")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowVersion")]
	[CalledBy(Type = typeof(uConsole), Member = "ShowHelp")]
	[CalledBy(Type = typeof(uConsole), Member = "Log")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoStrings")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoStrings")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoBool")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoFloat")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoInteger")]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoNothing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(ExampleCommands), Member = "EchoString")]
	public static void Add(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Save()
	{
	}

	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Restore()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public static void HandleLogMessagesFromUnity(string logString, string stackTrace, LogType type)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleLog()
	{
	}
}
