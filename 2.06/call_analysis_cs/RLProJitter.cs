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
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 69)]
	public RLProJitter()
	{
	}
}
