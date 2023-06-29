using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gameplay.Fishing;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gameplay;

public abstract class RandomTableData : ScriptableObject
{
	private Func<int, int, int> _003CCustomRandomRange_003Ek__BackingField;

	public abstract bool CanDrawFromTable { get; }

	public Func<int, int, int> CustomRandomRange
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		protected get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		set
		{
		}
	}

	protected Func<int, int, int> RandomRange
	{
		[CalledBy(Type = typeof(IceFishingHole), Member = "RollNextCatch")]
		[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
		[CalledBy(Type = typeof(RandomTableData<>), Member = "FilterEntries")]
		[CalledBy(Type = typeof(RandomTableData<>), Member = "DrawRandomItems")]
		[CalledBy(Type = typeof(RandomTableData<>), Member = "DrawRandomItem")]
		[CalledBy(Type = typeof(RandomTableData<>), Member = "DrawRandomPrefabs")]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public abstract int DrawRandomPrefabs(int wantedPrefabs, List<GameObject> drawnPrefabs, bool allowDuplicates = true);

	public abstract GameObject DrawRandomPrefab();

	public abstract GameObject GetPrefabByName(string prefabName);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	protected RandomTableData()
	{
	}
}
public class RandomTableData<T> : RandomTableData where T : AssetReferenceGameObject
{
	public static readonly LogFilter s_LogFilter;

	private List<RandomTableDataEntry<T>> m_BaseEntries;

	protected readonly List<T> m_FilteredExtendedItems;

	private readonly Dictionary<IKeyEvaluator, AsyncOperationHandle<GameObject>> m_ExistingOperations;

	public override bool CanDrawFromTable
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeInitializeTable()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(BeachcombingBigItemTableData), Member = "FilterItemsForLocations")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RandomTableData), Member = "get_RandomRange")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	protected void FilterEntries()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual int GetEntryWeight(RandomTableDataEntry<T> entry)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual bool ShouldFilterOutItem(T item)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual bool ShouldFilterOutPrefab(GameObject prefab)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomTableData), Member = "get_RandomRange")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	public int DrawRandomItems(int wantedItems, List<T> drawnItems, bool allowDuplicates = true)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomTableData), Member = "get_RandomRange")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public T DrawRandomItem()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RandomTableData), Member = "get_RandomRange")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 3)]
	public override int DrawRandomPrefabs(int wantedPrefabs, List<GameObject> drawnPrefabs, bool allowDuplicates = true)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override GameObject DrawRandomPrefab()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override GameObject GetPrefabByName(string itemName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected GameObject LoadPrefab(T item)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(LootTableData), Member = ".ctor")]
	[CalledBy(Type = typeof(BeachcombingBigItemTableData), Member = ".ctor")]
	[CalledBy(Type = typeof(FishLootTableData), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public RandomTableData()
	{
	}
}
