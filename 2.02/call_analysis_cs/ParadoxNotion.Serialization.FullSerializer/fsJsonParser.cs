using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public class fsJsonParser
{
	private int _start;

	private string _input;

	private readonly StringBuilder _cachedStringBuilder;

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private fsResult MakeFailure(string message)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool TryMoveNext()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasValue()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasValue(int offset)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 1)]
	private char Character()
	{
		return '\0';
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 1)]
	private char Character(int offset)
	{
		return '\0';
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	private void SkipSpace()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsHex(char c)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private uint ParseSingleChar(char c1, uint multipliyer)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	private uint ParseUnicode(char c1, char c2, char c3, char c4)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 40)]
	private fsResult TryUnescapeChar(out char escaped)
	{
		escaped = default(char);
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private fsResult TryParseExact(string content)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private fsResult TryParseTrue(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private fsResult TryParseFalse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseExact")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private fsResult TryParseNull(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsSeparator(char c)
	{
		return false;
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt64")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[Calls(Type = typeof(double), Member = "TryParse")]
	[Calls(Type = typeof(fsData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	private fsResult TryParseNumber(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryUnescapeChar")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private fsResult TryParseString(out string str)
	{
		str = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	private fsResult TryParseArray(out fsData arr)
	{
		arr = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "RunParse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	private fsResult TryParseObject(out fsData obj)
	{
		obj = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(fsJsonParser), Member = "SkipSpace")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseTrue")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseObject")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseFalse")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNull")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseArray")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseString")]
	[Calls(Type = typeof(fsJsonParser), Member = "TryParseNumber")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private fsResult RunParse(out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsJsonParser), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonParser), Member = "RunParse")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static fsResult Parse(string input, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static fsData Parse(string input)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private fsJsonParser(string input)
	{
	}
}
