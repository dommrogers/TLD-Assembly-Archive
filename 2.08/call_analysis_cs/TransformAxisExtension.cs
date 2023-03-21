using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class TransformAxisExtension
{
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateObjectActiveStatesFromBone), Member = "Update")]
	[CalledBy(Type = typeof(TransformAxisExtension), Member = "GetLocalValueFromAxis")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public static float GetLocalTransformValue(this TransformAxis axis, Transform transform)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	public static float GetLocalValueFromAxis(this Transform transform, TransformAxis axis)
	{
		return 0f;
	}
}
