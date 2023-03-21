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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 31)]
	public LensDistortion()
	{
	}
}
