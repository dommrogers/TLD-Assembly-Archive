using System;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public static class fsJsonPrinter
{
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void InsertSpacing(TextWriter stream, int count)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallsUnknownMethods(Count = 6)]
	private static string EscapeString(string str)
	{
		return null;
	}

	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 4)]
	private static void BuildCompressedString(fsData data, TextWriter stream)
	{
	}

	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "InsertSpacing")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 4)]
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

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CallsUnknownMethods(Count = 15)]
	public static string PrettyJson(fsData data)
	{
		return null;
	}

	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CallerCount(Count = 0)]
	public static void CompressedJson(fsData data, StreamWriter outputStream)
	{
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CalledBy(Type = typeof(fsData), Member = "ToString")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	public static string CompressedJson(fsData data)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	private static string ConvertDoubleToString(double d)
	{
		return null;
	}
}
