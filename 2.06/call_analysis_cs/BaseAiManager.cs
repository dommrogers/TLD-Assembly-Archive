using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	public static event Action<BaseAi> m_OnBaseAiRemoved
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "IsOnNavMesh")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	public static void DisableInvalidAi()
	{
	}

	[CallerCount(Count = 0)]
	public static WolfHowlController GetWolfHowlController()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	public static bool IsClosestToPlayer(BaseAi ai)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	public static bool CreateMoveAgent(Transform transform, BaseAi bai, Vector3 position)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAiManager), Member = "BearHuntPart2Validate")]
	[Calls(Type = typeof(BaseAi), Member = "DeferredDeserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	public static void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void DeserializeAi(BaseAi bai, BaseAiData bad, BaseAiDataProxy proxy)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[CallsUnknownMethods(Count = 2)]
	public static void InstantiateSubsystems(GameObject prefab, Transform parent)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Add(BaseAi bai)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	public static void ResetAudioLoops()
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void Destroy(BaseAi bai)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallsUnknownMethods(Count = 3)]
	public static BaseAi GetAIFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	public static void RegisterAnyAIGuid()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private static void MaybeSetAiModeWhenInactiveOrDisabled(BaseAi bai)
	{
	}

	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public static void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public static void UpdateCollisionMode(CollisionDetectionMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void DisplayDebugText()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "GetBatchGroundRaycastSize")]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	public static void DoLateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAi), Member = "GetCommandUnderCharacterController")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 8)]
	public static void BatchGroundRaycast()
	{
	}

	[CallerCount(Count = 0)]
	public static RaycastHit GetBatchGroundRaycastHit(int id)
	{
		return default(RaycastHit);
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor")]
	public static void DiposeBatchGroundRaycastHit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterForBaseAiAdded(Action<BaseAi> function)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterForBaseAiRemoved(Action<BaseAi> function)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public BaseAiManager()
	{
	}
}
