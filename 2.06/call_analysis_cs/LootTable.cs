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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LootTable), Member = "PopulateFilteredLootTable_Legacy")]
	public GameObject GetRandomGearPrefab()
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int PopulateFilteredLootTable_Legacy()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(LootTableData), Member = "GetPrefabByName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public GameObject GetPrefab(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetPrefab_Legacy(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LootTable), Member = "PopulateFilteredLootTable_Legacy")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool DisableForXPMode(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public LootTable()
	{
	}
}
