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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallsUnknownMethods(Count = 3)]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Spline), Member = "Cache")]
	public override void Interp(Spline from, Spline to, float t)
	{
	}

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProBleed), Member = ".ctor")]
	[CalledBy(Type = typeof(RLProBleed), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CalledBy(Type = typeof(ColorGradingSettings), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RLProBleed), Member = ".ctor")]
	[CallerCount(Count = 15)]
	public SplineParameter()
	{
		((ParameterOverride<>)(object)this)._002Ector();
	}
}
