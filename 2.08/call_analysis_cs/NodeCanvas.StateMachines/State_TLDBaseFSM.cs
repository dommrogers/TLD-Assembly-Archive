using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class State_TLDBaseFSM : NestedFSMState, ITaskAssignable, ITLDConcurrentGraphOwner, ITLDCustomManagedObjectOwner, ITLDChildGraphOwner
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
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public ActionList actionList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnInit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "AddCustomManagedObject")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	private void Initialize()
	{
	}

	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CallerCount(Count = 0)]
	protected override void OnInit()
	{
	}

	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MissionManagerBase), Member = "PreRegisterChildGraph")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Graph), Member = "add_onFinish")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(NCUtils), Member = "SpawnChildGraph")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GraphOwner GetChildGraphOwner()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RemoveSubFSMOwnerVar")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RemoveSubFSMOwnerVar")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	protected override void OnExit()
	{
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RegisterAsSubFSMOwner(Graph _graph)
	{
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void RemoveSubFSMOwnerVar(Graph _graph)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CallsUnknownMethods(Count = 2)]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
