using System;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public static class fsJsonPrinter
{
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallsUnknownMethods(Count = 1)]
	private static void InsertSpacing(TextWriter stream, int count)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	private static string EscapeString(string str)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private static void BuildCompressedString(fsData data, TextWriter stream)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	private static void BuildPrettyString(fsData data, TextWriter stream, int depth)
	{
	}

	[Calls(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CallerCount(Count = 0)]
	public static string ToJson(fsData data, bool pretty)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	public static void PrettyJson(fsData data, TextWriter outputStream)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	public static string PrettyJson(fsData data)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	public static void CompressedJson(fsData data, StreamWriter outputStream)
	{
	}

	[CalledBy(Type = typeof(fsData), Member = "ToString")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	public static string CompressedJson(fsData data)
	{
		return null;
	}

	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(System.Number), Member = "FormatDouble")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private static string ConvertDoubleToString(double d)
	{
		return null;
	}
}
