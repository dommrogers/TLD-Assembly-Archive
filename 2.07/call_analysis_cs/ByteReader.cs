using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ByteReader
{
	private byte[] mBuffer;

	private int mOffset;

	private static BetterList<string> mTemp;

	public bool canRead
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 279)]
	[DeduplicatedMethod]
	public ByteReader(byte[] bytes)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ByteReader(TextAsset asset)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(File), Member = "OpenRead")]
	[CallsDeduplicatedMethods(Count = 6)]
	public static ByteReader Open(string path)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	public string ReadLine()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadLine")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadDictionary")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadCSV")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadCSV")]
	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Credits.EpisodeDefinition), Member = "BuildLines")]
	[CalledBy(Type = typeof(Panel_Credits.EpisodeDefinition), Member = "BuildLines")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public BetterList<string> ReadCSV(bool ignoreSpaceNewLine = false)
	{
		return null;
	}
}
