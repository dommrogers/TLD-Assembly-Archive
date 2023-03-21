using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD;

public class SpawnRegionAnimalTableSO : ScriptableObject
{
	public List<SpawnAnimalTableEntry> m_SpawnAnimalsList;

	private float m_TotalOdds;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CallsUnknownMethods(Count = 6)]
	public AssetReferenceAnimalPrefab FindAnimalPrefab(string assetReferenceGUID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(SpawnRegionAnimalTableSO), Member = "FindAnimalPrefab")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "GetEntryAnimalFromMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	public AssetReferenceAnimalPrefab PickSpawnAnimal(WildlifeMode mode)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	[CallsUnknownMethods(Count = 1)]
	private AssetReferenceAnimalPrefab GetEntryAnimalFromMode(SpawnAnimalTableEntry entry, WildlifeMode mode)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public SpawnRegionAnimalTableSO()
	{
	}
}
