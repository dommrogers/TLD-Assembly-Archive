using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugText : MonoBehaviour
{
	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Add(string tag, string str)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ActivateTags(string activateTags)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void DeactivateTags(string _tags)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DebugText()
	{
	}
}
