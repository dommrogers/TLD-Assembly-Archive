using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProPictureCorrection : PostProcessEffectSettings
{
	public FloatParameter signalAdjustY;

	public FloatParameter signalAdjustI;

	public FloatParameter signalAdjustQ;

	public FloatParameter signalShiftY;

	public FloatParameter signalShiftI;

	public FloatParameter signalShiftQ;

	public FloatParameter gammaCorection;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public RLProPictureCorrection()
	{
	}
}
