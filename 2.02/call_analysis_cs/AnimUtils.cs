using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimUtils
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static Transform GetBoneTransform(string boneName, GameObject parent)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AnimUtils()
	{
	}
}
