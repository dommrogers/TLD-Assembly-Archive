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
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 56)]
	public RLProPictureCorrection()
	{
	}
}
