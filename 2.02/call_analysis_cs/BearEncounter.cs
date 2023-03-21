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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetLastEncounter(bool isLastEncounter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void SetPostStruggleBehavior(PostStruggleBehavior postStruggleBehavior)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(PostStruggleBehavior);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLastEncounter()
	{
		return false;
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void EncounterWon()
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void EncounterFailed(BearSpawnEncounterResult result)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void SelectInvestigatePosition()
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRefreshSpawnedBearAiAfterLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateBearSpawn()
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "CanDespawn")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 22)]
	private void UpdateBearDespawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindHuntBear")]
	[Calls(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[Calls(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ResetSpawnBearTimer()
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void Activate(bool enableInteraction)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void InstantiateBear(Vector3 position)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void SpawnBear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEncounterActivated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool HasWonLatestEncounter()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BearSpawnEncounterResult GetLatestEncounterResult()
	{
		return default(BearSpawnEncounterResult);
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[CalledBy(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshSpawnedBearSettings(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSpawnedBear(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeSpawnedBearData(GameObject go)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BearEncounter), Member = "FindByGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClear")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private bool AttemptFindingValidInvestigateLocation()
	{
		return false;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static BearEncounter FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static int GetCurrentActiveBearEncounterCountInScene()
	{
		return 0;
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static BearEncounter GetCurrentActiveBearEncounter()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BearEncounter()
	{
	}
}
