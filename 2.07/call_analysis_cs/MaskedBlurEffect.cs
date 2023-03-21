using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class MaskedBlurEffect : PostProcessEffectSettings
{
	public TextureParameter depthTexture;

	public FloatParameter depthBlendAmount;

	public FloatParameter focusDistance;

	public FloatParameter aperture;

	public FloatParameter focalLength;

	public KernelSizeParameter kernelSize;

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public MaskedBlurEffect()
	{
	}
}
