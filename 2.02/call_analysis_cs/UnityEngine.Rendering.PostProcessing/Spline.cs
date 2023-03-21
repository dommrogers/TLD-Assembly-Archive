using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Spline
{
	public const int k_Precision = 128;

	public const float k_Step = 1f / 128f;

	public AnimationCurve curve;

	private bool m_Loop;

	private float m_ZeroValue;

	private float m_Range;

	private AnimationCurve m_InternalLoopingCurve;

	private int frameCount;

	public float[] cachedData;

	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor")]
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
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(RLProBleed), Member = ".ctor")]
	public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
	{
	}

	[CalledBy(Type = typeof(SplineParameter), Member = "SetValue")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(SplineParameter), Member = "Interp")]
	[CalledBy(Type = typeof(SplineParameter), Member = "Interp")]
	[Calls(Type = typeof(AnimationCurve), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SplineParameter), Member = "OnEnable")]
	public void Cache(int frame)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 1)]
	public float Evaluate(float t, int length)
	{
		return default(float);
	}

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float Evaluate(float t)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override int GetHashCode()
	{
		return default(int);
	}
}
