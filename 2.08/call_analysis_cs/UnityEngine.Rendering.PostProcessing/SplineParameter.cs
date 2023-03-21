using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class SplineParameter : ParameterOverride<Spline>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	protected internal override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override void Interp(Spline from, Spline to, float t)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SplineParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
