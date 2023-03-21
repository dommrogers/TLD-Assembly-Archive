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

	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InitObjectPools")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Register(RadialObjectSpawner ros)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallsUnknownMethods(Count = 1)]
	public static void Unregister(RadialObjectSpawner ros)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	public string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByPosition")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InitObjectPools")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByGuid")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	private RadialObjectSpawner FindRadialObjectSpawnerByGuid(string guid)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CanPotentiallySpawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	private void DoFirstUpdateForAllRadialSpawnObjects()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	private void UpdateRadialSpawnObjectsActiveList()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	private void ProcessActiveRadialSpawnObjects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetRadialSpawnerList()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void InitObjectPools()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	public static GameObject TakeFromObjectPool(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearManager), Member = "DestroyGearObject")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static bool ReturnToObjectPool(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	public static void InstantiateForObjectPool(GameObject prefab, int numToInstantiate)
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
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
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private static GameObject InstantiateFromPrefab(GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private static GameObject InstantiateFromPrefabName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	private static void AddToPools(GameObject go)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RadialSpawnManager()
	{
	}
}
