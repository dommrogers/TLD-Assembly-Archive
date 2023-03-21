using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
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
	private sealed class _003CPostSceneLoadCo_003Ed__109 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionServicesManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MissionServicesManager), Member = "SendEvent")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CJumpCo_003Ed__130 : IEnumerator, IDisposable, IEnumerator<object>
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
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
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

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
		[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
		[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
		[CallsDeduplicatedMethods(Count = 8)]
		[Calls(Type = typeof(MissionManagerBase), Member = "GetNextJumpToId")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const int FRAMES_BEFORE_DESERIALIZATION_CLEAN_UP = 20;

	public FSMOwner m_MainMissionFSMOwner;

	public FSMOwner[] m_SideMissionFSMOwners;

	public GlobalBlackboard m_GlobalBlackboard;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Loading> m_LoadingPanel;

	private List<LogType> m_SuppressedLogTypes;

	public MainMissionManager m_MainMissionManager;

	public GameObject m_SideMissionParent;

	protected Dictionary<string, MissionManagerBase> m_AllMissions;

	protected Dictionary<string, ConcurrentGraphState> m_ConcurrentGraphs;

	protected Dictionary<string, MissionObjectIdentifier> m_RegisteredMissionObjects;

	private List<MissionManagerBase> m_MissionsToRemove;

	protected Dictionary<string, List<MissionTrigger>> m_ObjectInTriggerInfo;

	protected List<MissionTimer> m_MissionTimers;

	protected MissionTimer m_VisibleMissionTimer;

	public string[] m_MissionObjectFilterTags;

	private Dictionary<string, bool> m_FilteredMissionObjects;

	private Dictionary<string, CustomManagedObjectState> m_CustomManagedObjects;

	public static bool m_SuppressItemAddedEvent;

	public static bool m_SuppressItemRemovedEvent;

	public static bool m_StartFromRestore;

	public static int m_StartByMissionJumpCount;

	private List<PendingEvent> m_PendingEventList;

	private List<MissionObjectIdentifier> m_QueuedRegistrations;

	public static bool m_DeserializeEnabled;

	private int m_DeserializationCleanupTicker;

	private bool m_DeserializeComplete;

	private readonly List<IShouldDisableForCurrentMode> m_Disablers;

	private static MissionServicesManagerSaveProxy m_MissionServicesManagerSaveProxy;

	private static List<string> m_RegisteredObjectsToRemove;

	private static List<string> m_ConcurrentGraphRemoveList;

	[CallsUnknownMethods(Count = 62)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	protected void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool OnNodeCanvasLogMessage(ParadoxNotion.Services.Logger.Message message)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[CallsUnknownMethods(Count = 1)]
	public MissionManagerBase GetMissionManager(string missionId)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public bool IsDeserializationComplete()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_is_mission_active")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsMissionActive(string missionId)
	{
		return default(bool);
	}

	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Awake")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(NCUtils), Member = "GetOrAddVar")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(NCUtils), Member = "GetOrAddVar")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	public void InstantiateMission(string missionId)
	{
	}

	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "GetMissionGraphOwnerList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	public string GetActiveGraphNameFromObjective(StoryMissionObjective objective)
	{
		return null;
	}

	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	public float GetBlackboardVarAsFloat(string varName, string graphName)
	{
		return default(float);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionManagerBase), Member = "TryGetBlackboardVarAsFloatFullSearch")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CallsUnknownMethods(Count = 5)]
	public float GetBlackboardVarAsFloatFullSearch(string varName)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphName")]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetMissionGraphOwner")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_remove")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public void StopMission(string missionId, bool forceNow = false)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	public void StopAllMissions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveNode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	public string GetAllActiveMissionNamesAsString()
	{
		return null;
	}

	[Calls(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	public void SceneLoadCompleted()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void SceneUnloaded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsUnknownMethods(Count = 1)]
	public Variable GetGlobalVariable(string name)
	{
		return null;
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CalledBy(Type = typeof(Action_FilterObjectsByTag), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FilterObjectsByTag")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_add_filter_tags")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public void AddMissionObjectFilterTags(string tags)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_remove_filter_tags")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(Action_FilterObjectsByTag), Member = "OnStop")]
	[CallsUnknownMethods(Count = 10)]
	public void RemoveMissionObjectFilterTags(string tags)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetCurrentMissionFilterTags()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallsUnknownMethods(Count = 1)]
	public bool FiltersAllowObject(MissionObjectIdentifier moi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "AddCustomManagedObject")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnStop")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveCustomManagedObject")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void RemoveCustomManagedObject(string name)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void RemoveCustomManagedObject(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasCustomManagedObject(string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionTimer), Member = "Serialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsSideMission")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 109)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string Serialize()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	public void DeserializeSandbox(string text)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void DeserializeChallenge(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeChallenge")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeSandbox")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeCustomManagedObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeConcurrentGraphs")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	public void AfterGlobalDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void SendMissionEvent(string missionId, string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 7)]
	public void SendMissionEvent<T>(string missionId, string eventString, T value)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CalledBy(Type = typeof(MissionTimer), Member = "Update")]
	[CalledBy(Type = typeof(MissionTimer), Member = "PostExpireEvent")]
	[CalledBy(Type = typeof(SendMissionEventObject), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(SendMissionEventTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(SendMissionEventObject), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(SendMissionEventTrigger), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[CalledBy(Type = typeof(AISendMissionEvent), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	public void BroadcastMissionEvent(string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 7)]
	public void BroadcastMissionEvent<T>(string eventString, T value)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ActivateStage")]
	public void BroadcastMissionEvent(MissionEvent missionEvent)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public void BroadcastMissionEvent<T>(MissionEvent missionEvent, T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 7)]
	public void BroadcastMissionEvent<T>(MissionObjectEvent missionEvent, T value)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugString")]
	public string GetMissionTimerDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_mission_objects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static bool ShouldIgnoreMissionObject(MissionObjectIdentifier moi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void QueueRegistration(MissionObjectIdentifier moi)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ProcessRegistrationQueue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ShouldIgnoreMissionObject")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 3)]
	public void RegisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	public void UnregisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 61)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public MissionObjectIdentifier FindMissionObject(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	public T FindMissionObject<T>(string name) where T : Component
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public List<MissionObjectIdentifier> FindMissionObjectsByTag(string[] tags)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FilterObjectsByTag")]
	[CallsUnknownMethods(Count = 9)]
	public List<MissionObjectIdentifier> FindMissionObjectsWithoutTag()
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	public void UnregisterAllMissionObjects()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterConcurrentGraph")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(ConcurrentGraphState), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveConcurrentGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph<>), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveConcurrentGraph")]
	public GraphOwner LookupConcurrentGraph(string id)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[Calls(Type = typeof(MissionTimer), Member = "Initialize")]
	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionTimer), Member = ".ctor")]
	public void StartMissionTimer(MissionManagerBase manager, string name, float duration, string eventOnExpire, MissionTimer.MissionTimerOptions options)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_RemoveTimer), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveMissionTimer(string name, bool postEvent = true)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public void OnEnterMissionTrigger(ObjectInTriggerInfo info)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 4)]
	public void OnExitMissionTrigger(ObjectInTriggerInfo info, bool bypassListRemove = false)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	public void MissionTriggerRemoved(MissionTrigger mt)
	{
	}

	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Condition_InsideMissionTrigger), Member = "OnCheck")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public List<MissionTrigger> IsPlayerInMissionTrigger()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Condition_InsideMissionTrigger), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public List<MissionTrigger> IsMissionObjectInMissionTrigger(MissionObjectIdentifier moi)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public List<MissionTrigger> IsGameObjectInMissionTrigger(GameObject obj)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TryAddToExistingStackable")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void RegisterAnyMissionObjects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void OnItemEquipped()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	public void OnFiredEquippedWeapon()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Condition_IsTimeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	public MissionTimer GetMissionTimerByName(string timerName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[CallsUnknownMethods(Count = 3)]
	public void RefreshMissionIds()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "JumpCo")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(MissionManagerBase), Member = "InitiateJumpTo")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeMissions")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_jump")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsSideMission")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void JumpTo(string id, bool isDebug, string missionConfigData = null)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	public int GetMissionsActiveActionCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsDuplicateAllowed(MissionObjectIdentifier moi)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsUnknownMethods(Count = 4)]
	public static bool TryGetMissionBlackboardVar<T>(GraphOwner go, string varName, out T value)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObjectIdentifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[DeduplicatedMethod]
	[CallerCount(Count = 21)]
	public static T GetComponentForMissionObject<T>(string moi) where T : Behaviour
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObjectIdentifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject GetMissionObject(string moi)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public static MissionObjectIdentifier GetMissionObjectIdentifier(string moi)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static T[] GetComponentsInChildrenForMissionObject<T>(string moi, bool includeInactive) where T : Behaviour
	{
		return null;
	}

	[Calls(Type = typeof(GraphOwner), Member = "get_isRunning")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GraphOwner), Member = "get_isPaused")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	protected void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[CallerCount(Count = 0)]
	private string GetActiveGraphName(string[] graphNames)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSideMission(string missionName)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(_003CPostSceneLoadCo_003Ed__109))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator PostSceneLoadCo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void FilterObjectsByTag()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void MaybeCleanupDuplicateBody(MissionObjectIdentifier mo)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeCleanupDuplicateBody")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void DeserializeMissions(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentGraphState), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	private void DeserializeConcurrentGraphs(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionTimer), Member = "Deserialize")]
	[Calls(Type = typeof(MissionTimer), Member = ".ctor")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void DeserializeTimers(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	private void TryUnregisterGuid(GameObject gameObject)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	private void EliminateDuplicateAndRestoreAI(MissionObjectIdentifier sceneAiMissionId, BaseAi baseAI, BaseAi sceneAi)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Destroy")]
	private void EliminateDuplicateAndRestoreBodyHarvest(MissionObjectIdentifier sceneBodyHarvestMissionId, BodyHarvest bodyHarvest, BodyHarvest sceneBodyHarvest)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "GetAIFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	private void UnregisterDuplicatedGuids(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "GetAIFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	private void EliminateDuplicateAndRestore(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeCustomManagedObjects")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	private void MaybeResumeStateOnDeserialize(MissionObjectIdentifier moi, CustomManagedObjectState stateInfo)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void DeserializeCustomManagedObjects(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SendEvent")]
	[CalledBy(Type = typeof(_003CPostSceneLoadCo_003Ed__109), Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 1)]
	private void SendEvent(EventData ev, string missionId)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendMissionEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	private void SendOrQueueEvent(EventData ev, string missionId)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	private void RemoveMissionTimer(int timerIndex, bool postEvent = true)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MissionCompleted")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void ProcessRemoveMissionList()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsUnknownMethods(Count = 1)]
	private void MissionCompleted(MissionManagerBase mm)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void DestroyMission(MissionManagerBase mm)
	{
	}

	[IteratorStateMachine(typeof(_003CJumpCo_003Ed__130))]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 6)]
	private IEnumerator JumpCo(string missionName, bool isDeserialize, bool isDebug)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetAllActiveMissionNamesAsString")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Node GetActiveNode(string mission)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[CallsUnknownMethods(Count = 2)]
	private int RecursiveActionListCounter(ActionList actionList)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private int GetSubNodeActionCountRecursive(Node node)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[CallsUnknownMethods(Count = 2)]
	private int GetNodeActiveActionCountRecursive(Node node)
	{
		return default(int);
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	private void SetCurrentEpisode(string id)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 9)]
	public static Node GetOwner(FSM fsm, Task task)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeOwnsChild")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static bool GetOwnerRecursive(ConditionTask conditionTask, Task child)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwner")]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetNodeOwnsChild(Node node, Task child)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SandboxManager), Member = ".ctor")]
	[CalledBy(Type = typeof(StoryManager), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected MissionServicesManager()
	{
	}
}
