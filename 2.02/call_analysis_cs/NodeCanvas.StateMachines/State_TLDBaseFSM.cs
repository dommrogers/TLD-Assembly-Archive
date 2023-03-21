using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class State_TLDBaseFSM : NestedFSMState, ITLDCustomManagedObjectOwner, ITLDChildGraphOwner, ITaskAssignable, ITLDConcurrentGraphOwner
{
	public BBParameter<GameObject> childFsmPrefab;

	private List<string> m_ConcurrentGraphs;

	private List<string> m_CustomManagedObjects;

	private ActionList _actionList;

	private bool _repeatStateActions;

	private GameObject childGraphObject;

	private FSMHierarchy.Rank m_NestedFSMRank;

	private bool initialized;

	private bool inState;

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ActionList actionList
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	public GameObject childGraphPrefab
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public bool repeatStateActions
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "AddCustomManagedObject")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterConcurrentGraph")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnInit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(MissionManagerBase), Member = "PreRegisterChildGraph")]
	[Calls(Type = typeof(NCUtils), Member = "SpawnChildGraph")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Graph), Member = "add_onFinish")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(MissionManagerBase), Member = "GetNextJumpToId")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	protected override void OnEnter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public GraphOwner GetChildGraphOwner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void OnChildGraphComplete(bool success)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RemoveSubFSMOwnerVar")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RemoveSubFSMOwnerVar")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	protected override void OnExit()
	{
	}

	[Calls(Type = typeof(FSMDictionaryVarType), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private void RegisterAsSubFSMOwner(Graph _graph)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveSubFSMOwnerVar(Graph _graph)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveCustomManagedObject(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedFSMState), Member = ".ctor")]
	public State_TLDBaseFSM()
	{
	}
}
