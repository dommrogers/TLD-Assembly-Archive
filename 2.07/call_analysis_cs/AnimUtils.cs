using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimUtils
{
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static Transform GetBoneTransform(string boneName, GameObject parent)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AnimUtils()
	{
	}
}
