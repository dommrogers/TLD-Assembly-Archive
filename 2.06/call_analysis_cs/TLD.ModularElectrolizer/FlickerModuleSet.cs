using System;
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlickerModuleSet), Member = "ProcessIntensity")]
	public float ProcessIntensity(List<float> moduleTimeValues, float inputIntensity)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateIntensity")]
	[CalledBy(Type = typeof(FlickerModuleSet), Member = "ProcessIntensity")]
	[CallsUnknownMethods(Count = 2)]
	private float ProcessIntensity(FlickerValueGenerator valueGenerator, float timeValue, float inputIntensity, FlickerAmplitudeParameters amMods, IntensityOperation operation)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRandomFlickerDuration()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetMaxIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float Remap(float value, float inMin, float inMax, float toMin, float toMax)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public FlickerModuleSet()
	{
	}
}
