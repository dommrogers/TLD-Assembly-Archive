using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
using TLD.Serialization;
using UnityEngine;

public class RadialObjectSpawner : MonoBehaviour
{
	private struct InvalidPositionTracker
	{
		public int m_NoNavMesh;

		public int m_MissedRayCast;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public static implicit operator int(InvalidPositionTracker tracker)
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		public static implicit operator InvalidPositionTracker(int value)
		{
			return default(InvalidPositionTracker);
		}
	}

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

	public LootTableData m_LootTableData;

	private LootTable m_LootTable;

	public Spline m_Spline;

	private bool _003CIsActive_003Ek__BackingField;

	private float m_GameHourTimeToRespawn;

	private int m_NumToSpawn;

	private bool m_StartHasBeenCalled;

	private bool m_HasSpawned;

	private GameObject m_NextPrefabToSpawn;

	private float m_ObjectToSpawnBoundingRadius;

	private InvalidPositionTracker m_NumSpawnAttemptsWithInvalidPositions;

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

	public bool IsActive
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "Unregister")]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public bool HasStartBeenCalled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetSplineBoundingRadius")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetUnlockedForDetailMap")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public bool Deserialize(string text)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromSpawns(GameObject go)
	{
	}

	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void ReleaseSpawnedObjectsToPool()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldDisable()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	public bool CanPotentiallySpawn()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallsUnknownMethods(Count = 3)]
	public bool ShouldAttemptSpawning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
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
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptOnceWithVisCheck")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetRepawnTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject SpawnPending(int index)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	private GameObject GetNextPrefabToSpawn()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private GameObject SpawnAtPosition(GameObject prefabToSpawn, Vector3 posToSpawn, Quaternion orientToSpawn)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallsUnknownMethods(Count = 4)]
	private void SetRepawnTime(GameObject spawnedObj)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void SetPendingSpawns(string[] prefabNames, Vector3[] positions, Quaternion[] rotations, bool[] detailMapUnlockStates)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetPendingSpawns")]
	[CallsUnknownMethods(Count = 2)]
	private void CreatePendingSpawn(string prefabName, Vector3 pos, Quaternion rot, bool unlockedForDetailMap)
	{
	}

	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisableSplineMeshUpdating()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetObjectToSpawnBoundingRadius()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Spline), Member = "RecalculateParameter")]
	[Calls(Type = typeof(Spline), Member = "GetPositionInternal")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	private void SetSplineBoundingRadius()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private float GetDistanceFromOuterRadiusToCamera()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RollRandomNumToSpawn()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool GetUnlockedForDetailMap(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void SetUnlockedForDetailMap(GameObject go, bool unlocked)
	{
	}

	[ContextMenu("Migrate Loot Tables", true)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public bool RequiresLootTableMigration()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[ContextMenu("Migrate Loot Tables")]
	[CallerCount(Count = 0)]
	public void PerformLootTableMigration()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 0)]
	public RadialObjectSpawner()
	{
	}
}
