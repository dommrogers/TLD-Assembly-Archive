using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class FlickerValueGenerator : ScriptableObject
{
	public enum FlickerGeneratorType
	{
		CustomCurve,
		RandomCurve,
		SpikeyCurve,
		Sine
	}

	public AnimationCurve m_CustomIntensityCurve;

	public AnimationCurve m_RandomIntensityCurve;

	public AnimationCurve m_SpikyIntensityCurve;

	public FlickerGeneratorType m_FlickerGeneratorGeneratorType;

	public bool m_SmoothSteps;

	public int m_KeyCount;

	public float m_SpikePercentage;

	public float m_SineFrequency;

	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetFlickerValue(float time)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlickerValueGenerator), Member = "GenerateRandomCurve")]
	[Calls(Type = typeof(FlickerValueGenerator), Member = "GenerateSpikyCurve")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(FlickerValueGenerator), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 7)]
	public void GenerateRandomCurve()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FlickerValueGenerator), Member = "OnEnable")]
	[Calls(Type = typeof(AnimationCurve), Member = "AddKey")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void GenerateSpikyCurve()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	public FlickerValueGenerator()
	{
	}
}
