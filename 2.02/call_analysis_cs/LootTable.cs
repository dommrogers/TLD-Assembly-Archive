using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LootTable : MonoBehaviour
{
	public List<GameObject> m_Prefabs;

	public List<int> m_Weights;

	private const int MAX_FILTERED_LOOT_TABLE_ITEMS = 256;

	private static LootTableItem[] m_FilteredLootTableItems;

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "CatchFish")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 37)]
	public GameObject GetRandomGearPrefab()
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "InstantiateContents")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public GameObject GetPrefab(string name)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CallsUnknownMethods(Count = 2)]
	private bool DisableForXPMode(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 19)]
	public LootTable()
	{
	}
}
