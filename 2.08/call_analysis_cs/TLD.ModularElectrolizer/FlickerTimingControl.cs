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
			return 0f;
		}
	}

	public int CurrentFlickerSet
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return 0;
		}
	}

	public List<float> FlickerModuleTiming
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void InitializeFlickerTiming(FlickerModuleSet moduleSet)
	{
	}

	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(AuroraModularElectrolizer), Member = "UpdateFlickerTiming")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
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
