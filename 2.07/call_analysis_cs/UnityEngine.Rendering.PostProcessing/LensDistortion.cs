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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public LensDistortion()
	{
	}
}
