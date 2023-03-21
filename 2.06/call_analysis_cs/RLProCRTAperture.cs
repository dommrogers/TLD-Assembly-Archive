using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProCRTAperture : PostProcessEffectSettings
{
	public FloatParameter GlowHalation;

	public FloatParameter GlowDifusion;

	public FloatParameter MaskColors;

	public FloatParameter MaskStrength;

	public FloatParameter GammaInput;

	public FloatParameter GammaOutput;

	public FloatParameter Brightness;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	public RLProCRTAperture()
	{
	}
}
