using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion;
using ParadoxNotion.Services;
using TLD.Gameplay;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public abstract class MissionServicesManager : MonoBehaviour
{
	private sealed class _003CPostSceneLoadCo_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionServicesManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CPostSceneLoadCo_003Ed__109(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
		[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
		[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CJumpCo_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionServicesManager _003C_003E4__this;

		public bool isDeserialize;

		public bool isDebug;

		public string missionName;

		private MissionManagerBase _003Cmm_003E5__2;

		private int _003Ci_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CJumpCo_003Ed__130(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[Calls(Type = typeof(MissionManagerBase), Member = "GetNextJumpToId")]
		[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
		[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
		[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const int FRAMES_BEFORE_DESERIALIZATION_CLEAN_UP = 20;

	public FSMOwner m_MainMissionFSMOwner;

	public FSMOwner[] m_SideMissionFSMOwners;

	public GlobalBlackboard m_GlobalBlackboard;

	private GameObject m_SideMissionParent;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Loading> m_LoadingPanel;

	private List<LogType> m_SuppressedLogTypes;

	public MainMissionManager m_MainMissionManager;

	protected readonly Dictionary<string, MissionManagerBase> m_AllMissions;

	protected readonly Dictionary<string, ConcurrentGraphState> m_ConcurrentGraphs;

	protected readonly Dictionary<string, MissionObjectIdentifier> m_RegisteredMissionObjects;

	private readonly List<MissionManagerBase> m_MissionsToRemove;

	protected readonly Dictionary<string, List<MissionTrigger>> m_ObjectInTriggerInfo;

	protected readonly List<MissionTimer> m_MissionTimers;

	protected MissionTimer m_VisibleMissionTimer;

	public string[] m_MissionObjectFilterTags;

	private readonly Dictionary<string, bool> m_FilteredMissionObjects;

	private readonly Dictionary<string, CustomManagedObjectState> m_CustomManagedObjects;

	public static bool m_SuppressItemAddedEvent;

	public static bool m_SuppressItemRemovedEvent;

	public static bool m_StartFromRestore;

	public static int m_StartByMissionJumpCount;

	private readonly List<PendingEvent> m_PendingEventList;

	private readonly List<MissionObjectIdentifier> m_QueuedRegistrations;

	public static bool m_DeserializeEnabled;

	private int m_DeserializationCleanupTicker;

	private bool m_DeserializeComplete;

	private readonly List<IShouldDisableForCurrentMode> m_Disablers;

	private static readonly MissionServicesManagerSaveProxy m_MissionServicesManagerSaveProxy;

	private static readonly List<string> m_RegisteredObjectsToRemove;

	private static readonly List<string> m_ConcurrentGraphRemoveList;

	private GameObject SideMissionParent
	{
		[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool OnNodeCanvasLogMessage(ParadoxNotion.Services.Logger.Message message)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_remove")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public MissionManagerBase GetMissionManager(string missionId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsDeserializationComplete()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_is_mission_active")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsMissionActive(string missionId)
	{
		return false;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Awake")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(MissionServicesManager), Member = "get_SideMissionParent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[Calls(Type = typeof(NCUtils), Member = "GetOrAddVar")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 5)]
	public void InstantiateMission(string missionId)
	{
	}

	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "GetMissionGraphOwnerList")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[CallsUnknownMethods(Count = 2)]
	public string GetActiveGraphNameFromObjective(StoryMissionObjective objective)
	{
		return null;
	}

	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryGetMissionBlackboardVar")]
	public float GetBlackboardVarAsFloat(string varName, string graphName)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MissionManagerBase), Member = "TryGetBlackboardVarAsFloatFullSearch")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public float GetBlackboardVarAsFloatFullSearch(string varName)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetMissionGraphOwner")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallsUnknownMethods(Count = 2)]
	public void StopMission(string missionId, bool forceNow = false)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GameModeConfig), Member = "DestroyMissionServicesManager")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void StopAllMissions()
	{
	}

	[CalledBy(TypeFullName = "InternalUserReport.<>c__DisplayClass7_0", Member = "<Send>b__1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveNode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	public string GetAllActiveMissionNamesAsString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[Calls(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	[Calls(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[Calls(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void SceneLoadCompleted()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SceneUnloaded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public Variable GetGlobalVariable(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_add_filter_tags")]
	[CalledBy(Type = typeof(Action_FilterObjectsByTag), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FilterObjectsByTag")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void AddMissionObjectFilterTags(string tags)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_remove_filter_tags")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(Action_FilterObjectsByTag), Member = "OnStop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void RemoveMissionObjectFilterTags(string tags)
	{
	}

	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	public string GetCurrentMissionFilterTags()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallsUnknownMethods(Count = 1)]
	public bool FiltersAllowObject(MissionObjectIdentifier moi)
	{
		return false;
	}

	[CalledBy(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "AddCustomManagedObject")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveCustomManagedObject")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnStop")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveCustomManagedObject(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveCustomManagedObject(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCustomManagedObject(string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(MissionTimer), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 29)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeConcurrentGraphs")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeCustomManagedObjects")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void AfterGlobalDeserialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SendMissionEvent(string missionId, string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SendMissionEvent<T>(string missionId, string eventString, T value)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(AISendMissionEvent), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CalledBy(Type = typeof(MissionTimer), Member = "Update")]
	[CalledBy(Type = typeof(MissionTimer), Member = "PostExpireEvent")]
	[CalledBy(Type = typeof(SendMissionEventObject), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SendMissionEventObject), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(SendMissionEventTrigger), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(SendMissionEventTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void BroadcastMissionEvent(string eventString)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CookingPotItem), Member = "BroadcastEventWithItemName")]
	[CalledBy(Type = typeof(GearPlacePoint), Member = "UpdateAttachedFire")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnEnterMissionTrigger")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	[CalledBy(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void BroadcastMissionEvent<T>(string eventString, T value)
	{
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void BroadcastMissionEvent(MissionEvent missionEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void BroadcastMissionEvent<T>(MissionEvent missionEvent, T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void BroadcastMissionEvent<T>(MissionObjectEvent missionEvent, T value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetMissionTimerDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_mission_objects")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 20)]
	public static bool ShouldIgnoreMissionObject(MissionObjectIdentifier moi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void QueueRegistration(MissionObjectIdentifier moi)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public void ProcessRegistrationQueue()
	{
	}

	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "ShouldIgnoreMissionObject")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "OnDestroy")]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void UnregisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 60)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public MissionObjectIdentifier FindMissionObject(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Action_PlayTimelineOnTarget), Member = "GetTimelinePlayback")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public T FindMissionObject<T>(string name) where T : Component
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public List<MissionObjectIdentifier> FindMissionObjectsByTag(string[] tags)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "FilterObjectsByTag")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public List<MissionObjectIdentifier> FindMissionObjectsWithoutTag()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameModeConfig), Member = "DestroyMissionServicesManager")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterAllMissionObjects()
	{
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterConcurrentGraph")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentGraphState), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveConcurrentGraph")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveConcurrentGraph")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph<>), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GraphOwner LookupConcurrentGraph(string id)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionTimer), Member = ".ctor")]
	[Calls(Type = typeof(MissionTimer), Member = "Initialize")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void StartMissionTimer(MissionManagerBase manager, string name, float duration, string eventOnExpire, MissionTimer.MissionTimerOptions options)
	{
	}

	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_RemoveTimer), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveMissionTimer(string name, bool postEvent = true)
	{
	}

	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void OnEnterMissionTrigger(ObjectInTriggerInfo info)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnExitMissionTrigger(ObjectInTriggerInfo info, bool bypassListRemove = false)
	{
	}

	[CalledBy(Type = typeof(MissionTrigger), Member = "OnDestroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void MissionTriggerRemoved(MissionTrigger mt)
	{
	}

	[CalledBy(Type = typeof(Condition_InsideMissionTrigger), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<MissionTrigger> IsPlayerInMissionTrigger()
	{
		return null;
	}

	[CalledBy(Type = typeof(Condition_InsideMissionTrigger), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<MissionTrigger> IsMissionObjectInMissionTrigger(MissionObjectIdentifier moi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public List<MissionTrigger> IsGameObjectInMissionTrigger(GameObject obj)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void OnInventoryItemAdded()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void OnInventoryItemRemoved()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateMissionServicesManager")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void RegisterAnyMissionObjects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void OnItemEquipped()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void OnFiredEquippedWeapon()
	{
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Condition_IsTimeActive), Member = "OnCheck")]
	[CallerCount(Count = 8)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public MissionTimer GetMissionTimerByName(string timerName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[CallsUnknownMethods(Count = 1)]
	public void RefreshMissionIds()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_jump")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeMissions")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	public void JumpTo(string id, bool isDebug, string missionConfigData = null)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveNode")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[CallsUnknownMethods(Count = 2)]
	public int GetMissionsActiveActionCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsDuplicateAllowed(MissionObjectIdentifier moi)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "TryGetBlackboardVarAsFloatFullSearch")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool TryGetMissionBlackboardVar<T>(GraphOwner go, string varName, out T value)
	{
		value = default(T);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObjectIdentifier")]
	public static T GetComponentForMissionObject<T>(string moi) where T : Behaviour
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObjectIdentifier")]
	[CallsUnknownMethods(Count = 1)]
	public static GameObject GetMissionObject(string moi)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public static MissionObjectIdentifier GetMissionObjectIdentifier(string moi)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PlayableAssetFadeLight), Member = "CreatePlayable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public static T[] GetComponentsInChildrenForMissionObject<T>(string moi, bool includeInactive) where T : Behaviour
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[Calls(Type = typeof(GraphOwner), Member = "get_isRunning")]
	[Calls(Type = typeof(GraphOwner), Member = "get_isPaused")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	protected void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[CallsUnknownMethods(Count = 2)]
	private string GetActiveGraphName(string[] graphNames)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSideMission(string missionName)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CPostSceneLoadCo_003Ed__109))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator PostSceneLoadCo()
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void FilterObjectsByTag()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeCleanupDuplicateBody(MissionObjectIdentifier mo)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeCleanupDuplicateBody")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void ReviewObjectFiltering()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	private void DeserializeGlobalBB(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void DeserializeMissions(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentGraphState), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void DeserializeConcurrentGraphs(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionTimer), Member = ".ctor")]
	[Calls(Type = typeof(MissionTimer), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	private void DeserializeTimers(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[CallsUnknownMethods(Count = 1)]
	private void TryUnregisterGuid(GameObject gameObject)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void EliminateDuplicateAndRestoreAI(MissionObjectIdentifier sceneAiMissionId, BaseAi baseAI, BaseAi sceneAi)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Destroy")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void EliminateDuplicateAndRestoreBodyHarvest(MissionObjectIdentifier sceneBodyHarvestMissionId, BodyHarvest bodyHarvest, BodyHarvest sceneBodyHarvest)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAiManager), Member = "GetAIFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void UnregisterDuplicatedGuids(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAiManager), Member = "GetAIFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	private void EliminateDuplicateAndRestore(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeCustomManagedObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeResumeStateOnDeserialize(MissionObjectIdentifier moi, CustomManagedObjectState stateInfo)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void DeserializeCustomManagedObjects(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SendEvent(EventData ev, string missionId)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SendOrQueueEvent(EventData ev, string missionId)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void RemoveMissionTimer(int timerIndex, bool postEvent = true)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "MissionCompleted")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void ProcessRemoveMissionList()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void MissionCompleted(MissionManagerBase mm)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DestroyMission(MissionManagerBase mm)
	{
	}

	[IteratorStateMachine(typeof(_003CJumpCo_003Ed__130))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator JumpCo(string missionName, bool isDeserialize, bool isDebug)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetAllActiveMissionNamesAsString")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	private Node GetActiveNode(string mission)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private int RecursiveActionListCounter(ActionList actionList)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetSubNodeActionCountRecursive(Node node)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	private int GetNodeActiveActionCountRecursive(Node node)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogConditionEnabledRecursive(ConditionTask conditionTask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogTransitionRecursive(ConditionTask conditionTask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogActionTaskEnter(ActionTask actionTask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogActionTaskEnd(ActionTask actionTask, Status status)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogActonStateEnter(ActionState actionState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogActonStateExit(ActionState actionState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogPendingSave()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogSave(float timePending)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void LogPendingSaveTimeout(float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeOwnsChild")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 17)]
	public static Node GetOwner(FSM fsm, Task task)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeOwnsChild")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetOwnerRecursive(ConditionTask conditionTask, Task child)
	{
		return false;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwner")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetNodeOwnsChild(Node node, Task child)
	{
		return false;
	}

	[CalledBy(Type = typeof(SandboxManager), Member = ".ctor")]
	[CalledBy(Type = typeof(StoryManager), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	protected MissionServicesManager()
	{
	}
}
