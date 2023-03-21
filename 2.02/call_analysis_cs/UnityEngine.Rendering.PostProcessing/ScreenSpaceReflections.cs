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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntParameter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor")]
	public ScreenSpaceReflections()
	{
	}
}
