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
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
	}

	public IEnumerable<AssetReferenceGearItem> LootToRemove
	{
		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public LootTableModData()
	{
	}
}
