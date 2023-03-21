using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HeatSourceManager : MonoBehaviour
{
	public List<HeatSource> m_HeatSources;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "CalculateCurrentTemperature")]
	[CalledBy(Type = typeof(Weather), Member = "CalculateCurrentTemperature")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeatSource), Member = "GetTempIncrease")]
	public float GetTemperatureIncrease(Vector3 position)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void AddHeatSource(HeatSource hs)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HeatSource), Member = "TurnOffImmediate")]
	[CalledBy(Type = typeof(HeatSource), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveHeatSource(HeatSource hs)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(HeatSource), Member = "GetTempIncrease")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public HeatSource GetBestHeatSourceInRange()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public HeatSourceManager()
	{
	}
}
