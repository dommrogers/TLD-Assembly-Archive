using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RadialSpawnManager : MonoBehaviour
{
	private static Dictionary<string, List<GameObject>> m_ObjectPoolDict;

	public static bool m_Debug;

	private List<RadialObjectSpawner> m_RadialSpawnObjects;

	private List<RadialObjectSpawner> m_ActiveRadialSpawnObjects;

	private bool m_DoneFirstUpdate;

	private bool m_StartHasBeenCalled;

	private static int m_CurrentIndex;

	private static int m_NumProcessPerFrame;

	private static List<RadialObjectSpawner> m_RadialSpawnObjectsToSerialize;

	private const int MAX_OBJECT_POOL_SIZE_PER_PREFAB = 128;

	private const int MAX_OBJECT_POOL_SIZE_PER_UNCOMMON_PREFAB = 32;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void InitObjectPools()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	public static GameObject TakeFromObjectPool(string prefabName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	public static bool ReturnToObjectPool(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateFromPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public static void InstantiateForObjectPool(GameObject prefab, int numToInstantiate)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void InstantiateForObjectPool(string prefabName, int count)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static int GetCountInObjectPool(string prefabName)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject InstantiateFromPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	public static GameObject InstantiateFromPrefabName(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	private static void AddToPools(GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Register(RadialObjectSpawner ros)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "RemoveFromActiveRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void Unregister(RadialObjectSpawner ros)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	public string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByGuid")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void MaybeAllocateForObjectPool(GameObject prefab)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 8)]
	private RadialObjectSpawner FindRadialObjectSpawnerByPosition(RadialObjectSpawnerSaveData proxy, RadialObjectSpawner[] spawners)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private RadialObjectSpawner FindRadialObjectSpawnerByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToActiveRadialSpawnObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CanPotentiallySpawn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void DoFirstUpdateForAllRadialSpawnObjects()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToActiveRadialSpawnObjects")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "RemoveFromActiveRadialSpawnObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	private void UpdateRadialSpawnObjectsActiveList()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	private void ProcessActiveRadialSpawnObjects()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CallsUnknownMethods(Count = 2)]
	private void AddToActiveRadialSpawnObjects(RadialObjectSpawner ros)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RemoveFromActiveRadialSpawnObjects(RadialObjectSpawner ros)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public RadialSpawnManager()
	{
	}
}
