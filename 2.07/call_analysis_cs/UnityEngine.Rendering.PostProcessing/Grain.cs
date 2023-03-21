using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Grain : PostProcessEffectSettings
{
	public BoolParameter colored;

	public FloatParameter intensity;

	public FloatParameter size;

	public FloatParameter lumContrib;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public Grain()
	{
	}
}
