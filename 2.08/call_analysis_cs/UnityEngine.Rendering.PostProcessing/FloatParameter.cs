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
		return default(bool);
	}

	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	public FloatParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
