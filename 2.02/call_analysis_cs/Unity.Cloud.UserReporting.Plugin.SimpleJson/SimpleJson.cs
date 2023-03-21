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
		[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
		[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(SimpleJson), Member = "get_PocoJsonSerializerStrategy")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PocoJsonSerializerStrategy), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	static SimpleJson()
	{
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static object DeserializeObject(string json)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryDeserializeObject(string json, out object obj)
	{
		obj = null;
		return false;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsAssignableFrom")]
	[Calls(Type = typeof(SimpleJson), Member = "get_CurrentJsonSerializerStrategy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static object DeserializeObject(string json, Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
	{
		return default(T);
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(UnityUserReportParser), Member = "ParseUserReport")]
	[CalledBy(Type = typeof(UnityUserReportParser), Member = "ParseUserReportList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static T DeserializeObject<T>(string json)
	{
		return default(T);
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
	{
		return null;
	}

	[CalledBy(Type = typeof(UnityUserReportingPlatform), Member = "SerializeJson")]
	[CalledBy(Type = typeof(AsyncUnityUserReportingPlatform), Member = "SerializeJson")]
	[CalledBy(Type = typeof(JsonArray), Member = "ToString")]
	[CalledBy(Type = typeof(JsonObject), Member = "ToString")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SimpleJson), Member = "get_CurrentJsonSerializerStrategy")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string SerializeObject(object json)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	public static string EscapeToJavascriptString(string jsonString)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonObject), Member = ".ctor")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "LookAhead")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseString")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[Calls(Type = typeof(SimpleJson), Member = "LookAhead")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseValue")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "TryDeserializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SimpleJson), Member = "LookAhead")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseObject")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseArray")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseString")]
	[Calls(Type = typeof(SimpleJson), Member = "ParseNumber")]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static object ParseValue(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(SimpleJson), Member = "EatWhitespace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseUInt32")]
	[Calls(Type = typeof(SimpleJson), Member = "ConvertFromUtf32")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	private static string ParseString(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[Calls(Type = typeof(string), Member = "CreateString")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static string ConvertFromUtf32(int utf32)
	{
		return null;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleJson), Member = "EatWhitespace")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "CtorCharArrayStartLength")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt64")]
	[Calls(Type = typeof(double), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static object ParseNumber(char[] json, ref int index, ref bool success)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static int GetLastIndexOfNumber(char[] json, int index)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseString")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseNumber")]
	[CalledBy(Type = typeof(SimpleJson), Member = "NextToken")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void EatWhitespace(char[] json, ref int index)
	{
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleJson), Member = "NextToken")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int LookAhead(char[] json, int index)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "ParseObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseArray")]
	[CalledBy(Type = typeof(SimpleJson), Member = "ParseValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "LookAhead")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SimpleJson), Member = "EatWhitespace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	private static int NextToken(char[] json, ref int index)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeArray")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeString")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeNumber")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeArray")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
	{
		return false;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeString")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
	{
		return false;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
	{
		return false;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOfAny")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static bool SerializeString(string aString, StringBuilder builder)
	{
		return false;
	}

	[CalledBy(Type = typeof(SimpleJson), Member = "SerializeValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(TypeFullName = "System.Number", Member = "FormatDecimal")]
	[Calls(TypeFullName = "System.Number", Member = "FormatUInt32")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(TypeFullName = "System.Number", Member = "FormatUInt64")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt64")]
	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(TypeFullName = "System.Number", Member = "FormatDouble")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static bool SerializeNumber(object number, StringBuilder builder)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsNumeric(object value)
	{
		return false;
	}
}
