using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLPro_NTSC : PostProcessEffectSettings
{
	public FloatParameter brightness;

	public FloatParameter blur;

	public FloatParameter lineSpeed;

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 24)]
	public RLPro_NTSC()
	{
	}
}
