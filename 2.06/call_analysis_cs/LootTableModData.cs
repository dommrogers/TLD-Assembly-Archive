using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LootTableModData : ScriptableObject
{
	private List<LootTableItemReference> m_AddLoot;

	private List<AssetReferenceGearItem> m_RemoveLoot;

	public IEnumerable<LootTableItemReference> LootToAdd
	{
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public IEnumerable<AssetReferenceGearItem> LootToRemove
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public LootTableModData()
	{
	}
}
