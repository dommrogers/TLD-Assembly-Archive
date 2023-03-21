using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LootTable : MonoBehaviour
{
	public LootTableData m_LootData;

	public List<GameObject> m_Prefabs;

	public List<int> m_Weights;

	private const int MAX_FILTERED_LOOT_TABLE_ITEMS = 256;

	private static readonly string EXCEEDED_LIMIT_LOG_MESSAGE;

	private static LootTableItem[] m_FilteredLootTableItems;

	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LootTable), Member = "PopulateFilteredLootTable_Legacy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GameObject GetRandomGearPrefab()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CallsUnknownMethods(Count = 6)]
	private int PopulateFilteredLootTable_Legacy()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LootTableData), Member = "GetPrefabByName")]
	[CallerCount(Count = 0)]
	public GameObject GetPrefab(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public GameObject GetPrefab_Legacy(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTable), Member = "PopulateFilteredLootTable_Legacy")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool DisableForXPMode(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public LootTable()
	{
	}
}
