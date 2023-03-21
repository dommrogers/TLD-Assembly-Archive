using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProPulsatingVignette : PostProcessEffectSettings
{
	public FloatParameter speed;

	public FloatParameter amount;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public RLProPulsatingVignette()
	{
	}
}
