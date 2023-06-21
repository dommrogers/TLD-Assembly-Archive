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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public RLProUltimateVignette()
	{
	}
}
