using System;
using System.Collections.Generic;
using System.Diagnostics;
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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxRespawnsPerDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Start()
	{
	}

	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	[CallerCount(Count = 0)]
	public void UpdateDeferredDeserializeFromManager()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	public void UpdateFromManager()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[Calls(Type = typeof(SpawnRegion), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void RemoveFromSpawnRegion(BaseAi bai)
	{
	}

	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool CanTrap()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void OnTrap()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	public void MaybeReRollActive()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "OnAuroraEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	public void OnAuroraEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CallsUnknownMethods(Count = 15)]
	public Vector3[] GetWaypointCircuit()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	public bool ShouldSleepInDenAfterWaypointLoop()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetDenSleepDurationInHours()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeWander")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	public WanderRegion GetWanderRegion(Vector3 pos)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public GameObject GetClosestActiveSpawn(Vector3 pos)
	{
		return null;
	}

	[Calls(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	public void SetRandomWaypointCircuit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HasWoundedWildlife()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 10)]
	public void SetActive(bool active)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanDoReRoll")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public int GetNumActiveSpawns()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustOtherModePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	private int GetCurrentActivePopulation(WildlifeMode wildlifeMode)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	private bool SpawnPositionOnScreenTooClose(Vector3 spawnPos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool HasSerializedRespawnPending()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	private BaseAi MaybeSpawnPendingSerializedRespawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionTooCloseToCamera")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeSpawnPendingSerializedRespawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AddActiveSpawns")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Respawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private bool Spawn(WildlifeMode wildlifeMode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool HasSameWildlifeMode(BaseAi baseAi, WildlifeMode wildlifeMode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	private void AddActiveSpawns(int numToActivate, WildlifeMode wildlifeMode)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustOtherModePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private void RemoveActiveSpawns(int numToDeActivate, WildlifeMode wildlifeMode, bool isAdjustingOtherWildlifeMode)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AddActiveSpawns")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	private bool SpawnRegionCloseEnoughForSpawning()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CallsUnknownMethods(Count = 3)]
	private void Respawn(WildlifeMode wildlifeMode)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool RespawnAllowed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawningSupppressedByExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	private int CalculateTargetPopulation()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	private void AdjustOtherModePopulation()
	{
	}

	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[Calls(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	private void AdjustActiveSpawnRegionPopulation()
	{
	}

	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "InstantiateBodyHarvestGameObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CarcassSite.Manager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static string GetPrefabNameFromInstanceName(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	private BaseAi InstantiateSpawnInternal(WildlifeMode wildlifetype, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnInternal")]
	[Calls(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpawnRegionParent")]
	private BaseAi InstantiateSpawnFromSaveData(SpawnDataProxy spawnData, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "GenerateNewGuidString")]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnInternal")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	private BaseAi InstantiateSpawn(Vector3 spawnPos, Quaternion spawnRotation, AiMode mode, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionTooCloseToCamera")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideNoSpawnRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	private bool PositionValidForSpawn(Vector3 pos)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private bool TryGetSpawnPositionAndRotation(ref Vector3 spawnPos, ref Quaternion spawnRotation)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	private BaseAi InstantiateAndPlaceSpawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void LogWarning(string output)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	private static void Log(string output)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeSpawnPendingSerializedRespawn")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	private BaseAi AttemptInstantiateAndPlaceSpawnFromSave(WildlifeMode wildlifeMode, PendingSerializedRespawnInfo pendingSerializedRespawnInfo)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private bool SpawnPositionTooCloseToCamera(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	private void QueueSerializedRespawnPending(SpawnDataProxy saveData)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallerCount(Count = 0)]
	private void SpawnWithSavedPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SpawnWithRandomPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "HasDeferredDeserializeCompleted")]
	private bool CanDoReRoll()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallerCount(Count = 0)]
	private void MaybeReduceNumTrapped()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsUnknownMethods(Count = 9)]
	private bool SpawningSupppressedByExperienceMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void SetBoundingSphereBasedOnWaypoints(int waypointIndex)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanTrap")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxSpawnsDay")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	private int GetMaxSimultaneousSpawnsDay()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanTrap")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxSpawnsNight")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CallsUnknownMethods(Count = 8)]
	private int GetMaxSimultaneousSpawnsNight()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Respawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReduceNumTrapped")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetRespawnHoursScale")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetNumHoursBetweenRespawns()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserializeFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanDoReRoll")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private bool HasDeferredDeserializeCompleted()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserializeFromManager")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateDeferredDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsPredator()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void MaybeSuspendForAurora()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeResumeAfterAurora()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	private float GetCustomModeMaxRespawnsPerDay()
	{
		return default(float);
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 1)]
	private int GetCustomModeMaxSpawnsDay()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private int GetCustomModeMaxSpawnsNight()
	{
		return default(int);
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetCustomSpawnRegionChanceActiveScale()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	public SpawnRegion()
	{
	}
}
