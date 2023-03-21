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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 28)]
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

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "InitializeFlickerSet")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 1)]
	public void InitializeFlickerTiming(FlickerModuleSet moduleSet)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateFlickerTiming")]
	[CallsUnknownMethods(Count = 5)]
	public void AdvanceFlickerTiming(FlickerModuleSet moduleSet, float deltaTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public FlickerTimingControl()
	{
	}
}
