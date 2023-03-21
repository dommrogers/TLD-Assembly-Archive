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
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public RLProVHSScanlines()
	{
	}
}
