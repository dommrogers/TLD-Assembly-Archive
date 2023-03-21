using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
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

	private PanelReference<Panel_Loading> m_Loading;

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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetLastEncounter(bool isLastEncounter)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void SetPostStruggleBehavior(PostStruggleBehavior postStruggleBehavior)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PostStruggleBehavior GetPostStruggleBehavior()
	{
		return default(PostStruggleBehavior);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsLastEncounter()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public void EncounterWon()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 10)]
	public void EncounterFailed(BearSpawnEncounterResult result)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void SelectInvestigatePosition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	private void MaybeRefreshSpawnedBearAiAfterLoad()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[CallerCount(Count = 0)]
	private void UpdateBearSpawn()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "CanDespawn")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateBearDespawn()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[Calls(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "RetrieveSpawnedBear")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetSpawnBearTimer()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Activate(bool enableInteraction)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	private void InstantiateBear(Vector3 position)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
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

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public BearSpawnEncounterResult GetLatestEncounterResult()
	{
		return default(BearSpawnEncounterResult);
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	private void RefreshSpawnedBearSettings(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSpawnedBear(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InitializeSpawnedBearData(GameObject go)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SerializeAll")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 1)]
	public string GetMissionObjectId()
	{
		return null;
	}

	[Calls(Type = typeof(BearEncounter), Member = "Serialize")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeAll()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "FindByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CallsUnknownMethods(Count = 10)]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private bool AttemptFindingValidInvestigateLocation()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static BearEncounter FindByGuid(string guid)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	public static int GetCurrentActiveBearEncounterCountInScene()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	public static BearEncounter GetCurrentActiveBearEncounter()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BearEncounter()
	{
	}
}
