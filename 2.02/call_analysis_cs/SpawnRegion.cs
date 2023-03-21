using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using SWS;
using UnityEngine;

public class SpawnRegion : MonoBehaviour
{
	public GameObject m_SpawnablePrefab;

	public GameObject m_AuroraSpawnablePrefab;

	public bool m_CanSpawnInBlizzard;

	public bool m_OverrideDistanceToCamera;

	public bool m_OverrideCameraLineOfSight;

	public bool m_ForcePredatorOverride;

	public float m_ChanceActive;

	public float m_HoursReRollActive;

	public float m_Radius;

	[NonSerialized]
	public Vector3 m_Center;

	public float m_TopDownTerrainHeight;

	public float m_SpawnHeightCap;

	public WanderRegion m_WanderRegion;

	public int m_MaxSimultaneousSpawnsDayPilgrim;

	public int m_MaxSimultaneousSpawnsNightPilgrim;

	public float m_MaxRespawnsPerDayPilgrim;

	public int m_MaxSimultaneousSpawnsDayVoyageur;

	public int m_MaxSimultaneousSpawnsNightVoyageur;

	public float m_MaxRespawnsPerDayVoyageur;

	public int m_MaxSimultaneousSpawnsDayStalker;

	public int m_MaxSimultaneousSpawnsNightStalker;

	public float m_MaxRespawnsPerDayStalker;

	public int m_MaxSimultaneousSpawnsDayInterloper;

	public int m_MaxSimultaneousSpawnsNightInterloper;

	public float m_MaxRespawnsPerDayInterloper;

	public AiDifficulty m_AiDifficulty;

	public string m_PackGroupId;

	public AiType m_AiTypeSpawned;

	public bool m_ControlledByRandomSpawner;

	private WildlifeMode m_WildlifeMode;

	private List<BaseAi> m_Spawns;

	private int m_NumRespawnsPending;

	private float m_ElapasedHoursNextRespawnAllowed;

	private float m_ElapsedHoursAtLastActiveReRoll;

	private float m_NumHoursBetweenRespawns;

	private int m_NumTrapped;

	private float m_HoursNextTrapReset;

	private PathManager[] m_PathManagers;

	private Den m_Den;

	private int m_SpawnGuidCounter;

	private int m_CurrentWaypointPathIndex;

	private bool m_StartHasBeenCalled;

	private static SpawnRegionDataProxy m_SpawnRegionDataProxy;

	private const int SPAWN_DATA_POOL_LEN = 128;

	private static SpawnDataProxy[] m_SpawnDataProxyPool;

	private List<SpawnDataProxy> m_DeferredSpawnsWithRandomPosition;

	private List<SpawnDataProxy> m_DeferredSpawnsWithSavedPosition;

	private Queue<PendingSerializedRespawnInfo> m_PendingSerializedRespawnInfoQueue;

	private WildlifeMode m_DeferredSpawnWildlifeMode;

	private bool m_HasBeenDisabledByAurora;

	private bool m_WasActiveBeforeAurora;

	private AiSubType m_AiSubTypeSpawned;

	private WolfType m_WolfTypeSpawned;

	private const int MAX_SERIALIZED_RESPAWN_ATTEMPTS = 60;

	private int m_AutoCloneIndex;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxRespawnsPerDay")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 41)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	public void UpdateDeferredDeserializeFromManager()
	{
	}

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateFromManager()
	{
	}

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 48)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveFromSpawnRegion(BaseAi bai)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool CanTrap()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public void OnTrap()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeReRollActive()
	{
	}

	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "OnAuroraEnabled")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void OnAuroraEnabled(bool enabled)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public Vector3[] GetWaypointCircuit()
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldSleepInDenAfterWaypointLoop()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public float GetDenSleepDurationInHours()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public WanderRegion GetWanderRegion(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public GameObject GetClosestActiveSpawn(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetRandomWaypointCircuit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public bool HasWoundedWildlife()
	{
		return false;
	}

	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void SetActive(bool active)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanDoReRoll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public int GetNumActiveSpawns()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustOtherModePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private int GetCurrentActivePopulation(WildlifeMode wildlifeMode)
	{
		return 0;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool SpawnPositionOnScreenTooClose(Vector3 spawnPos)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasSerializedRespawnPending()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private BaseAi MaybeSpawnPendingSerializedRespawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AddActiveSpawns")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Respawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionTooCloseToCamera")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeSpawnPendingSerializedRespawn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	private bool Spawn(WildlifeMode wildlifeMode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasSameWildlifeMode(BaseAi baseAi, WildlifeMode wildlifeMode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	private void AddActiveSpawns(int numToActivate, WildlifeMode wildlifeMode)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustOtherModePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 53)]
	private void RemoveActiveSpawns(int numToDeActivate, WildlifeMode wildlifeMode, bool isAdjustingOtherWildlifeMode)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AddActiveSpawns")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool SpawnRegionCloseEnoughForSpawning()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Respawn(WildlifeMode wildlifeMode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool RespawnAllowed()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawningSupppressedByExperienceMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private int CalculateTargetPopulation()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	private void AdjustOtherModePopulation()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void AdjustActiveSpawnRegionPopulation()
	{
	}

	[CalledBy(Type = typeof(CarcassSite.Manager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "InstantiateBodyHarvestGameObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(char), Member = "IsNumber")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetPrefabNameFromInstanceName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private BaseAi InstantiateSpawnInternal(WildlifeMode wildlifetype, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpawnRegionParent")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private BaseAi InstantiateSpawnFromSaveData(SpawnDataProxy spawnData, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnInternal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 20)]
	private BaseAi InstantiateSpawn(Vector3 spawnPos, Quaternion spawnRotation, AiMode mode, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideNoSpawnRegion")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionTooCloseToCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool PositionValidForSpawn(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	private bool TryGetSpawnPositionAndRotation(ref Vector3 spawnPos, ref Quaternion spawnRotation)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private BaseAi InstantiateAndPlaceSpawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogWarning(string output)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void Log(string output)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeSpawnPendingSerializedRespawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private BaseAi AttemptInstantiateAndPlaceSpawnFromSave(WildlifeMode wildlifeMode, PendingSerializedRespawnInfo pendingSerializedRespawnInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private bool SpawnPositionTooCloseToCamera(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void QueueSerializedRespawnPending(SpawnDataProxy saveData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SpawnWithSavedPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SpawnWithRandomPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	private bool CanDoReRoll()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeReduceNumTrapped()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private bool SpawningSupppressedByExperienceMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void SetBoundingSphereBasedOnWaypoints(int waypointIndex)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "CanTrap")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxSpawnsDay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private int GetMaxSimultaneousSpawnsDay()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "CanTrap")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxSpawnsNight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private int GetMaxSimultaneousSpawnsNight()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Respawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReduceNumTrapped")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetRespawnHoursScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private float GetNumHoursBetweenRespawns()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserializeFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanDoReRoll")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool HasDeferredDeserializeCompleted()
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserializeFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateDeferredDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsPredator()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSuspendForAurora()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeResumeAfterAurora()
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private float GetCustomModeMaxRespawnsPerDay()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private int GetCustomModeMaxSpawnsDay()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private int GetCustomModeMaxSpawnsNight()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 45)]
	private float GetCustomSpawnRegionChanceActiveScale()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 28)]
	public SpawnRegion()
	{
	}
}
