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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ScreenSpaceReflections()
	{
	}
}
