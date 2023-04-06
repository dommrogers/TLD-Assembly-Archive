using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD;

public class SpawnRegionAnimalTableSO : ScriptableObject
{
	public List<SpawnAnimalTableEntry> m_SpawnAnimalsList;

	private float m_TotalOdds;

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public AssetReferenceAnimalPrefab FindAnimalPrefab(string assetReferenceGUID)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegionAnimalTableSO), Member = "FindAnimalPrefab")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AssetReferenceAnimalPrefab PickSpawnAnimal(WildlifeMode mode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
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
