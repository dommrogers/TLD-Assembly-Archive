using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProWarp : PostProcessEffectSettings
{
	public FloatParameter fade;

	public WarpModeParameter warpMode;

	public Vector2Parameter warp;

	public FloatParameter scale;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public RLProWarp()
	{
	}
}
