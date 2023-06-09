using System;
using Cpp2ILInjected.CallAnalysis;
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
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(IntParameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(SplineParameter), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.Spline), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 117)]
	public RLProBleed()
	{
	}
}
