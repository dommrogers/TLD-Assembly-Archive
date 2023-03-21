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

	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public RLProOldFilm()
	{
	}
}
