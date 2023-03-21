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
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 48)]
	public LensDistortion()
	{
	}
}
