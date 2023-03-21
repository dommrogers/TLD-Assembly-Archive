using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Bloom : PostProcessEffectSettings
{
	public FloatParameter intensity;

	public FloatParameter threshold;

	public FloatParameter softKnee;

	public FloatParameter clamp;

	public FloatParameter diffusion;

	public FloatParameter anamorphicRatio;

	public ColorParameter color;

	public BoolParameter fastMode;

	public TextureParameter dirtTexture;

	public FloatParameter dirtIntensity;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 80)]
	public Bloom()
	{
	}
}
