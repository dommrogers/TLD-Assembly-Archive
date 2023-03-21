using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class UnsharpMask : PostProcessEffectSettings
{
	public FloatParameter intensity;

	public FloatParameter blurSpread;

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public UnsharpMask()
	{
	}
}
