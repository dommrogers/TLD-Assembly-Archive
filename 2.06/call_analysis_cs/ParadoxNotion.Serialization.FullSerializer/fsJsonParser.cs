using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public class fsJsonParser
{
	private int _start;

	private string _input;

	private readonly StringBuilder _cachedStringBuilder;

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	private fsResult MakeFailure(string message)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool TryMoveNext()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasValue()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasValue(int offset)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private char Character()
	{
		return default(char);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	private char Character(int offset)
	{
		return default(char);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CallerCount(Count = 10)]
	private void SkipSpace()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsHex(char c)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private uint ParseSingleChar(char c1, uint multipliyer)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		return default(uint);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[CallsUnknownMethods(Count = 9)]
	private fsResult TryUnescapeChar(out char escaped)
	{
		System.Runtime.CompilerServices.Unsafe.As<char, @null>(ref escaped) = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	private fsResult TryParseExact(string content)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallsUnknownMethods(Count = 6)]
	private fsResult TryParseTrue(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	private fsResult TryParseFalse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CallsUnknownMethods(Count = 6)]
	private fsResult TryParseNull(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool IsSeparator(char c)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	private fsResult TryParseNumber(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private fsResult TryParseString(out string str)
	{
		str = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	private fsResult TryParseArray(out fsData arr)
	{
		arr = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	private fsResult TryParseObject(out fsData obj)
	{
		obj = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private fsResult RunParse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	public static fsResult Parse(string input, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	public static fsData Parse(string input)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallsUnknownMethods(Count = 6)]
	private fsJsonParser(string input)
	{
	}
}
