using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProUltimateVignette : PostProcessEffectSettings
{
	public VignetteModeParameter vignetteShape;

	public Vector2Parameter center;

	public FloatParameter vignetteAmount;

	public FloatParameter vignetteFineTune;

	public FloatParameter edgeSoftness;

	public FloatParameter edgeBlend;

	public FloatParameter innerColorAlpha;

	public ColorParameter innerColor;

	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public RLProUltimateVignette()
	{
	}
}
