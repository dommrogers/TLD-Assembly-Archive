using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TinyJSON;

public static class Extensions
{
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool AnyOfType<TSource>(this IEnumerable<TSource> source, Type expectedType)
	{
		return default(bool);
	}
}
