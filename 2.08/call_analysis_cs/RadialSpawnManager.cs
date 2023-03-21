using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class RadialSpawnManager : MonoBehaviour
{
	private const int NUM_PROCESS_PER_FRAME = 5;

	private const int MAX_OBJECT_POOL_SIZE_PER_PREFAB = 128;

	private const int MAX_OBJECT_POOL_SIZE_PER_UNCOMMON_PREFAB = 32;

	public static bool m_Debug;

	private static List<RadialObjectSpawner> m_RadialSpawnObjects;

	private static List<RadialObjectSpawner> m_ActiveRadialSpawnObjects;

	private bool m_DoneFirstUpdate;

	private bool m_StartHasBeenCalled;

	private int m_CurrentIndex;

	private static readonly List<RadialObjectSpawner> m_RadialSpawnObjectsToSerialize;

	private static Dictionary<string, Stack<GameObject>> m_ObjectPoolDict;

	private static List<GameObject> m_AddressablePrefabs;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InitObjectPools")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Register(RadialObjectSpawner ros)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "OnDestroy")]
	public static void Unregister(RadialObjectSpawner ros)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CanPotentiallySpawn")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	public string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByPosition")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InitObjectPools")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByGuid")]
	public void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeAllocateForObjectPool(GameObject prefab)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 4)]
	private RadialObjectSpawner FindRadialObjectSpawnerByPosition(RadialObjectSpawnerSaveData proxy, RadialObjectSpawner[] spawners)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private RadialObjectSpawner FindRadialObjectSpawnerByGuid(string guid)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CanPotentiallySpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	private void DoFirstUpdateForAllRadialSpawnObjects()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	private void UpdateRadialSpawnObjectsActiveList()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessActiveRadialSpawnObjects()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void ResetRadialSpawnerList()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Start")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	public static void InitObjectPools()
	{
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[CallsUnknownMethods(Count = 7)]
	public static GameObject TakeFromObjectPool(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	public static bool ReturnToObjectPool(GameObject go)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void InstantiateForObjectPool(GameObject prefab, int numToInstantiate)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private static void InstantiateForObjectPool(string prefabName, int count)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static int GetCountInObjectPool(string prefabName)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private static GameObject InstantiateFromPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	private static GameObject InstantiateFromPrefabName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CallsUnknownMethods(Count = 8)]
	private static void AddToPools(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RadialSpawnManager()
	{
	}
}
