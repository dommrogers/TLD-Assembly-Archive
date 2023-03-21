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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTable), Member = "PopulateFilteredLootTable_Legacy")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public GameObject GetRandomGearPrefab()
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LootTable), Member = "DisableForXPMode")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int PopulateFilteredLootTable_Legacy()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(LootTableData), Member = "GetPrefabByName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetPrefab(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public GameObject GetPrefab_Legacy(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(LootTable), Member = "PopulateFilteredLootTable_Legacy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool DisableForXPMode(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public LootTable()
	{
	}
}
