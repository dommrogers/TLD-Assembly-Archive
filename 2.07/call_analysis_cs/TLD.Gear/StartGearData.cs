using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class StartGearData : ScriptableObject
{
	public FixedGearItem[] m_FixedGear;

	public RandomGearItem[] m_RandomGear;

	private Func<int, int, int> _003CRandomRange_003Ek__BackingField;

	public Func<int, int, int> RandomRange
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		set
		{
		}
	}

	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "PutOn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	public void AddStartingGearToPlayer(PlayerManager playerManager, Action<List<GearItem>> onItemsAddedCallback = null)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public StartGearData()
	{
	}
}
