using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProGlitch2 : PostProcessEffectSettings
{
	public FloatParameter intencity;

	public FloatParameter resolutionMultiplier;

	public FloatParameter stretchMultiplier;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public RLProGlitch2()
	{
	}
}
