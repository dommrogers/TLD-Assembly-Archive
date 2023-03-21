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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 6)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 72)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public Vignette()
	{
	}
}
