using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProJitter : PostProcessEffectSettings
{
	public BoolParameter twitchHorizontal;

	public FloatParameter horizontalFreq;

	public BoolParameter twitchVertical;

	public FloatParameter verticalFreq;

	public FloatParameter twitchVerticalInterval;

	public BoolParameter stretch;

	public FloatParameter stretchResolution;

	public BoolParameter jitterHorizontal;

	public FloatParameter jitterHorizontalAmount;

	public BoolParameter jitterVertical;

	public FloatParameter jitterVerticalAmount;

	public FloatParameter jitterVerticalSpeed;

	public BoolParameter unscaledTime;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public RLProJitter()
	{
	}
}
