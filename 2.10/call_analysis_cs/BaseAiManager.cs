using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI;
using TLD.UI.Generics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
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
		[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiAdded")]
		[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
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
		[CalledBy(Type = typeof(BaseAiManager), Member = "RegisterForBaseAiRemoved")]
		[CalledBy(Type = typeof(ToxicFogManager), Member = "Start")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_disable_invalid_ai")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "IsOnNavMesh")]
	[Calls(Type = typeof(MoveAgent), Member = "Enable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public static void RefreshClosestToPlayer()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static bool BearHuntPart2Validate(BaseAiDataProxy proxy, BaseAi bai, BaseAiData bad)
	{
		return false;
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool CreateMoveAgent(Transform transform, BaseAi bai, Vector3 position)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAi), Member = "GetBaseAiDataProxyFromText")]
	[Calls(Type = typeof(BaseAiManager), Member = "BearHuntPart2Validate")]
	[Calls(Type = typeof(BaseAiManager), Member = "DeserializeAi")]
	[Calls(Type = typeof(BaseAi), Member = "DeferredDeserialize")]
	[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(BaseAiManager), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeAttachObjectGuidAndRegister")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public static void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Awake")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "CreateMoveAgent")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "DeserializeUsingBaseAiDataProxy")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public static void DeserializeAi(BaseAi bai, BaseAiData bad, BaseAiDataProxy proxy)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void InstantiateSubsystems(GameObject prefab, Transform parent)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "SetNextTimer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Add(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Remove(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseAi), Member = "StopStruggleAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopAttackAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHoldGroundAudio")]
	[Calls(Type = typeof(BaseAi), Member = "StopHideAndSeekAudio")]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsUnknownMethods(Count = 3)]
	public static void ResetAudioLoops()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeDestroyIfFellThroughWorld")]
	[CalledBy(Type = typeof(BearEncounter), Member = "UpdateBearDespawn")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WolfHowlController), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static void Destroy(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	public static BaseAi GetAIFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateMissionServicesManager")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static void RegisterAnyAIGuid()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void MaybeSetAiModeWhenInactiveOrDisabled(BaseAi bai)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateCurrentHowl")]
	[Calls(Type = typeof(WolfHowlController), Member = "UpdateTimer")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseAiManager), Member = "MaybeSetAiModeWhenInactiveOrDisabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "EnableSkinnedMeshRenderers")]
	[Calls(Type = typeof(CharacterController), Member = "get_height")]
	[Calls(Type = typeof(CharacterController), Member = "get_radius")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Update()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_ai_continuouscollision")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetCollisionMode")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void UpdateCollisionMode(CollisionDetectionMode mode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void DisplayDebugText()
	{
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "GetBatchGroundRaycastSize")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[CalledBy(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static bool CanUpdateAI(BaseAi bai)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static int GetBatchGroundRaycastSize()
	{
		return 0;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAi), Member = "DoLateUpdate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void DoLateUpdate()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "CanUpdateAI")]
	[Calls(Type = typeof(BaseAi), Member = "GetCommandUnderCharacterController")]
	[Calls(Type = typeof(BatchQueryJobStruct<>), Member = "Initialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void BatchGroundRaycast()
	{
	}

	[CallerCount(Count = 0)]
	public static RaycastHit GetBatchGroundRaycastHit(int id)
	{
		return default(RaycastHit);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BaseAiManager()
	{
	}
}
