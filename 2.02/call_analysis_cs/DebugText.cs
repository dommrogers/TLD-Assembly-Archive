using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugText : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void Add(string tag, string str)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void ActivateTags(string activateTags)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void DeactivateTags(string _tags)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DebugText()
	{
	}
}
