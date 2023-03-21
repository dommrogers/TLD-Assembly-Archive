using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProCinematicBars : PostProcessEffectSettings
{
	public FloatParameter amount;

	public FloatParameter fade;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public RLProCinematicBars()
	{
	}
}
