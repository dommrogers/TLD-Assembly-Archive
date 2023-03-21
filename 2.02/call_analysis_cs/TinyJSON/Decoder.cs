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
		[CalledBy(Type = typeof(Decoder), Member = "ConsumeWhiteSpace")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextWord")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextToken")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Convert), Member = "ToChar")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return '\0';
		}
	}

	private char NextChar
	{
		[CalledBy(Type = typeof(Decoder), Member = "DecodeString")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextWord")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Convert), Member = "ToChar")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return '\0';
		}
	}

	private string NextWord
	{
		[CalledBy(Type = typeof(Decoder), Member = "DecodeNumber")]
		[CalledBy(Type = typeof(Decoder), Member = "get_NextToken")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
		[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Decoder), Member = "get_NextChar")]
		[Calls(Type = typeof(StringBuilder), Member = "Append")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 11)]
		get
		{
			return null;
		}
	}

	private Token NextToken
	{
		[CalledBy(Type = typeof(Decoder), Member = "Decode")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
		[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Decoder), Member = "get_NextWord")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return default(Token);
		}
	}

	[CalledBy(Type = typeof(Decoder), Member = "Decode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringReader), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private Decoder(string jsonString)
	{
	}

	[CalledBy(Type = typeof(JSON), Member = "Load")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decoder), Member = ".ctor")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "DecodeByToken")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static Variant Decode(string jsonString)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProxyObject), Member = ".ctor")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "DecodeString")]
	[Calls(Type = typeof(Decoder), Member = "DecodeByToken")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private ProxyObject DecodeObject()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProxyArray), Member = ".ctor")]
	[Calls(Type = typeof(Decoder), Member = "get_NextToken")]
	[Calls(Type = typeof(Decoder), Member = "DecodeByToken")]
	[Calls(Type = typeof(ProxyArray), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
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
	[CalledBy(Type = typeof(Decoder), Member = "Decode")]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
	[CalledBy(Type = typeof(Decoder), Member = "DecodeArray")]
	[CallerCount(Count = 3)]
	private Variant DecodeByToken(Token token)
	{
		return null;
	}

	[CalledBy(Type = typeof(Decoder), Member = "DecodeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Decoder), Member = "get_NextChar")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 34)]
	private Variant DecodeString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decoder), Member = "get_NextWord")]
	[Calls(Type = typeof(ProxyNumber), Member = "Parse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private Variant DecodeNumber()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decoder), Member = "get_PeekChar")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ConsumeWhiteSpace()
	{
	}
}
