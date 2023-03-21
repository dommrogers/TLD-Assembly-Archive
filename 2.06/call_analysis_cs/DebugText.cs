using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugText : MonoBehaviour
{
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Add(string tag, string str)
	{
	}

	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	public static void ActivateTags(string activateTags)
	{
	}

	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	public static void DeactivateTags(string _tags)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public DebugText()
	{
	}
}
