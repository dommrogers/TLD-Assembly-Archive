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
using SpecialEvents;
using UnityEngine;

public abstract class MissionServicesManager : MonoBehaviour
{
	private sealed class _003CPostSceneLoadCo_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissionServicesManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CPostSceneLoadCo_003Ed__115(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(MissionServicesManager), Member = "SendEvent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CJumpCo_003Ed__136 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool isDeserialize;

		public bool isDebug;

		public MissionServicesManager _003C_003E4__this;

		public string missionName;

		private MissionManagerBase _003Cmm_003E5__2;

		private int _003Ci_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CJumpCo_003Ed__136(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 11)]
		[Calls(Type = typeof(MissionManagerBase), Member = "GetNextJumpToId")]
		[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
		[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
		[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
		[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
		[CallsUnknownMethods(Count = 30)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const int FRAMES_BEFORE_DESERIALIZATION_CLEAN_UP = 20;

	public FSMOwner m_MainMissionFSMOwner;

	public FSMOwner[] m_SideMissionFSMOwners;

	public GlobalBlackboard m_GlobalBlackboard;

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

	private static MissionServicesManagerSaveProxy m_MissionServicesManagerSaveProxy;

	private static List<string> m_RegisteredObjectsToRemove;

	private static List<string> m_ConcurrentGraphRemoveList;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogConditionEnabledRecursive(ConditionTask conditionTask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogTransitionRecursive(ConditionTask conditionTask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogActionTaskEnter(ActionTask actionTask)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogActionTaskEnd(ActionTask actionTask, Status status)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static void LogActonStateEnter(ActionState actionState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogActonStateExit(ActionState actionState)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogPendingSave()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void LogSave(float timePending)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static void LogPendingSaveTimeout(float time)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeOwnsChild")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FSMState), Member = "get_FSM")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static Node GetOwner(FSM fsm, Task task)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeOwnsChild")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	private static bool GetOwnerRecursive(ConditionTask conditionTask, Task child)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetOwnerRecursive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetOwner")]
	[CallsUnknownMethods(Count = 3)]
	private static bool GetNodeOwnsChild(Node node, Task child)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StoryManager), Member = "Awake")]
	[CalledBy(Type = typeof(SandboxManager), Member = "Awake")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	protected void Awake()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[CallsUnknownMethods(Count = 1)]
	public MissionManagerBase GetMissionManager(string missionId)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsDeserializationComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_is_mission_active")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsMissionActive(string missionId)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public void InstantiateMission(string missionId)
	{
	}

	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(MissionObjectiveTable), Member = "GetMissionGraphOwnerList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	public string GetActiveGraphNameFromObjective(StoryMissionObjective objective)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	public float GetBlackboardVarAsFloat(string varName, string graphName)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(StoryMissionObjective), Member = "TryGetCurrentAndRequired")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[Calls(Type = typeof(MissionManagerBase), Member = "TryGetBlackboardVarAsFloatFullSearch")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	public float GetBlackboardVarAsFloatFullSearch(string varName)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphName")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetMissionGraphOwner")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetActiveGraphNameFromObjective")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetBlackboardVarAsFloat")]
	[CallsUnknownMethods(Count = 4)]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	public void StopMission(string missionId, bool forceNow = false)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CalledBy(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[CalledBy(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 6)]
	public void StopAllMissions()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InternalUserReport._003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveNode")]
	public string GetAllActiveMissionNamesAsString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "RegisterAnySpawnWildlifeGuid")]
	[Calls(Type = typeof(SnowShelterManager), Member = "RegisterAnySnowShelterGuid")]
	[Calls(Type = typeof(LeanToManager), Member = "RegisterAnyLeanToGuid")]
	[Calls(Type = typeof(RockCacheManager), Member = "RegisterAnyRockCacheGuid")]
	[Calls(Type = typeof(MissionServicesManager), Member = "PostSceneLoadCo")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void SceneLoadCompleted()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_add_filter_tags")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FilterObjectsByTag")]
	[CalledBy(Type = typeof(Action_FilterObjectsByTag), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void AddMissionObjectFilterTags(string tags)
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Action_FilterObjectsByTag), Member = "OnStop")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_remove_filter_tags")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	public void RemoveMissionObjectFilterTags(string tags)
	{
	}

	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CellToilet), Member = "ShouldDoInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 3)]
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

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnExecute")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "AddCustomManagedObject")]
	[CalledBy(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_EnableObjects), Member = "OnStop")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveCustomManagedObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void RemoveCustomManagedObject(string name)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 8)]
	public void RemoveCustomManagedObject(MissionObjectIdentifier moi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool HasCustomManagedObject(string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 73)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionTimer), Member = "Serialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsSideMission")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void DeserializeChallenge(string text)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeChallenge")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeSandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadComplete")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeCustomManagedObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DeserializeConcurrentGraphs")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 7)]
	public void AfterGlobalDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SendMissionEvent(string missionId, string eventString)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 9)]
	public void SendMissionEvent<T>(string missionId, string eventString, T value)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[CalledBy(Type = typeof(MissionTimer), Member = "Update")]
	[CalledBy(Type = typeof(MissionTimer), Member = "PostExpireEvent")]
	[CalledBy(Type = typeof(SendMissionEventObject), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(SendMissionEventTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(SendMissionEventTrigger), Member = "SendMissionEvent")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[CalledBy(Type = typeof(SendMissionEventObject), Member = "SendMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnItemEquipped")]
	[CalledBy(Type = typeof(CellToilet), Member = "OnWardenWrapUpDone")]
	[CalledBy(Type = typeof(CellToilet), Member = "OnReturnFromDamDone")]
	[CalledBy(Type = typeof(CellToilet), Member = "DoSecondInteraction")]
	[CalledBy(Type = typeof(CellToilet), Member = "OnGottenUp")]
	[CalledBy(Type = typeof(CellToilet), Member = "DoFirstInteraction")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(AISendMissionEvent), Member = "Update")]
	public void BroadcastMissionEvent(string eventString)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void BroadcastMissionEvent<T>(string eventString, T value)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CalledBy(Type = typeof(WeatherSet), Member = "ActivateStage")]
	[CalledBy(Type = typeof(FlareItem), Member = "Ignite")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnInventoryItemAdded")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "OnInventoryItemRemoved")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetUpAnimationComplete")]
	[CallsUnknownMethods(Count = 8)]
	public void BroadcastMissionEvent(MissionEvent missionEvent)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void BroadcastMissionEvent<T>(MissionEvent missionEvent, T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[CallsUnknownMethods(Count = 9)]
	public void BroadcastMissionEvent<T>(MissionObjectEvent missionEvent, T value)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetMissionTimerDebugText()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_dump_mission_objects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(GameObject), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 2)]
	public static bool ShouldIgnoreMissionObject(MissionObjectIdentifier moi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void QueueRegistration(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	public void ProcessRegistrationQueue()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ShouldIgnoreMissionObject")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	public void RegisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "AddMissionComponentForSaveManagedItem")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(MissionObjectIdentifier), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	public void UnregisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 64)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public MissionObjectIdentifier FindMissionObject(string name)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 5)]
	public T FindMissionObject<T>(string name) where T : Component
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public List<MissionObjectIdentifier> FindMissionObjectsByTag(string[] tags)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "FilterObjectsByTag")]
	[CallsUnknownMethods(Count = 10)]
	public List<MissionObjectIdentifier> FindMissionObjectsWithoutTag()
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "MaybeDestroyGearItemAfterMission")]
	[CalledBy(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetCurrentMissionFilterTags")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void UnregisterAllMissionObjects()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterConcurrentGraph")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(GraphOwner), Member = "GetInstance")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(ConcurrentGraphState), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveConcurrentGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[Calls(Type = typeof(GraphOwner), Member = "StopBehaviour")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph<>), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PostEventToConcurrentGraph), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RemoveConcurrentGraph")]
	public GraphOwner LookupConcurrentGraph(string id)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[Calls(Type = typeof(MissionTimer), Member = "Initialize")]
	[Calls(Type = typeof(MissionTimer), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	public void StartMissionTimer(MissionManagerBase manager, string name, float duration, string eventOnExpire, MissionTimer.MissionTimerOptions options)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Action_StartTimer), Member = "OnStop")]
	[CalledBy(Type = typeof(Action_RemoveTimer), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveMissionTimer(string name, bool postEvent = true)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void OnEnterMissionTrigger(ObjectInTriggerInfo info)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterMissionObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionTriggerRemoved")]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 8)]
	public void OnExitMissionTrigger(ObjectInTriggerInfo info, bool bypassListRemove = false)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(MissionTrigger), Member = "OnDestroy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnExitMissionTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectInTriggerInfo), Member = ".ctor")]
	public void MissionTriggerRemoved(MissionTrigger mt)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_InsideMissionTrigger), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	public List<MissionTrigger> IsPlayerInMissionTrigger()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Condition_InsideMissionTrigger), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_IsInMissionTrigger), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public List<MissionTrigger> IsMissionObjectInMissionTrigger(MissionObjectIdentifier moi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 4)]
	public List<MissionTrigger> IsGameObjectInMissionTrigger(GameObject obj)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddToExistingStackable")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	public void OnInventoryItemAdded()
	{
	}

	[CalledBy(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnInventoryItemRemoved()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallsUnknownMethods(Count = 11)]
	public void RegisterAnyMissionObjects()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnEquipItemBegin")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UnequipItemInHandsForPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnProcessPickupWinNoInspectEquipComplete")]
	[CallerCount(Count = 5)]
	public void OnItemEquipped()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	public void OnFiredEquippedWeapon()
	{
	}

	[CalledBy(Type = typeof(Condition_IsTimeActive), Member = "OnCheck")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	public MissionTimer GetMissionTimerByName(string timerName)
	{
		return null;
	}

	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RefreshMissionIds()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(Type = typeof(FSMHierarchy), Member = "Reset")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SetCurrentEpisode")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpCo")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisodeFadeCallback")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mission_jump")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadComplete")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeMissions")]
	[CallsUnknownMethods(Count = 80)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsSideMission")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[Calls(Type = typeof(MissionServicesManager), Member = "InstantiateMission")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsSideMission")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void JumpTo(string id, bool isDebug, string missionConfigData = null)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetActiveNode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public int GetMissionsActiveActionCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsDuplicateAllowed(MissionObjectIdentifier moi)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CallsUnknownMethods(Count = 6)]
	public static bool TryGetMissionBlackboardVar<T>(GraphOwner go, string varName, out T value)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObjectIdentifier")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public static T GetComponentForMissionObject<T>(string moi) where T : Behaviour
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionObjectIdentifier")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject GetMissionObject(string moi)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionObject")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	public static MissionObjectIdentifier GetMissionObjectIdentifier(string moi)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static T[] GetComponentsInChildrenForMissionObject<T>(string moi, bool includeInactive) where T : Behaviour
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CalledBy(Type = typeof(StoryManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SandboxManager), Member = "Update")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "XPModeIsChallenge")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(GraphOwner), Member = "get_isRunning")]
	[Calls(Type = typeof(FSMHierarchy), Member = "RefreshIds")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(Type = typeof(MissionTimer), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRegistrationQueue")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "get_isPaused")]
	protected void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionGraphOwner")]
	private string GetActiveGraphName(string[] graphNames)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsSideMission(string missionName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "SceneLoadCompleted")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator PostSceneLoadCo()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObjectsWithoutTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	private void FilterObjectsByTag()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ReviewObjectFiltering")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	private void MaybeCleanupDuplicateBody(MissionObjectIdentifier mo)
	{
	}

	[Calls(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionObjectFilterTags")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "AddMissionObjectFilterTags")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeCleanupDuplicateBody")]
	[Calls(Type = typeof(MissionObjectIdentifier), Member = "HasAnyTag")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	private void ReviewObjectFiltering()
	{
	}

	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void DeserializeGlobalBB(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 0)]
	private void DeserializeMissions(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ConcurrentGraphState), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void DeserializeConcurrentGraphs(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(MissionTimer), Member = "Deserialize")]
	[Calls(Type = typeof(MissionTimer), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void DeserializeTimers(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	private void TryUnregisterGuid(GameObject gameObject)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[Calls(Type = typeof(BaseAi), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BaseAi), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "Destroy")]
	private void EliminateDuplicateAndRestoreAI(MissionObjectIdentifier sceneAiMissionId, BaseAi baseAI, BaseAi sceneAi)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BodyHarvest), Member = "Serialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Destroy")]
	[Calls(Type = typeof(BodyHarvest), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCorpseState")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "MaybeRestoreCarcassSite")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallsUnknownMethods(Count = 12)]
	private void EliminateDuplicateAndRestoreBodyHarvest(MissionObjectIdentifier sceneBodyHarvestMissionId, BodyHarvest bodyHarvest, BodyHarvest sceneBodyHarvest)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "GetAIFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "TryUnregisterGuid")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void UnregisterDuplicatedGuids(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[Calls(Type = typeof(BodyHarvestManager), Member = "GetBodyHarvestFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "GetAIFromSerializedMissionId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestoreAI")]
	private void EliminateDuplicateAndRestore(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeCustomManagedObjects")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterMissionObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterDuplicatedGuids")]
	[Calls(Type = typeof(MissionServicesManager), Member = "EliminateDuplicateAndRestore")]
	[CallerCount(Count = 2)]
	private void MaybeResumeStateOnDeserialize(MissionObjectIdentifier moi, CustomManagedObjectState stateInfo)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MaybeResumeStateOnDeserialize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void DeserializeCustomManagedObjects(MissionServicesManagerSaveProxy proxy)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(_003CPostSceneLoadCo_003Ed__115), Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendOrQueueEvent")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void SendEvent(EventData ev, string missionId)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SendEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendMissionEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "SendMissionEvent")]
	private void SendOrQueueEvent(EventData ev, string missionId)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RemoveMissionTimer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowMissionTimer")]
	private void RemoveMissionTimer(int timerIndex, bool postEvent = true)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionServicesManager), Member = "MissionCompleted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "DestroyMission")]
	private void ProcessRemoveMissionList()
	{
	}

	[Calls(Type = typeof(Variable), Member = "OnValueChanged")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void MissionCompleted(MissionManagerBase mm)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(MissionManagerBase), Member = "Stop")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	[CallsUnknownMethods(Count = 4)]
	private void DestroyMission(MissionManagerBase mm)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	private IEnumerator JumpCo(string missionName, bool isDeserialize, bool isDebug)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetAllActiveMissionNamesAsString")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[CallsUnknownMethods(Count = 3)]
	private Node GetActiveNode(string mission)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private int RecursiveActionListCounter(ActionList actionList)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetNodeActiveActionCountRecursive")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private int GetSubNodeActionCountRecursive(Node node)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RecursiveActionListCounter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetSubNodeActionCountRecursive")]
	private int GetNodeActiveActionCountRecursive(Node node)
	{
		return default(int);
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	private void SetCurrentEpisode(string id)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool DoAnyFSMsHaveInvalidTags()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(SandboxManager), Member = ".ctor")]
	[CalledBy(Type = typeof(StoryManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	protected MissionServicesManager()
	{
	}
}
