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

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[CallerCount(Count = 6)]
	private fsResult MakeFailure(string message)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	private char Character()
	{
		return default(char);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	private char Character(int offset)
	{
		return default(char);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	private fsResult TryUnescapeChar(out char escaped)
	{
		System.Runtime.CompilerServices.Unsafe.As<char, @null>(ref escaped) = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	private fsResult TryParseExact(string content)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	private fsResult TryParseTrue(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	private fsResult TryParseFalse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	private fsResult TryParseString(out string str)
	{
		str = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private fsResult TryParseArray(out fsData arr)
	{
		arr = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(string), Member = "FillStringChecked")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FillStringChecked")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "FillStringChecked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	private fsResult TryParseObject(out fsData obj)
	{
		obj = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	private fsResult RunParse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallsUnknownMethods(Count = 2)]
	public static fsResult Parse(string input, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallerCount(Count = 4)]
	public static fsData Parse(string input)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private fsJsonParser(string input)
	{
	}
}
