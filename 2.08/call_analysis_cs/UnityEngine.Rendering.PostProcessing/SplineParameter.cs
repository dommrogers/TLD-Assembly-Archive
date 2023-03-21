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

	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[Calls(Type = typeof(Spline), Member = "Cache")]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Interp(Spline from, Spline to, float t)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	public SplineParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
