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

	[CallsUnknownMethods(Count = 26)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	public RLProBottomStretch()
	{
	}
}
