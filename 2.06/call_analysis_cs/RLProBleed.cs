using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProBleed : PostProcessEffectSettings
{
	public bleedModeParameter bleedMode;

	public int bleedModeIndex;

	public FloatParameter bleedAmount;

	public IntParameter bleedLength;

	public BoolParameter bleedDebug;

	public BoolParameter editCurves;

	public BoolParameter syncYQ;

	public SplineParameter curveY;

	public SplineParameter curveI;

	public SplineParameter curveQ;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 82)]
	public RLProBleed()
	{
	}
}
