using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected.CallAnalysis;

public class uConsoleHistory
{
	private static List<string> m_History;

	private static int m_MaxNumberOfLines;

	private static string m_Filename;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLine(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetNumLines()
	{
		return 0;
	}

	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void Add(string text)
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public static void Save()
	{
	}

	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public static void Restore()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public uConsoleHistory()
	{
	}
}
