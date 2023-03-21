using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class FloatParameter : ParameterOverride<float>
{
	[CallerCount(Count = 0)]
	public override void Interp(float from, float to, float t)
	{
	}

	[CallerCount(Count = 0)]
	public override bool Equals(float a, float b)
	{
		return false;
	}

	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProJitter), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProNoise), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProVHSEffect), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 25)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FloatParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
