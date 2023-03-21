using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class LensDistortion : PostProcessEffectSettings
{
	public FloatParameter intensity;

	public FloatParameter intensityX;

	public FloatParameter intensityY;

	public FloatParameter centerX;

	public FloatParameter centerY;

	public FloatParameter scale;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 31)]
	public LensDistortion()
	{
	}
}
