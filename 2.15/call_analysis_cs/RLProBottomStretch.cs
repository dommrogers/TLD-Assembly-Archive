using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProBottomStretch : PostProcessEffectSettings
{
	public FloatParameter height;

	public BoolParameter distort;

	public FloatParameter frequency;

	public FloatParameter amplitude;

	public BoolParameter distortRandomly;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public RLProBottomStretch()
	{
	}
}
