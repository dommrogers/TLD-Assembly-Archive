using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimUtils
{
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static Transform GetBoneTransform(string boneName, GameObject parent)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AnimUtils()
	{
	}
}
