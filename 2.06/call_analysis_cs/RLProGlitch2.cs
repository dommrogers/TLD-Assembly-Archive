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
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public RLProGlitch2()
	{
	}
}
