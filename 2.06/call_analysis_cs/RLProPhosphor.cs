using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProPhosphor : PostProcessEffectSettings
{
	public FloatParameter fade;

	public FloatParameter width;

	public FloatParameter amount;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	public RLProPhosphor()
	{
	}
}
