using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProNegative : PostProcessEffectSettings
{
	public FloatParameter luminosity;

	public FloatParameter vignette;

	public FloatParameter negative;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public RLProNegative()
	{
	}
}
