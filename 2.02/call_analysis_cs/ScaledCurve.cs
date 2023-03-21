using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ScaledCurve
{
	public AnimationCurve curve;

	[CalledBy(Type = typeof(DarkLightingManager), Member = ".ctor")]
	[CalledBy(Type = typeof(InteriorLightingGroup), Member = ".ctor")]
	[CalledBy(Type = typeof(WaterfallTod), Member = ".ctor")]
	[CallerCount(Count = 7)]
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
