using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public class fsJsonParser
{
	private int _start;

	private string _input;

	private readonly StringBuilder _cachedStringBuilder;

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[CallsUnknownMethods(Count = 23)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool HasValue(int offset)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 1)]
	private char Character()
	{
		return default(char);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 1)]
	private char Character(int offset)
	{
		return default(char);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	private void SkipSpace()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsHex(char c)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private uint ParseSingleChar(char c1, uint multipliyer)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	private uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		return default(uint);
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	private fsResult TryUnescapeChar(out char escaped)
	{
		System.Runtime.CompilerServices.Unsafe.As<char, @null>(ref escaped) = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private fsResult TryParseExact(string content)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallsUnknownMethods(Count = 7)]
	private fsResult TryParseTrue(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	private fsResult TryParseFalse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	private fsResult TryParseNull(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool IsSeparator(char c)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 21)]
	private fsResult TryParseNumber(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private fsResult TryParseString(out string str)
	{
		str = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	private fsResult TryParseArray(out fsData arr)
	{
		arr = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	private fsResult TryParseObject(out fsData obj)
	{
		obj = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	private fsResult RunParse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	public static fsResult Parse(string input, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	[CallsUnknownMethods(Count = 1)]
	public static fsData Parse(string input)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private fsJsonParser(string input)
	{
	}
}
