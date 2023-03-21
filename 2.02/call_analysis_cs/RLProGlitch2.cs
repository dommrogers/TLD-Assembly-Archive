using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProGlitch2 : PostProcessEffectSettings
{
	public FloatParameter intencity;

	public FloatParameter resolutionMultiplier;

	public FloatParameter stretchMultiplier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	public RLProGlitch2()
	{
	}
}
