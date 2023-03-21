using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProPulsatingVignette : PostProcessEffectSettings
{
	public FloatParameter speed;

	public FloatParameter amount;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public RLProPulsatingVignette()
	{
	}
}
