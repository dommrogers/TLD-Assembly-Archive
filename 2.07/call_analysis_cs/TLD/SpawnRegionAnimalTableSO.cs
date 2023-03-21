using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD;

public class SpawnRegionAnimalTableSO : ScriptableObject
{
	public List<SpawnAnimalTableEntry> m_SpawnAnimalsList;

	private float m_TotalOdds;

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public AssetReferenceAnimalPrefab FindAnimalPrefab(string assetReferenceGUID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegionAnimalTableSO), Member = "FindAnimalPrefab")]
	public AssetReferenceAnimalPrefab PickSpawnAnimal(WildlifeMode mode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
