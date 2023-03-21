using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 43)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[CalledBy(Type = typeof(StartGearData), Member = "AddStartingGearToPlayer")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public GameObject GetRandomGearItemPrefab()
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTable), Member = "GetPrefab")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetPrefabByName(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CalledBy(Type = typeof(LootTableData), Member = "Awake")]
	[CalledBy(Type = typeof(LootTableManager), Member = "OnExperienceModeChanged")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(LootTableData), Member = "UpdateIfExperienceModeChanged")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(AssetReferenceWithComponent<>), Member = "GetOrLoadAsset")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(LootTableData), Member = "EvaluateWeights")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void InitializeForCurrentXPMode()
	{
	}

	[CalledBy(Type = typeof(LootTableData), Member = "Initialize")]
	[CalledBy(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void EvaluateWeights()
	{
	}

	[CalledBy(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(LootTableData), Member = "Initialize")]
	[Calls(Type = typeof(LootTableData), Member = "InitializeForCurrentXPMode")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public LootTableData()
	{
	}
}
