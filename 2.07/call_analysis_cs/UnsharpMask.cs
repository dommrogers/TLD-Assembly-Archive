using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class UnsharpMask : PostProcessEffectSettings
{
	public FloatParameter intensity;

	public FloatParameter blurSpread;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public UnsharpMask()
	{
	}
}
