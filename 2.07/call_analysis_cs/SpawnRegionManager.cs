using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class SpawnRegionManager : MonoBehaviour
{
	public float m_NoPredatorSpawningInVoyageurHoursMin;

	public float m_NoPredatorSpawningInVoyageurHoursMax;

	public float m_RandomizeRestoredSpawnsAfterHoursInside;

	public float m_SpawnRegionDisableDistance;

	public float m_DisallowDespawnBelowDistance;

	public float m_ClosestSpawnDistanceToPlayer;

	public float m_ClosestSpawnDistanceToPlayerAfterSceneTransition;

	public float m_AllowSpawnOnscreenDistance;

	public float m_AllowDespawnOnscreenDistance;

	public List<SpawnRegion> m_SpawnRegions;

	public List<NoSpawnRegion> m_NoSpawnRegions;

	public static float m_NoPredatorSpawningInVoyageurHours;

	private int m_NextSpawnRegionIndexToUpdate;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnAuroraEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SpawnRegion), Member = "Serialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "FindSpawnRegionByPosition")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Add(SpawnRegion sr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(SpawnRegion sr)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Add(NoSpawnRegion nsr)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetClosestActiveSpawn")]
	[CalledBy(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CallsUnknownMethods(Count = 1)]
	public GameObject GetClosestActiveSpawn(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public SpawnRegion PointInsideSpawnRegion(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallsUnknownMethods(Count = 6)]
	public SpawnRegion PointInsideActiveSpawnRegion(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool PointInsideNoSpawnRegion(Vector3 pos)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 5)]
	private static SpawnRegion FindSpawnRegionByPosition(SpawnRegionSaveData saveData)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private static SpawnRegion FindSpawnRegionByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public SpawnRegionManager()
	{
	}
}
