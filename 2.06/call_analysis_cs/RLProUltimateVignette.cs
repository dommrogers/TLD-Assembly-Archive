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

	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	public RLProUltimateVignette()
	{
	}
}
