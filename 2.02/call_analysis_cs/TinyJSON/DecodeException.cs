using System;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public sealed class DecodeException : Exception
{
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	public DecodeException(string message)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	public DecodeException(string message, Exception innerException)
	{
	}
}
