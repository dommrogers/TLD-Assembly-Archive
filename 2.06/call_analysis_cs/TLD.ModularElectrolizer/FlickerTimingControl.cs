using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ModularElectrolizer;

public class FlickerTimingControl
{
	private float m_FlickerDurationLimit;

	private int m_CurrentFlickerSet;

	private List<float> m_FlickerModuleTiming;

	private List<float> m_FlickerModuleRateVariance;

	public float FlickerDurationLimit
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public int CurrentFlickerSet
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(int);
		}
	}

	public List<float> FlickerModuleTiming
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectRandomFlickerSet(int flickerSetCount)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void InitializeFlickerTiming(FlickerModuleSet moduleSet)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateFlickerTiming")]
	[CallsUnknownMethods(Count = 3)]
	public void AdvanceFlickerTiming(FlickerModuleSet moduleSet, float deltaTime)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public FlickerTimingControl()
	{
	}
}
