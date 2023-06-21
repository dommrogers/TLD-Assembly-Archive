using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class LootTableModData : ScriptableObject
{
	private List<RandomTableDataEntry<AssetReferenceGearItem>> m_AddLoot;

	private List<AssetReferenceGearItem> m_RemoveLoot;

	public IEnumerable<RandomTableDataEntry<AssetReferenceGearItem>> LootToAdd
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public IEnumerable<AssetReferenceGearItem> LootToRemove
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public LootTableModData()
	{
	}
}
