using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class BaseAiManager
{
	public static bool m_AiDebug;

	public static bool m_DisableAi;

	public static bool m_AiNavMeshDebug;

	public static bool m_AiSpawnDebug;

	public static bool m_AiDebugLite;

	public static bool s_AiDebugClosestOnly;

	public static bool m_AiDebugStates;

	public static bool s_EnableBatchGroundRaycast;

	public static bool s_EnableContinuousCollision;

	public static List<BaseAi> m_BaseAis;

	public const CollisionDetectionMode DEFAULT_CONTINUOUS_COLLISION_MODE = CollisionDetectionMode.ContinuousSpeculative;

	private static BaseAi s_ClosestAiToPlayer;

	private static GameObject s_Subsystems;

	private static WolfHowlController s_WolfHowlController;

	private static Dictionary<string, int> ms_CurrentWaypointIndexByGUID;

	private static JobHandle s_BatchGroundRaycastJob;

	private static NativeArray<RaycastHit> s_BatchGroundRaycastResults;

	private static NativeArray<SpherecastCommand> s_BatchGroundRaycastCommands;

	private static bool s_BatchGroundRaycastJobCompleted;

	private static RaycastHit s_InvalidHit;

	private static bool s_BatchGroundRaycastCommandsAllocated;

	public static event Action<BaseAi> m_OnBaseAiAdded
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
		[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiAdded")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public static event Action<BaseAi> m_OnBaseAiRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiRemoved")]
		[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_invalid_ai")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "IsOnNavMesh")]
	public static void DisableInvalidAi()
	{
	}

	[CallerCount(Count = 0)]
	public static WolfHowlController GetWolfHowlController()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsClosestToPlayer(BaseAi ai)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	public static void RefreshClosestToPlayer()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	private static bool BearHuntPart2Validate(BaseAiDataProxy proxy, BaseAi bai, BaseAiData bad)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static bool CreateMoveAgent(Transform transform, BaseAi bai, Vector3 position)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(BaseAiManager), Member = "BearHuntPart2Validate")]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAi), Member = "DeferredDeserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	public static void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void DeserializeAi(BaseAi bai, BaseAiData bad, BaseAiDataProxy proxy)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void InstantiateSubsystems(GameObject prefab, Transform parent)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CallsUnknownMethods(Count = 3)]
	public static void Add(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Remove(BaseAi bai)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 3)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	public static void ResetAudioLoops()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	public static void Destroy(BaseAi bai)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallsUnknownMethods(Count = 4)]
	public static BaseAi GetAIFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void RegisterAnyAIGuid()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private static void MaybeSetAiModeWhenInactiveOrDisabled(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	public static void Update()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_ai_continuouscollision")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void UpdateCollisionMode(CollisionDetectionMode mode)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void DisplayDebugText()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "GetBatchGroundRaycastSize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallsUnknownMethods(Count = 3)]
	private static bool CanUpdateAI(BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static int GetBatchGroundRaycastSize()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	public static void DoLateUpdate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAi), Member = "GetCommandUnderCharacterController")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	public static void BatchGroundRaycast()
	{
	}

	[CallerCount(Count = 0)]
	public static RaycastHit GetBatchGroundRaycastHit(int id)
	{
		return default(RaycastHit);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	public static void DiposeBatchGroundRaycastHit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "add_m_OnBaseAiAdded")]
	public static void RegisterForBaseAiAdded(Action<BaseAi> function)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "add_m_OnBaseAiRemoved")]
	public static void RegisterForBaseAiRemoved(Action<BaseAi> function)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BaseAiManager()
	{
	}
}
