using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProFisheye : PostProcessEffectSettings
{
	public FisheyeTypeParameter fisheyeType;

	public FloatParameter bend;

	public FloatParameter cutOffX;

	public FloatParameter cutOffY;

	public FloatParameter fadeX;

	public FloatParameter fadeY;

	public FloatParameter size;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 36)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public RLProFisheye()
	{
	}
}
