using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

public class uConsoleHistory
{
	private static List<string> m_History;

	private static int m_MaxNumberOfLines;

	private static string m_Filename;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Clear()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	public static string GetLine(int index)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallsUnknownMethods(Count = 1)]
	public static int GetNumLines()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(uConsole), Member = "RunCommand")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void Add(string text)
	{
	}

	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	public static void Save()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Restore()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public uConsoleHistory()
	{
	}
}
