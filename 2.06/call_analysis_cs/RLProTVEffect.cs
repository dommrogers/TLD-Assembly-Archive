using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProTVEffect : PostProcessEffectSettings
{
	public FloatParameter fade;

	public FloatParameter maskDark;

	public FloatParameter maskLight;

	public FloatParameter hardScan;

	public FloatParameter resScale;

	public FloatParameter hardPix;

	public WarpModeParameter warpMode;

	public Vector2Parameter warp;

	public FloatParameter scale;

	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	public RLProTVEffect()
	{
	}
}
