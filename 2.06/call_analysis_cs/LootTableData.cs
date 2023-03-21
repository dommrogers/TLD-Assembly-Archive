using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Logging;
using UnityEngine;

public class LootTableData : ScriptableObject
{
	public static readonly LogFilter s_LogFilter;

	private List<LootTableItemReference> m_BaseLoot;

	private List<LootTableItemReference> m_Loot;

	private int m_SumOfWeights;

	private ExperienceMode m_lastExperienceMode;

	private Func<int, int, int> _003CRandomRange_003Ek__BackingField;

	public Func<int, int, int> RandomRange
	{
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 33)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CallsUnknownMethods(Count = 8)]
	public GameObject GetRandomGearItemPrefab()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LootTable), Member = "GetPrefab")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GameObject GetPrefabByName(string prefabName)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CalledBy(Type = typeof(LootTableData), Member = "Awake")]
	[CalledBy(Type = typeof(LootTableManager), Member = "OnExperienceModeChanged")]
	[CallsUnknownMethods(Count = 1)]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void InitializeForCurrentXPMode()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LootTableData), Member = "Initialize")]
	[CalledBy(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	private void EvaluateWeights()
	{
	}

	[Calls(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateIfExperienceModeChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallsUnknownMethods(Count = 1)]
	private ExperienceMode GetCurrentExperienceMode()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[CallsUnknownMethods(Count = 7)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public LootTableData()
	{
	}
}
