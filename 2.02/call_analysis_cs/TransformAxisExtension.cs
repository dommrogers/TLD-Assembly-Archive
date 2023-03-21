using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class TransformAxisExtension
{
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateObjectActiveStatesFromBone), Member = "Update")]
	[CalledBy(Type = typeof(TransformAxisExtension), Member = "GetLocalValueFromAxis")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
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
