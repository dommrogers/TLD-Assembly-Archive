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
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	public GameObject GetRandomGearItemPrefab()
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTable), Member = "GetPrefab")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetPrefabByName(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTableManager), Member = "OnExperienceModeChanged")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LootTableData), Member = "Awake")]
	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	[CallsUnknownMethods(Count = 12)]
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

	[CalledBy(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[Calls(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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
