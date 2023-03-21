using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public static class fsJsonPrinter
{
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void InsertSpacing(TextWriter stream, int count)
	{
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static string EscapeString(string str)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 17)]
	private static void BuildCompressedString(fsData data, TextWriter stream)
	{
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 22)]
	private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	public static string ToJson(fsData data, bool pretty)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	public static void PrettyJson(fsData data, TextWriter outputStream)
	{
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public static string PrettyJson(fsData data)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	public static void CompressedJson(fsData data, StreamWriter outputStream)
	{
	}

	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(fsData), Member = "ToString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public static string CompressedJson(fsData data)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(double), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatDouble")]
	[CallsUnknownMethods(Count = 3)]
	private static string ConvertDoubleToString(double d)
	{
		return null;
	}
}
