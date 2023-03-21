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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	public Bloom()
	{
	}
}
