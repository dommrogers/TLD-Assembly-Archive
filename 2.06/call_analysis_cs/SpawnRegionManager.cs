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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpawnRegion), Member = "Serialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetObjectGuidFromGO")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 20)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "FindSpawnRegionByPosition")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Add(SpawnRegion sr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Remove(SpawnRegion sr)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Add(NoSpawnRegion nsr)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "SpawnPredator")]
	[CalledBy(Type = typeof(Rest), Member = "CanSpawnPredator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideSpawnRegion")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Rest), Member = "CanSpawnPredator")]
	public GameObject GetClosestActiveSpawn(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	public SpawnRegion PointInsideSpawnRegion(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetSpawnablePrefabName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public SpawnRegion PointInsideActiveSpawnRegion(Vector3 pos, string filterSpawnablePrefabName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CalledBy(Type = typeof(Rest), Member = "ShouldInterruptWithPredator")]
	[CallsUnknownMethods(Count = 5)]
	public bool PointInsideNoSpawnRegion(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static SpawnRegion FindSpawnRegionByPosition(SpawnRegionSaveData saveData)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static SpawnRegion FindSpawnRegionByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public SpawnRegionManager()
	{
	}
}
