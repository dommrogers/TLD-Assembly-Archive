using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

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

	private static List<AsyncOperationHandle<GameObject>> m_OperationHandles;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InitObjectPools")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Register(RadialObjectSpawner ros)
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Awake")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void Unregister(RadialObjectSpawner ros)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CanPotentiallySpawn")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	public string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InitObjectPools")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByGuid")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "FindRadialObjectSpawnerByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiatePrefabForObjectPool")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeAllocateForObjectPool(GameObject prefab)
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private RadialObjectSpawner FindRadialObjectSpawnerByPosition(RadialObjectSpawnerSaveData proxy, RadialObjectSpawner[] spawners)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	private RadialObjectSpawner FindRadialObjectSpawnerByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CanPotentiallySpawn")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void DoFirstUpdateForAllRadialSpawnObjects()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateRadialSpawnObjectsActiveList()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessActiveRadialSpawnObjects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetRadialSpawnerList()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Start")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public static void InitObjectPools()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	private static int GetCountInObjectPool(string prefabName)
	{
		return 0;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Stack<>), Member = "Pop")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public static GameObject TakeFromObjectPool(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ForceRefreshSpawnedItems")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool ReturnToObjectPool(GameObject go)
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiatePrefabForObjectPool")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Stack<>), Member = "Push")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private static void AddToPools(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "InstantiatePrefabForObjectPool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void InstantiateForObjectPool(AssetReferenceGearItem assetReference, int count)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[CallerCount(Count = 2)]
	public static void InstantiateForObjectPool(string prefabName, int count)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "MaybeAllocateForObjectPool")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "InstantiateForObjectPool")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "AddToPools")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private static void InstantiatePrefabForObjectPool(GameObject prefab, int count)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static GameObject GetPrefabFromAssetReference(AssetReferenceGearItem assetReference)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[CallsUnknownMethods(Count = 2)]
	private static GameObject GetPrefabFromName(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RadialSpawnManager()
	{
	}
}
