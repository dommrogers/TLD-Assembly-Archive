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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnInit")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "AddCustomManagedObject")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
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

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[Calls(Type = typeof(GraphOwner), Member = "StartBehaviour")]
	[Calls(Type = typeof(MissionManagerBase), Member = "PreRegisterChildGraph")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Graph), Member = "add_onFinish")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = "OnEnter")]
	[Calls(Type = typeof(NCUtils), Member = "SpawnChildGraph")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[Calls(Type = typeof(NCUtils), Member = "SetInitialStateByTag")]
	[Calls(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[Calls(Type = typeof(FSMHierarchy), Member = "SetFSMForRank")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
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

	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[Calls(Type = typeof(ActionTask), Member = "PauseAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected void OnChildGraphComplete(bool success)
	{
	}

	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RemoveSubFSMOwnerVar")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "RemoveSubFSMOwnerVar")]
	[Calls(Type = typeof(NCUtils), Member = "GetMissionManagerForFSM")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	protected override void OnExit()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	private void RegisterAsSubFSMOwner(Graph _graph)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnExit")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "LookupConcurrentGraph")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveConcurrentGraph")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AddCustomManagedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "RemoveCustomManagedObject")]
	[CallsUnknownMethods(Count = 1)]
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
