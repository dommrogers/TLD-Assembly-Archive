using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProNegative : PostProcessEffectSettings
{
	public FloatParameter luminosity;

	public FloatParameter vignette;

	public FloatParameter negative;

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public RLProNegative()
	{
	}
}
