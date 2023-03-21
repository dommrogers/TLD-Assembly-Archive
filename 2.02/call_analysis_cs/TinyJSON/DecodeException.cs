using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class DecodeException : Exception
{
	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DecodeException(string message)
	{
	}

	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DecodeException(string message, Exception innerException)
	{
	}
}
