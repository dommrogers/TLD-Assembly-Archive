using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public static event Action<BaseAi> m_OnBaseAiRemoved
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAiSaveList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_invalid_ai")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "IsOnNavMesh")]
	public static void DisableInvalidAi()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static WolfHowlController GetWolfHowlController()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool IsClosestToPlayer(BaseAi ai)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public static void RefreshClosestToPlayer()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 8)]
	private static bool BearHuntPart2Validate(BaseAiDataProxy proxy, BaseAi bai, BaseAiData bad)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	public static bool CreateMoveAgent(Transform transform, BaseAi bai, Vector3 position)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BaseAi), Member = "DeferredDeserialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAiManager), Member = "BearHuntPart2Validate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SetGuidForGameObject")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	public static void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAi(BaseAi bai, BaseAiData bad, BaseAiDataProxy proxy)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void InstantiateSubsystems(GameObject prefab, Transform parent)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static void Add(BaseAi bai)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 4)]
	public static void Remove(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[Calls(Type = typeof(Panel_HUD), Member = "QuietlyResetTimberWolfCombatMusic")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	public static void ResetAudioLoops()
	{
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	public static void Destroy(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static BaseAi GetAIFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(ObjectGuid), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void RegisterAnyAIGuid()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private static void MaybeSetAiModeWhenInactiveOrDisabled(BaseAi bai)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(WolfHowlController), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	public static void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_ai_continuouscollision")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	public static void UpdateCollisionMode(CollisionDetectionMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void DisplayDebugText()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "GetBatchGroundRaycastSize")]
	private static bool CanUpdateAI(BaseAi bai)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private static int GetBatchGroundRaycastSize()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JobHandle), Member = "Complete")]
	public static void DoLateUpdate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAi), Member = "GetCommandUnderCharacterController")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	public static void BatchGroundRaycast()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static RaycastHit GetBatchGroundRaycastHit(int id)
	{
		return default(RaycastHit);
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void DiposeBatchGroundRaycastHit()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public static void RegisterForBaseAiAdded(Action<BaseAi> function)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void RegisterForBaseAiRemoved(Action<BaseAi> function)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BaseAiManager()
	{
	}
}
