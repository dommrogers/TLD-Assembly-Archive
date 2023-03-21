using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RadialObjectSpawner : MonoBehaviour
{
	public const int MAX_INVALID_SPAWNS_BEFORE_DISABLE = 60;

	public GameObject m_ObjectToSpawn;

	public float m_MinRadius;

	public float m_MaxRadius;

	public int m_MinToSpawn;

	public int m_MaxToSpawn;

	public float m_MinRespawnTimeGameHours;

	public float m_MaxRespawnTimeGameHours;

	public bool m_AllowIndoorSpawn;

	public float m_FloatHeight;

	public bool m_AddRandomXRotation;

	public Vector3 m_RaycastOffset;

	public LootTable m_LootTable;

	public Spline m_Spline;

	public bool m_InRadialSpawnManagerActiveList;

	private float m_GameHourTimeToRespawn;

	private int m_NumToSpawn;

	private bool m_StartHasBeenCalled;

	private bool m_HasSpawned;

	private GameObject m_NextPrefabToSpawn;

	private float m_ObjectToSpawnBoundingRadius;

	private int m_NumSpawnAttemptsWithInvalidPositions;

	private List<PendingSpawnData> m_PendingSpawns;

	private List<GameObject> m_Spawns;

	private static RadialObjectSpawnerSaveData m_RadialObjectSpawnerSaveData;

	private static List<Vector3> m_PositionsList;

	private static List<Quaternion> m_RotationsList;

	private static List<string> m_PrefabNamesList;

	private static List<bool> m_UnlockedForDetailMapList;

	private const float MAX_ACTIVATION_RANGE_FROM_OUTER_RADIUS = 120f;

	private const float MIN_DIST_SPAWN_ONSCREEN = 100f;

	private const float MIN_DIST_SPAWN_OFFSCREEN = 50f;

	private const float MIN_DIST_SPAWN_ONSCREEN_SMALL_OBJECTS = 50f;

	private const int NUM_SPLINE_POINTS_TO_COMPUTE_BOUNDING_RADIUS = 4;

	private Vector3[] m_SplineSamplePoints;

	private float m_SplineBoundingRadius;

	private Vector3 m_SplineCenter;

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasStartBeenCalled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetSplineBoundingRadius")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "DisableSplineMeshUpdating")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RollRandomNumToSpawn")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	public void SpawnAttemptAllNoVisChecks()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	public bool SpawnAttemptOnceWithVisCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetUnlockedForDetailMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 50)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetPendingSpawns")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool Deserialize(string text)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveFromSpawns(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void ReleaseSpawnedObjectsToPool()
	{
	}

	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CallsUnknownMethods(Count = 9)]
	public bool ShouldDisable()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool CanPotentiallySpawn()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool ShouldAttemptSpawning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasChildren()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool ShouldDisableDueToInvalidPosition()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasSpawned()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int NumToSpawn()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetRepawnTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptOnceWithVisCheck")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject SpawnPending(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private GameObject GetNextPrefabToSpawn()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	private GameObject SpawnAtPosition(GameObject prefabToSpawn, Vector3 posToSpawn, Quaternion orientToSpawn)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetRadialRespawnTimeScale")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallsUnknownMethods(Count = 8)]
	private void SetRepawnTime(GameObject spawnedObj)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 10)]
	private void SetPendingSpawns(string[] prefabNames, Vector3[] positions, Quaternion[] rotations, bool[] detailMapUnlockStates)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetPendingSpawns")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void CreatePendingSpawn(string prefabName, Vector3 pos, Quaternion rot, bool unlockedForDetailMap)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	private void DisableSplineMeshUpdating()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	private void SetObjectToSpawnBoundingRadius()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	private void SetSplineBoundingRadius()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private float GetDistanceFromOuterRadiusToCamera()
	{
		return default(float);
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 16)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetFullObjectName")]
	private void RollRandomNumToSpawn()
	{
	}

	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	[CallsUnknownMethods(Count = 2)]
	private bool GetUnlockedForDetailMap(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private void SetUnlockedForDetailMap(GameObject go, bool unlocked)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RadialObjectSpawner()
	{
	}
}
