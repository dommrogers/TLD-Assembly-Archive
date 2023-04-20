using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.Pool;

namespace TLD.Gameplay;

public class BeachcombingSpawner : MonoBehaviour
{
	private float m_ActiveTimeAfterBlizzard;

	private LootTableData m_BlizzardLootTable;

	private int m_MinBigItemsToSpawn;

	private int m_MaxBigItemsToSpawn;

	private bool m_SpawnUniqueItems;

	private float m_BigItemTimeToDespawn;

	private BeachcombingBigItemTableData m_BigItemTable;

	private float m_BigItemSpawnThresholdRadius;

	private bool m_BlizzardTableActive;

	private List<RadialObjectSpawner> m_ChildSpawners;

	private List<BeachcombingBigItemLocation> m_BigItemLocations;

	private List<CustomSpawnedItem> m_OldBigItems;

	private BeachcombingSpawnerSaveData _003CCurrentState_003Ek__BackingField;

	private static List<BeachcombingSpawner> s_Instances;

	private bool IsActive
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
		get
		{
			return false;
		}
	}

	private bool HasBigItemsExpired
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
		get
		{
			return false;
		}
	}

	public BeachcombingSpawnerSaveData CurrentState
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 47)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "SetStandardTable")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "UpdateBigItems")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "SetBlizzardTable")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "CheckForNewBlizzard")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "SetStandardTable")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "UpdateBigItems")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "SetBlizzardTable")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "CheckForNewBlizzard")]
	private void UpdateBeachcombing()
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBeachcombing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetOverrideLootTableData")]
	[CallsUnknownMethods(Count = 3)]
	private void SetBlizzardTable()
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBeachcombing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetOverrideLootTableData")]
	[CallsUnknownMethods(Count = 3)]
	private void SetStandardTable()
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBeachcombing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "ExpireBigItems")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ForceRefreshSpawnedItems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void CheckForNewBlizzard()
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "Update")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBeachcombing")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "ExpireBigItems")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateBigItems()
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "CheckForNewBlizzard")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBigItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void ExpireBigItems()
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBigItems")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DeserializeBigItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RandomTableData<>), Member = "FilterEntries")]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(RandomTableData), Member = "get_RandomRange")]
	[Calls(Type = typeof(Utils), Member = "ShuffleList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BeachcombingBigItemLocation), Member = "IsReferenceAllowed")]
	[Calls(Type = typeof(CustomSpawnedItemManager), Member = "SpawnBigItem")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 29)]
	private void DrawAndPlaceBigItems()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CollectionPool<, >), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "TryDeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PdidTable), Member = "GetComponentOnGameObject")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "DeserializeBigItems")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(BeachcombingSpawnerSaveData saveData)
	{
	}

	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BeachcombingManager), Member = "get_BlizzardID")]
	[Calls(Type = typeof(BeachcombingManager), Member = "get_TimeSinceLastBlizzard")]
	[Calls(Type = typeof(PdidTable), Member = "GetComponentOnGameObject")]
	[Calls(Type = typeof(BeachcombingBigItemLocation), Member = "IsReferenceAllowed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void DeserializeBigItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public BeachcombingSpawner()
	{
	}
}
