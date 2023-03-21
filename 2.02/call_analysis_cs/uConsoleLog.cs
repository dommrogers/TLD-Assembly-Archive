using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class uConsoleLog
{
	private static List<string> m_Log;

	private static string m_Filename;

	private static int m_MaxNumberOfLines;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Clear()
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "Log")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(uConsoleLog), Member = "HandleLogMessagesFromUnity")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "SearchForCommand")]
	[CalledBy(Type = typeof(uConsoleCommands), Member = "ShowVersion")]
	[CalledBy(Type = typeof(uConsole), Member = "ShowHelp")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	public static void Add(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[CalledBy(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "ProcessLogInput")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "ScrollLogUp")]
	public static int GetNumLines()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(uConsoleGUI), Member = "RefreshLogText")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLine(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	public static void Save()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	public static void Restore()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static void HandleLogMessagesFromUnity(string logString, string stackTrace, LogType type)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public uConsoleLog()
	{
	}
}
