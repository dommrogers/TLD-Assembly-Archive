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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetSplineBoundingRadius")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
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

	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetUnlockedForDetailMap")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "Start")]
	public bool Deserialize(string text)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "PickUpCookedGearItem")]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveFromSpawns(GameObject go)
	{
	}

	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public void ReleaseSpawnedObjectsToPool()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "UpdateRadialSpawnObjectsActiveList")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldDisable()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool CanPotentiallySpawn()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "DoFirstUpdateForAllRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialSpawnManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
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

	[DeduplicatedMethod]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	public string PerformSceneValidationTest()
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialSpawnManager), Member = "ProcessActiveRadialSpawnObjects")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptOnceWithVisCheck")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnAttemptAllNoVisChecks")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SetRepawnTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnPending")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "GetNextPrefabToSpawn")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "SpawnAtPosition")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	private GameObject SpawnPending(int index)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LootTableData), Member = "GetRandomGearItemPrefab")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CallsUnknownMethods(Count = 1)]
	private GameObject GetNextPrefabToSpawn()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(RadialSpawnManager), Member = "TakeFromObjectPool")]
	[CallerCount(Count = 1)]
	private GameObject SpawnAtPosition(GameObject prefabToSpawn, Vector3 posToSpawn, Quaternion orientToSpawn)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetRepawnTime(GameObject spawnedObj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "CreatePendingSpawn")]
	[CallsUnknownMethods(Count = 2)]
	private void SetPendingSpawns(string[] prefabNames, Vector3[] positions, Quaternion[] rotations, bool[] detailMapUnlockStates)
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetPendingSpawns")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Deserialize")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ReleaseSpawnedObjectsToPool")]
	[CallsUnknownMethods(Count = 2)]
	private void CreatePendingSpawn(string prefabName, Vector3 pos, Quaternion rot, bool unlockedForDetailMap)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisableSplineMeshUpdating()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldDisable")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ShouldAttemptSpawning")]
	[CallsUnknownMethods(Count = 3)]
	private float GetDistanceFromOuterRadiusToCamera()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void RollRandomNumToSpawn()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool GetUnlockedForDetailMap(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetUnlockedForDetailMap(GameObject go, bool unlocked)
	{
	}

	[ContextMenu("Migrate Loot Tables", true)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public RadialObjectSpawner()
	{
	}
}
