using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public struct ScaledCurve
{
	public AnimationCurve curve;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	public ScaledCurve(float startVal, float endVal, bool easeInEaseOut = false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	public ScaledCurve(float startPos, float startVal, float endPos, float endVal, bool easeInEaseOut = false)
	{
	}
}
