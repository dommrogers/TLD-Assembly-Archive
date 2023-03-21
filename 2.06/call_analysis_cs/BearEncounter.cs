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
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
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
		return false;
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void EncounterWon()
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void EncounterFailed(BearSpawnEncounterResult result)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BearEncounter), Member = "AttemptFindingValidInvestigateLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void SelectInvestigatePosition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeRefreshSpawnedBearAiAfterLoad()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateBearSpawn()
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntAiRedux), Member = "CanDespawn")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BearHuntRedux), Member = "OnBearSpearOutcome")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateBearDespawn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(BearHuntRedux), Member = "RetrieveSpawnedBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "RefreshSpawnedBearSettings")]
	[Calls(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[Calls(Type = typeof(BearHuntRedux), Member = "IsBearSpawned")]
	[Calls(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[Calls(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Activate(bool enableInteraction)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CallerCount(Count = 4)]
	public BearSpawnEncounterResult GetLatestEncounterResult()
	{
		return default(BearSpawnEncounterResult);
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "MaybeRefreshSpawnedBearAiAfterLoad")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Update")]
	[CalledBy(Type = typeof(BearEncounter), Member = "InitializeSpawnedBearData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshSpawnedBearSettings(BearHuntAiRedux bearHuntAiRedux)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	private void InitializeSpawnedBearData(GameObject go)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "UpdateBearEncounterInfo")]
	[CalledBy(Type = typeof(BearHuntRedux), Member = "OnBearEncounterOutcome")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public string GetMissionObjectId()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearEncounter), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
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
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnBear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(AiUtils), Member = "PositionIsClearGivenCollisionMask")]
	[Calls(Type = typeof(BearEncounter), Member = "InstantiateBear")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	private bool SpawnObjectAttempt(bool doVisCheck)
	{
		return false;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "SelectInvestigatePosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetClosestNavmeshPos")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private bool AttemptFindingValidInvestigateLocation()
	{
		return false;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetCurrentActiveBearEncounterCountInScene()
	{
		return 0;
	}

	[CalledBy(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
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
