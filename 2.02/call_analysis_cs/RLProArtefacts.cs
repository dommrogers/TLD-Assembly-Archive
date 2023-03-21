using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProArtefacts : PostProcessEffectSettings
{
	public FloatParameter cutOff;

	public FloatParameter amount;

	public FloatParameter fade;

	public ColorParameter color;

	public BoolParameter debugArtefacts;

	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public RLProArtefacts()
	{
	}
}
