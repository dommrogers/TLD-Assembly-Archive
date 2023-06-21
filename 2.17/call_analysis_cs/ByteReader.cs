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
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 283)]
	public ByteReader(byte[] bytes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ByteReader(TextAsset asset)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "OpenRead")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static ByteReader Open(string path)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ByteReader), Member = "ReadLine")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadDictionary")]
	[CalledBy(Type = typeof(ByteReader), Member = "ReadCSV")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	[CalledBy(TypeFullName = "Panel_Credits.EpisodeDefinition", Member = "BuildLines")]
	[CalledBy(Type = typeof(StringTable), Member = "ImportCsv")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ByteReader), Member = "ReadLine")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(BetterList<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public BetterList<string> ReadCSV(bool ignoreSpaceNewLine = false)
	{
		return null;
	}
}
