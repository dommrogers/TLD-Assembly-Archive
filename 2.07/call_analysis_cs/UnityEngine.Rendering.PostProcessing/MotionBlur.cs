using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class MotionBlur : PostProcessEffectSettings
{
	public FloatParameter shutterAngle;

	public IntParameter sampleCount;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported")]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public MotionBlur()
	{
	}
}
