using System;
using System.IO;
using System.Text;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class Decoder : IDisposable
{
	private enum Token
	{
		None,
		OpenBrace,
		CloseBrace,
		OpenBracket,
		CloseBracket,
		Colon,
		Comma,
		String,
		Number,
		True,
		False,
		Null
	}

	private const string WhiteSpace = " \t\n\r";

	private const string WordBreak = " \t\n\r{}[],:\"";

	private StringReader json;

	private char PeekChar
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextToken")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextToken")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextWord")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextToken")]
		[Calls(Type = typeof(Convert), Member = "ToChar")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Decoder), Member = "ConsumeWhiteSpace")]
		get
		{
			return default(char);
		}
	}

	private char NextChar
	{
		[CalledBy(Type = typeof(Decoder), Member = "get_NextWord")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeString")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeString")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Convert), Member = "ToChar")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeString")]
		get
		{
			return default(char);
		}
	}

	private string NextWord
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Decoder), Member = "get_NextChar")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeNumber")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextToken")]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	private Token NextToken
	{
		[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(Decoder), Member = "Decode")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(Decoder), Member = "get_NextWord")]
		[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 5)]
		get
		{
			return default(Token);
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringReader), Member = ".ctor")]
	[CalledBy(Type = typeof(Decoder), Member = "Decode")]
	[CallsUnknownMethods(Count = 7)]
	private Decoder(string jsonString)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Decoder), Member = ".ctor")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "DecodeByToken")]
	[CalledBy(Type = typeof(JSON), Member = "Load")]
	[CallsUnknownMethods(Count = 10)]
	public static Variant Decode(string jsonString)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ProxyObject), Member = ".ctor")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "DecodeString")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "DecodeByToken")]
	[CallsUnknownMethods(Count = 12)]
	private ProxyObject DecodeObject()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ProxyArray), Member = "Add")]
	[Calls(Type = typeof(Decoder), Member = "DecodeByToken")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProxyArray), Member = ".ctor")]
	private ProxyArray DecodeArray()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private Variant DecodeValue()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Decoder), Member = "Decode")]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
	private Variant DecodeByToken(Token token)
	{
		return null;
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Decoder), Member = "get_NextChar")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Decoder), Member = "get_NextChar")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Decoder), Member = "get_NextChar")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	private Variant DecodeString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ProxyNumber), Member = "Parse")]
	[Calls(Type = typeof(Decoder), Member = "get_NextWord")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private Variant DecodeNumber()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 3)]
	private void ConsumeWhiteSpace()
	{
	}
}
