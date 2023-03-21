using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;

public class uConsoleHistory
{
	private static List<string> m_History;

	private static int m_MaxNumberOfLines;

	private static string m_Filename;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLine(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public static int GetNumLines()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 5)]
	public static void Add(string text)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	public static void Save()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[CallsUnknownMethods(Count = 9)]
	public static void Restore()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public uConsoleHistory()
	{
	}
}
