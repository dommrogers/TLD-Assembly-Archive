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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 26)]
	public RLProArtefacts()
	{
	}
}
