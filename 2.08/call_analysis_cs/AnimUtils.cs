using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimUtils
{
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 8)]
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
