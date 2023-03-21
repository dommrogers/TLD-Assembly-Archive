using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeatSourceManager : MonoBehaviour
{
	public List<HeatSource> m_HeatSources;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(HeatSource), Member = "GetTempIncrease")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetTemperatureIncrease(Vector3 position)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddHeatSource(HeatSource hs)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(HeatSource), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void RemoveHeatSource(HeatSource hs)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(HeatSource), Member = "GetTempIncrease")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	public HeatSource GetBestHeatSourceInRange()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public HeatSourceManager()
	{
	}
}
