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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetMaxNumberOfLines(int count)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	public static string GetLine(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandDown")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
	[CalledBy(Type = typeof(uConsoleInput), Member = "RecallCommandUp")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(uConsole), Member = "OnApplicationQuit")]
	[CallsUnknownMethods(Count = 3)]
	public static void Save()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(uConsole), Member = "Start")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static void Restore()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public uConsoleHistory()
	{
	}
}
