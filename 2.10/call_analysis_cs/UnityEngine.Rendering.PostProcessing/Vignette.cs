using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Vignette : PostProcessEffectSettings
{
	public VignetteModeParameter mode;

	public ColorParameter color;

	public Vector2Parameter center;

	public FloatParameter intensity;

	public FloatParameter smoothness;

	public FloatParameter roundness;

	public BoolParameter rounded;

	public TextureParameter mask;

	public FloatParameter opacity;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public Vignette()
	{
	}
}
