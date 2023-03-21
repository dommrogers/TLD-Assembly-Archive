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

	[DeduplicatedMethod]
	[CallerCount(Count = 101)]
	public ByteReader(byte[] bytes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ByteReader(TextAsset asset)
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(File), Member = "OpenRead")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public static ByteReader Open(string path)
	{
		return null;
	}

	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return null;
	}

	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[CallerCount(Count = 0)]
	public string ReadLine()
	{
		return null;
	}

	[CalledBy(Type = typeof(ByteReader), Member = "ReadCSV")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadDictionary")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadLine")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadCSV")]
	[CallsUnknownMethods(Count = 8)]
	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CalledBy(Type = typeof(Panel_Credits.EpisodeDefinition), Member = "BuildLines")]
	[CalledBy(Type = typeof(Panel_Credits.EpisodeDefinition), Member = "BuildLines")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[Calls(Type = typeof(string), Member = "Replace")]
	public BetterList<string> ReadCSV(bool ignoreSpaceNewLine = false)
	{
		return null;
	}
}
