using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class ScreenSpaceReflections : PostProcessEffectSettings
{
	public ScreenSpaceReflectionPresetParameter preset;

	public IntParameter maximumIterationCount;

	public ScreenSpaceReflectionResolutionParameter resolution;

	public FloatParameter thickness;

	public FloatParameter maximumMarchDistance;

	public FloatParameter distanceFade;

	public FloatParameter vignette;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 56)]
	public ScreenSpaceReflections()
	{
	}
}
