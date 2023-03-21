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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasStartBeenCalled()
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetSplineBoundingRadius")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "DisableSplineMeshUpdating")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RollRandomNumToSpawn")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
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
		return false;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetUnlockedForDetailMap")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 50)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetPendingSpawns")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool Deserialize(string text)
	{
		return false;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveFromSpawns(GameObject go)
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void ReleaseSpawnedObjectsToPool()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public bool ShouldDisable()
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPotentiallySpawn()
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldAttemptSpawning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasChildren()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool ShouldDisableDueToInvalidPosition()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasSpawned()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int NumToSpawn()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptOnceWithVisCheck")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetRepawnTime")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 18)]
	private GameObject SpawnPending(int index)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTable), Member = "GetRandomGearPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private GameObject GetNextPrefabToSpawn()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private GameObject SpawnAtPosition(GameObject prefabToSpawn, Vector3 posToSpawn, Quaternion orientToSpawn)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetRadialRespawnTimeScale")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void SetRepawnTime(GameObject spawnedObj)
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void SetPendingSpawns(string[] prefabNames, Vector3[] positions, Quaternion[] rotations, bool[] detailMapUnlockStates)
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetPendingSpawns")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void CreatePendingSpawn(string prefabName, Vector3 pos, Quaternion rot, bool unlockedForDetailMap)
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DisableSplineMeshUpdating()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetObjectToSpawnBoundingRadius()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void SetSplineBoundingRadius()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private float GetDistanceFromOuterRadiusToCamera()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetFullObjectName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void RollRandomNumToSpawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetUnlockedForDetailMap(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetUnlockedForDetailMap(GameObject go, bool unlocked)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public RadialObjectSpawner()
	{
	}
}
