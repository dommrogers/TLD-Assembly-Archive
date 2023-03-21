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
		[DeduplicatedMethod]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 38)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	public GameObject GetRandomGearItemPrefab()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LootTable), Member = "GetPrefab")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public GameObject GetPrefabByName(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTableData), Member = "Awake")]
	[CalledBy(Type = typeof(LootTableManager), Member = "OnExperienceModeChanged")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void InitializeForCurrentXPMode()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LootTableData), Member = "Initialize")]
	[CalledBy(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	[CallsUnknownMethods(Count = 2)]
	private void EvaluateWeights()
	{
	}

	[Calls(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[CalledBy(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public LootTableData()
	{
	}
}
