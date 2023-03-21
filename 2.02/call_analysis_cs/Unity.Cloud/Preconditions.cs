using System;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud;

public static class Preconditions
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void ArgumentIsLessThanOrEqualToLength(object value, int length, string argumentName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void ArgumentNotNullOrWhitespace(object value, string argumentName)
	{
	}
}
