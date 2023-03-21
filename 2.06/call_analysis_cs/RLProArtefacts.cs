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

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public RLProArtefacts()
	{
	}
}
