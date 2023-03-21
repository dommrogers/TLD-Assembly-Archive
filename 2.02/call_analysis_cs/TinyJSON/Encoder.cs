using System;
using System.Collections;
using System.Globalization;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class Encoder
{
	private static readonly Type includeAttrType;

	private static readonly Type excludeAttrType;

	private static readonly Type typeHintAttrType;

	private StringBuilder builder;

	private EncodeOptions options;

	private int indent;

	private bool PrettyPrintEnabled
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	private bool TypeHintsEnabled
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	private bool IncludePublicPropertiesEnabled
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Encoder), Member = "Encode")]
	private Encoder(EncodeOptions options)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string Encode(object obj)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(JSON), Member = "Dump")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static string Encode(object obj, EncodeOptions options)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "Encode")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(Encoder), Member = "EncodeList")]
	[Calls(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[Calls(Type = typeof(Encoder), Member = "EncodeList")]
	[Calls(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(Encoder), Member = "EncodeOther")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	private void EncodeValue(object value, bool forceTypeHint)
	{
	}

	[Calls(Type = typeof(Encoder), Member = "AppendComma")]
	[Calls(Type = typeof(Encoder), Member = "AppendColon")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeOther")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(Encoder), Member = "AppendColon")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBrace")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBrace")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(Encoder), Member = "AppendComma")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	private void EncodeObject(object value, bool forceTypeHint)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBrace")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(Encoder), Member = "AppendColon")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBrace")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private void EncodeDictionary(IDictionary value, bool forceTypeHint)
	{
	}

	[Calls(Type = typeof(Encoder), Member = "AppendCloseBracket")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArray")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBracket")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	private void EncodeList(IList value, bool forceTypeHint)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Encoder), Member = "EncodeList")]
	[Calls(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void EncodeArray(Array value, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeArray")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBracket")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBracket")]
	[Calls(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "PadHelper")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Convert), Member = "ToString")]
	private void EncodeString(string value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "EncodeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void EncodeOther(object value, bool forceTypeHint)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Encoder), Member = "AppendComma")]
	[CalledBy(Type = typeof(Encoder), Member = "AppendCloseBrace")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CalledBy(Type = typeof(Encoder), Member = "AppendCloseBracket")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	private void AppendIndent()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendOpenBrace()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	private void AppendCloseBrace()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendOpenBracket()
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	private void AppendCloseBracket()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CallsUnknownMethods(Count = 1)]
	private void AppendComma(bool firstItem)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	private void AppendColon()
	{
	}
}
