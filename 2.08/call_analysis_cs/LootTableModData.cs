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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public LootTableModData()
	{
	}
}
