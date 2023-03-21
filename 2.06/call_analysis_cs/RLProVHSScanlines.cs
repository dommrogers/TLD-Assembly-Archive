using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProVHSScanlines : PostProcessEffectSettings
{
	public ColorParameter scanLinesColor;

	public FloatParameter scanLines;

	public FloatParameter speed;

	public FloatParameter fade;

	public BoolParameter horizontal;

	public FloatParameter distortion;

	public FloatParameter distortion1;

	public FloatParameter distortion2;

	public FloatParameter scale;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 46)]
	public RLProVHSScanlines()
	{
	}
}
