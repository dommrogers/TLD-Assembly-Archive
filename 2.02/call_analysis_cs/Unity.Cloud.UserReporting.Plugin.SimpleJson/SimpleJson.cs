using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection;
using Unity.Cloud.UserReporting.Plugin.Version2018_3;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson;

public static class SimpleJson
{
	private const int TOKEN_NONE = 0;

	private const int TOKEN_CURLY_OPEN = 1;

	private const int TOKEN_CURLY_CLOSE = 2;

	private const int TOKEN_SQUARED_OPEN = 3;

	private const int TOKEN_SQUARED_CLOSE = 4;

	private const int TOKEN_COLON = 5;

	private const int TOKEN_COMMA = 6;

	private const int TOKEN_STRING = 7;

	private const int TOKEN_NUMBER = 8;

	private const int TOKEN_TRUE = 9;

	private const int TOKEN_FALSE = 10;

	private const int TOKEN_NULL = 11;

	private const int BUILDER_CAPACITY = 2000;

	private static readonly char[] EscapeTable;

	private static readonly char[] EscapeCharacters;

	private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

	private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

	public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
	{
		[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
		[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(SimpleJson), Member = "get_PocoJsonSerializerStrategy")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy
	{
		[CalledBy(Type = typeof(SimpleJson), Member = "get_CurrentJsonSerializerStrategy")]
		[Calls(Type = typeof(PocoJsonSerializerStrategy), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsUnknownMethods(Count = 21)]
	static SimpleJson()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 2)]
	public static object DeserializeObject(string json)
	{
		return null;
	}

	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryDeserializeObject(string json, out object obj)
	{
		obj = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsAssignableFrom")]
	[Calls(Type = typeof(SimpleJson), Member = "get_CurrentJsonSerializerStrategy")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
	{
		return null;
	}

	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static object DeserializeObject(string json, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 3)]
	public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 3)]
	public static T DeserializeObject<T>(string json)
	{
		return (T)null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
	{
		return null;
	}

	[CalledBy(Type = typeof(JsonArray), Member = "ToString")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "get_CurrentJsonSerializerStrategy")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SerializeJson")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SerializeJson")]
	[CalledBy(Type = typeof(JsonObject), Member = "ToString")]
	public static string SerializeObject(object json)
	{
		return null;
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static string EscapeToJavascriptString(string jsonString)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "LookAhead")]
	[Calls(Type = typeof(JsonObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "ParseString")]
	private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "LookAhead")]
	private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseString")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseArray")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseObject")]
	[Calls(Type = typeof(SimpleJson), Member = "LookAhead")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SimpleJson), Member = "ParseNumber")]
	private static object ParseValue(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt32")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(SimpleJson), Member = "ConvertFromUtf32")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "EatWhitespace")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static string ParseString(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseString")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	private static string ConvertFromUtf32(int utf32)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(SimpleJson), Member = "EatWhitespace")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	private static object ParseNumber(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 4)]
	private static int GetLastIndexOfNumber(char[] json, int index)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SimpleJson), Member = "NextToken")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseNumber")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private static void EatWhitespace(char[] json, ref int index)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	private static int LookAhead(char[] json, int index)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "LookAhead")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[Calls(Type = typeof(SimpleJson), Member = "EatWhitespace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	private static int NextToken(char[] json, ref int index)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeNumber")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
	{
		return default(bool);
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private static bool SerializeString(string aString, StringBuilder builder)
	{
		return default(bool);
	}

	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt64")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatDecimal")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	private static bool SerializeNumber(object number, StringBuilder builder)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsNumeric(object value)
	{
		return default(bool);
	}
}
