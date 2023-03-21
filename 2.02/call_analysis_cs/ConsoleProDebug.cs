using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class ConsoleProDebug
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogToFilter(string inLog, string inFilterName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 25)]
	public static void Watch(string inName, string inValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Search(string inText)
	{
	}
}
