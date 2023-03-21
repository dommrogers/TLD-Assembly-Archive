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

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetLargestBoundsRenderer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsLastEncounter()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void EncounterWon()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallsUnknownMethods(Count = 10)]
	public void EncounterFailed(BearSpawnEncounterResult result)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void SelectInvestigatePosition()
	{
	}

	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRefreshSpawnedBearAiAfterLoad()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	private void UpdateBearSpawn()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "CanDespawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	private void UpdateBearDespawn()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "FindHuntBear")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetSpawnBearTimer()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public void Activate(bool enableInteraction)
	{
	}

	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InstantiateBear(Vector3 position)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearSpawn")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BearSpawnEncounterResult GetLatestEncounterResult()
	{
		return default(BearSpawnEncounterResult);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[CalledBy(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	private void RefreshSpawnedBearSettings(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void UpdateSpawnedBear(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeSpawnedBearData(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SerializeAll")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CallerCount(Count = 2)]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BearEncounter), Member = "Deserialize")]
	[Calls(Type = typeof(BearEncounter), Member = "FindByGuid")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string text)
	{
	}

	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private bool AttemptFindingValidInvestigateLocation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	public static BearEncounter FindByGuid(string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallsUnknownMethods(Count = 4)]
	public static int GetCurrentActiveBearEncounterCountInScene()
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallsUnknownMethods(Count = 4)]
	public static BearEncounter GetCurrentActiveBearEncounter()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BearEncounter()
	{
	}
}
