using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LootTableModData : ScriptableObject
{
	private List<LootTableItemReference> m_AddLoot;

	private List<AssetReferenceGearItem> m_RemoveLoot;

	public IEnumerable<LootTableItemReference> LootToAdd
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		get
		{
			return null;
		}
	}

	public IEnumerable<AssetReferenceGearItem> LootToRemove
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public LootTableModData()
	{
	}
}
