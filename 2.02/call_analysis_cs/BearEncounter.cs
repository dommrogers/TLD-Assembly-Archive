using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearEncounter : MonoBehaviour
{
	public enum BearSpawnState
	{
		None,
		RequestBearSpawn,
		BearSpawned,
		BearDespawned
	}

	public enum BearSpawnEncounterResult
	{
		None,
		Won,
		Failed,
		Abandoned
	}

	public enum PostStruggleBehavior
	{
		FleeToMaxRangeThenDespawn,
		FleeToDistanceWanderAround
	}

	public float m_DelaySpawnSeconds;

	public GameObject m_BearPrefab;

	public GameObject m_BearStart;

	public bool m_BearStartForceLocation;

	public GameObject m_BearFleeDestination;

	public float m_MinRadius;

	public float m_MaxRadius;

	public float m_FloatHeight;

	public BearHuntReduxSettings m_BearHuntReduxSettings;

	private GearItem m_HangingItem;

	private float m_CurrentTimerSpawnSeconds;

	private BearSpawnState m_BearSpawnState;

	private bool m_StartHasBeenCalled;

	private BaseAi m_BearBaseAi;

	private int m_NumSpawnAttemptsWithInvalidPositions;

	private float m_ObjectToSpawnBoundingRadius;

	private Vector3 m_InvestigatePosition;

	private bool m_IsEncounterEnabled;

	private bool m_HasSelectedInvestigatePosition;

	private float m_RandomAngleStart;

	private int m_CurrentAttemptFindLocationIndex;

	public static List<BearEncounter> s_BearEncounters;

	private static bool s_FindBearRequested;

	private static BearEncounterSaveData s_BearEncounterSaveData;

	private bool m_RefreshSpawnedBearAiAfterLoadRequested;

	private PlayerControlMode m_RestoreControlMode;

	private BearSpawnEncounterResult m_LatestEncounterResult;

	private bool m_LastEncounter;

	private PostStruggleBehavior m_PostStruggleBehavior;

	private MissionObjectIdentifier m_MissionObjectIdentifier;

	private const float MIN_DIST_SPAWN_ONSCREEN = 90f;

	private const float MIN_DIST_SPAWN_OFFSCREEN = 30f;

	private const int MAX_INVALID_SPAWNS = 100;

	private const float MIN_SPAWN_RADIUS = 2f;

	private const float RADIUS_FOR_ENCOUNTER_INVESTIGATE = 5f;

	private const int MAX_STEPS_AROUND_PLACEPOINT = 5;

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetLastEncounter(bool isLastEncounter)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetPostStruggleBehavior(PostStruggleBehavior postStruggleBehavior)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(PostStruggleBehavior);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLastEncounter()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EncounterWon()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public void EncounterFailed(BearSpawnEncounterResult result)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SelectInvestigatePosition()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	private void MaybeRefreshSpawnedBearAiAfterLoad()
	{
	}

	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateBearSpawn()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "CanDespawn")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void UpdateBearDespawn()
	{
	}

	[Calls(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindHuntBear")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetSpawnBearTimer()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Activate(bool enableInteraction)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	private void InstantiateBear(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SpawnBear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEncounterActivated()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool HasWonLatestEncounter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BearSpawnEncounterResult GetLatestEncounterResult()
	{
		return default(BearSpawnEncounterResult);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[CalledBy(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void RefreshSpawnedBearSettings(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateSpawnedBear(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[CalledBy(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void InitializeSpawnedBearData(GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SerializeAll")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public string GetMissionObjectId()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BearEncounter), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BearEncounter), Member = "FindByGuid")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool AttemptFindingValidInvestigateLocation()
	{
		return default(bool);
	}

	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static BearEncounter FindByGuid(string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	public static int GetCurrentActiveBearEncounterCountInScene()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static BearEncounter GetCurrentActiveBearEncounter()
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BearEncounter()
	{
	}
}
