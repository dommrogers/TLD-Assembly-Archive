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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(KernelSizeParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public MaskedBlurEffect()
	{
	}
}
