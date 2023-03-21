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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 56)]
	public RLProFisheye()
	{
	}
}
