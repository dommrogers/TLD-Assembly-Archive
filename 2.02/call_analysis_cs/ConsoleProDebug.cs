using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class ConsoleProDebug
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Clear()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void LogToFilter(string inLog, string inFilterName)
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Watch(string inName, string inValue)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Search(string inText)
	{
	}
}
