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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 46)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	public Vignette()
	{
	}
}
