using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class ScaledCurve
{
	public AnimationCurve curve;

	[CalledBy(Type = typeof(WaterfallTod), Member = ".ctor")]
	[CalledBy(Type = typeof(InteriorLightingGroup), Member = ".ctor")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = ".ctor")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = ".ctor")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[CalledBy(Type = typeof(WaterfallTod), Member = ".ctor")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = ".ctor")]
	public ScaledCurve(float startVal, float endVal, bool easeInEaseOut = false)
	{
	}

	[Calls(Type = typeof(AnimationCurve), Member = "EaseInOut")]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	public ScaledCurve(float startPos, float startVal, float endPos, float endVal, bool easeInEaseOut = false)
	{
	}
}
