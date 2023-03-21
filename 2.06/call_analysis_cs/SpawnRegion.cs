using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using SWS;
using TLD;
using TLD.Serialization;
using UnityEngine;

public class SpawnRegion : MonoBehaviour
{
	public GameObject m_SpawnablePrefab;

	public GameObject m_AuroraSpawnablePrefab;

	public SpawnRegionAnimalTableSO m_SpawnRegionAnimalTableSO;

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

	private List<AssetReferenceAnimalPrefab> m_SpawnsPrefabReferences;

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

	private string m_SpawnablePrefabName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomSpawnRegionChanceActiveScale")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxRespawnsPerDay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Start()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "PointInsideActiveSpawnRegion")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "PointInsideSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	public string GetSpawnablePrefabName()
	{
		return null;
	}

	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UpdateDeferredDeserializeFromManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateFromManager()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[Calls(Type = typeof(SpawnRegion), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void RemoveFromSpawnRegion(BaseAi bai)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanTrap()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public void OnTrap()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpawnRegionChanceActiveScale")]
	public void MaybeReRollActive()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(AuroraManager), Member = "UpdateActivation")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "OnAuroraEnabled")]
	[CallsUnknownMethods(Count = 7)]
	public void OnAuroraEnabled(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoEnterFollowWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public Vector3[] GetWaypointCircuit()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	public bool ShouldSleepInDenAfterWaypointLoop()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDenSleepDurationInHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public WanderRegion GetWanderRegion(Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "GetClosestActiveSpawn")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GameObject GetClosestActiveSpawn(Vector3 pos)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "SetBoundingSphereBasedOnWaypoints")]
	[CalledBy(Type = typeof(BaseAi), Member = "HandleLastWaypoint")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	public void SetRandomWaypointCircuit()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasWoundedWildlife()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "DisableAll")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	[CalledBy(Type = typeof(WolfDen), Member = "OnStartFireComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(WolfDen), Member = "SetDenEnabled")]
	public void SetActive(bool active)
	{
	}

	[CalledBy(Type = typeof(RandomSpawnObject), Member = "MaybeReroll")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanDoReRoll")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReRollActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public int GetNumActiveSpawns()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustOtherModePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	private int GetCurrentActivePopulation(WildlifeMode wildlifeMode)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[CallerCount(Count = 2)]
	private bool SpawnPositionOnScreenTooClose(Vector3 spawnPos)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasSerializedRespawnPending()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private BaseAi MaybeSpawnPendingSerializedRespawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Respawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AddActiveSpawns")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "MaybeSpawnPendingSerializedRespawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionTooCloseToCamera")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	private bool Spawn(WildlifeMode wildlifeMode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasSameWildlifeMode(BaseAi baseAi, WildlifeMode wildlifeMode)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	private void AddActiveSpawns(int numToActivate, WildlifeMode wildlifeMode)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustOtherModePopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "OnAuroraEnabled")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	private void RemoveActiveSpawns(int numToDeActivate, WildlifeMode wildlifeMode, bool isAdjustingOtherWildlifeMode)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AddActiveSpawns")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	private bool SpawnRegionCloseEnoughForSpawning()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsUnknownMethods(Count = 2)]
	private void Respawn(WildlifeMode wildlifeMode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool RespawnAllowed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(Weather), Member = "IsBlizzard")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawningSupppressedByExperienceMode")]
	[CallerCount(Count = 1)]
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

	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[Calls(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[Calls(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCurrentActivePopulation")]
	[CallsUnknownMethods(Count = 2)]
	private void AdjustActiveSpawnRegionPopulation()
	{
	}

	[CalledBy(Type = typeof(CarcassSite.Manager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(BodyHarvestManager), Member = "InstantiateBodyHarvestGameObject")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetPrefabNameFromInstanceName(string name)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private BaseAi InstantiateSpawnInternal(GameObject spawnablePrefab, WildlifeMode wildlifetype, Vector3 pos, Quaternion rotation)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "SetSpawnRegionParent")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnInternal")]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "FindAnimalPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiUtils), Member = "IsNavmeshPosValid")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private BaseAi InstantiateSpawnFromSaveData(SpawnDataProxy spawnData, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Calls(Type = typeof(AiDifficultySettings), Member = "GetSetting")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnInternal")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 2)]
	private BaseAi InstantiateSpawn(GameObject spawnablePrefab, AssetReferenceAnimalPrefab animalReferencePrefab, Vector3 spawnPos, Quaternion spawnRotation, AiMode mode, WildlifeMode wildlifeMode)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "AttemptInstantiateAndPlaceSpawnFromSave")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionTooCloseToCamera")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "PointInsideNoSpawnRegion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	private bool PositionValidForSpawn(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateAndPlaceSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "GetRandomSpawnAreaMarkupGivenSpawnRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool TryGetSpawnPositionAndRotation(ref Vector3 spawnPos, ref Quaternion spawnRotation)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "TryGetSpawnPositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegionAnimalTableSO), Member = "PickSpawnAnimal")]
	private BaseAi InstantiateAndPlaceSpawn(WildlifeMode wildlifeMode)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void LogWarning(string output)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private static void Log(string output)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeSpawnPendingSerializedRespawn")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTeleportTransformAfterSceneLoad")]
	[Calls(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	private BaseAi AttemptInstantiateAndPlaceSpawnFromSave(WildlifeMode wildlifeMode, PendingSerializedRespawnInfo pendingSerializedRespawnInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "PositionValidForSpawn")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Spawn")]
	[CallsUnknownMethods(Count = 7)]
	private bool SpawnPositionTooCloseToCamera(Vector3 pos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	private void QueueSerializedRespawnPending(SpawnDataProxy saveData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void SpawnWithSavedPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	private void SpawnWithRandomPositions(List<SpawnDataProxy> spawns, WildlifeMode wildlifeMode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumActiveSpawns")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanDoReRoll()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpawnRegion), Member = "GetNumHoursBetweenRespawns")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeReduceNumTrapped()
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 1)]
	private bool SpawningSupppressedByExperienceMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SetRandomWaypointCircuit")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BoundingSphereFromPoints), Member = "Calculate")]
	private void SetBoundingSphereBasedOnWaypoints(int waypointIndex)
	{
	}

	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnWithSavedPositions")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanTrap")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxSpawnsDay")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	private int GetMaxSimultaneousSpawnsDay()
	{
		return default(int);
	}

	[Calls(Type = typeof(SpawnRegion), Member = "GetCustomModeMaxSpawnsNight")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnareItem), Member = "DoRoll")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CalculateTargetPopulation")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "CanTrap")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	private int GetMaxSimultaneousSpawnsNight()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "MaybeReduceNumTrapped")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Respawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "AdjustActiveSpawnRegionPopulation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceMode")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateFromManager")]
	private float GetNumHoursBetweenRespawns()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasDeferredDeserializeCompleted()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SpawnRegionManager), Member = "Update")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "UpdateDeferredDeserializeFromManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SpawnRegion), Member = "SpawnWithRandomPositions")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpawnRegion), Member = "QueueSerializedRespawnPending")]
	private void UpdateDeferredDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	private bool IsPredator()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void MaybeSuspendForAurora()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeResumeAfterAurora()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	private float GetCustomModeMaxRespawnsPerDay()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsDay")]
	[CallsUnknownMethods(Count = 1)]
	private int GetCustomModeMaxSpawnsDay()
	{
		return default(int);
	}

	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "GetMaxSimultaneousSpawnsNight")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	private int GetCustomModeMaxSpawnsNight()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetSpecificExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private float GetCustomSpawnRegionChanceActiveScale()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 26)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public SpawnRegion()
	{
	}
}
