using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[CalledBy(Type = typeof(RLProJitter), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BoolParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
