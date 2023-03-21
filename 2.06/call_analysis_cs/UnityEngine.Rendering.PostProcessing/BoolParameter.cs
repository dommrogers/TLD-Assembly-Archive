using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class BoolParameter : ParameterOverride<bool>
{
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProJitter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	public BoolParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
