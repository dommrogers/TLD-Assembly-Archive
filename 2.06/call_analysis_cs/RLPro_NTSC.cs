using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class RLPro_NTSC : PostProcessEffectSettings
{
	public FloatParameter brightness;

	public FloatParameter blur;

	public FloatParameter lineSpeed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public RLPro_NTSC()
	{
	}
}
