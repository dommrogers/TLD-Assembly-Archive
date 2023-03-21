using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public static class Extensions
{
	[DeduplicatedMethod]
	[CalledBy(Type = typeof(JSON), Member = "Dump")]
	[CalledBy(Type = typeof(JSON), Member = "DecodeType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public static bool AnyOfType<TSource>(this IEnumerable<TSource> source, Type expectedType)
	{
		return false;
	}
}
