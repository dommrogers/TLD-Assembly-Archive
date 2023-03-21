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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	public Vignette()
	{
	}
}
