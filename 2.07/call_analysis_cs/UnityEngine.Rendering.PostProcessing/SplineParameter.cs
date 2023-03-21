using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class SplineParameter : ParameterOverride<Spline>
{
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallerCount(Count = 0)]
	protected internal override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallsUnknownMethods(Count = 2)]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallsUnknownMethods(Count = 3)]
	public override void Interp(Spline from, Spline to, float t)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	public SplineParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
