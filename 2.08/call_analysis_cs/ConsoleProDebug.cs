using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class ConsoleProDebug
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void LogToFilter(string inLog, string inFilterName)
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void Watch(string inName, string inValue)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Search(string inText)
	{
	}
}
