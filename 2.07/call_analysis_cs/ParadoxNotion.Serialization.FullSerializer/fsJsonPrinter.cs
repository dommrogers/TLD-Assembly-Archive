using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public static class fsJsonPrinter
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void InsertSpacing(TextWriter stream, int count)
	{
	}

	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private static string EscapeString(string str)
	{
		return null;
	}

	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "CompressedJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	private static void BuildCompressedString(fsData data, TextWriter stream)
	{
	}

	[Calls(Type = typeof(fsData), Member = "get_AsInt64")]
	[Calls(Type = typeof(fsData), Member = "get_AsBool")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "PrettyJson")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "ConvertDoubleToString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "EscapeString")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(fsData), Member = "get_AsDouble")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsData), Member = "get_AsList")]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(JSONSerializer), Member = "PrettifyJson")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "ShowData")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallerCount(Count = 4)]
	public static string PrettyJson(fsData data)
	{
		return null;
	}

	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CallerCount(Count = 0)]
	public static void CompressedJson(fsData data, StreamWriter outputStream)
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "ToJson")]
	[CalledBy(Type = typeof(fsData), Member = "ToString")]
	[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	public static string CompressedJson(fsData data)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildCompressedString")]
	[CalledBy(Type = typeof(fsJsonPrinter), Member = "BuildPrettyString")]
	[CallAnalysisFailed]
	private static string ConvertDoubleToString(double d)
	{
		return null;
	}
}
