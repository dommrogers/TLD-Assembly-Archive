using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLProOldFilm : PostProcessEffectSettings
{
	public FloatParameter fps;

	public FloatParameter contrast;

	public FloatParameter burn;

	public FloatParameter sceneCut;

	public FloatParameter fade;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public RLProOldFilm()
	{
	}
}
