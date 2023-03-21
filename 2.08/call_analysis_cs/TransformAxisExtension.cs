using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class TransformAxisExtension
{
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TransformAxisExtension), Member = "GetLocalValueFromAxis")]
	[CalledBy(Type = typeof(AnimateObjectActiveStatesFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	public static float GetLocalTransformValue(this TransformAxis axis, Transform transform)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	public static float GetLocalValueFromAxis(this Transform transform, TransformAxis axis)
	{
		return default(float);
	}
}
