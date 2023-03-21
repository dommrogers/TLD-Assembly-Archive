using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProCinematicBars : PostProcessEffectSettings
{
	public FloatParameter amount;

	public FloatParameter fade;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public RLProCinematicBars()
	{
	}
}
