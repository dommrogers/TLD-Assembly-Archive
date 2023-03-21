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
			return false;
		}
	}

	private bool TypeHintsEnabled
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	private bool IncludePublicPropertiesEnabled
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	[CalledBy(Type = typeof(Encoder), Member = "Encode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private Encoder(EncodeOptions options)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string Encode(object obj)
	{
		return null;
	}

	[CalledBy(Type = typeof(JSON), Member = "Dump")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoder), Member = ".ctor")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static string Encode(object obj, EncodeOptions options)
	{
		return null;
	}

	[CalledBy(Type = typeof(Encoder), Member = "Encode")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Encoder), Member = "EncodeOther")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[Calls(Type = typeof(Encoder), Member = "EncodeList")]
	[Calls(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void EncodeValue(object value, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeOther")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBrace")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendComma")]
	[Calls(Type = typeof(Encoder), Member = "AppendColon")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBrace")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 31)]
	private void EncodeObject(object value, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBrace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(Encoder), Member = "EncodeString")]
	[Calls(Type = typeof(Encoder), Member = "AppendColon")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBrace")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private void EncodeDictionary(IDictionary value, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArray")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBracket")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBracket")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void EncodeList(IList value, bool forceTypeHint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[Calls(Type = typeof(Encoder), Member = "EncodeList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EncodeArray(Array value, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArray")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encoder), Member = "AppendOpenBracket")]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[Calls(Type = typeof(Encoder), Member = "EncodeValue")]
	[Calls(Type = typeof(Encoder), Member = "AppendCloseBracket")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 45)]
	private void EncodeArrayRank(Array value, int rank, int[] indices, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "ToCharArray")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Convert), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "PadHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private void EncodeString(string value)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "EncodeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void EncodeOther(object value, bool forceTypeHint)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CalledBy(Type = typeof(Encoder), Member = "AppendCloseBrace")]
	[CalledBy(Type = typeof(Encoder), Member = "AppendCloseBracket")]
	[CalledBy(Type = typeof(Encoder), Member = "AppendComma")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(StringBuilder), Member = "ExpandByABlock")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void AppendIndent()
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendOpenBrace()
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendCloseBrace()
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendOpenBracket()
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeList")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeArrayRank")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendCloseBracket()
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Encoder), Member = "AppendIndent")]
	[CallsUnknownMethods(Count = 1)]
	private void AppendComma(bool firstItem)
	{
	}

	[CalledBy(Type = typeof(Encoder), Member = "EncodeObject")]
	[CalledBy(Type = typeof(Encoder), Member = "EncodeDictionary")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 3)]
	private void AppendColon()
	{
	}
}
