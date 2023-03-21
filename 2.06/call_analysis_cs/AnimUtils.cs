using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimUtils
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
