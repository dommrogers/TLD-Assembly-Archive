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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = ".ctor")]
	public RLProBleed()
	{
	}
}
