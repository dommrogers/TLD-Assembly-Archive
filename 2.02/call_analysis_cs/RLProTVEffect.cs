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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(WarpModeParameter), Member = ".ctor")]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 71)]
	public RLProTVEffect()
	{
	}
}
