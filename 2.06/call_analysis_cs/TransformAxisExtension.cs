using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class TransformAxisExtension
{
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateMaterialPropertyFromBone), Member = "Update")]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[CalledBy(Type = typeof(TransformAxisExtension), Member = "GetLocalValueFromAxis")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[CalledBy(Type = typeof(AnimateObjectActiveStatesFromBone), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[CalledBy(Type = typeof(AnimateDecalRevealFromBone), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localEulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 6)]
	public static float GetLocalTransformValue(this TransformAxis axis, Transform transform)
	{
		return default(float);
	}

	[Calls(Type = typeof(TransformAxisExtension), Member = "GetLocalTransformValue")]
	[CallerCount(Count = 0)]
	public static float GetLocalValueFromAxis(this Transform transform, TransformAxis axis)
	{
		return default(float);
	}
}
