using System;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud;

public static class Preconditions
{
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void ArgumentIsLessThanOrEqualToLength(object value, int length, string argumentName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	public static void ArgumentNotNullOrWhitespace(object value, string argumentName)
	{
	}
}
