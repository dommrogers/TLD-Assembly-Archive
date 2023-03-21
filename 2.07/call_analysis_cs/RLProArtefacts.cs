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

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public RLProArtefacts()
	{
	}
}
