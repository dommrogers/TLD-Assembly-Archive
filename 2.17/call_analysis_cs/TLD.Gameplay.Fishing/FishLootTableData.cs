using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gameplay.Fishing;

public class FishLootTableData : LootTableData
{
	private GameplayTag m_RareFishTag;

	private float m_LureModifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void SetLureModifier(float modifier)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesTag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected override int GetEntryWeight(RandomTableDataEntry<AssetReferenceGearItem> entry)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomTableData<>), Member = ".ctor")]
	public FishLootTableData()
	{
	}
}
