using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class FlickerModuleSet : ScriptableObject
{
	public enum IntensityOperation
	{
		mutliply,
		add,
		subtract,
		average,
		min,
		max
	}

	public MinMax m_FlickerChangeTime;

	public List<FlickerModule> m_FlickerModule;

	public List<IntensityOperation> m_IntensityOperation;

	private float m_MaxIntensity;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlickerModuleSet), Member = "ProcessIntensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public float ProcessIntensity(List<float> moduleTimeValues, float inputIntensity)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateIntensity")]
	[CalledBy(Type = typeof(FlickerModuleSet), Member = "ProcessIntensity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CallsUnknownMethods(Count = 2)]
	private float ProcessIntensity(FlickerValueGenerator valueGenerator, float timeValue, float inputIntensity, FlickerAmplitudeParameters amMods, IntensityOperation operation)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRandomFlickerDuration()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetMaxIntensity()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float Remap(float value, float inMin, float inMax, float toMin, float toMax)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public FlickerModuleSet()
	{
	}
}
