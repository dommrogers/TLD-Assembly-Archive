using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

public class NestedFSMState : FSMState, IGraphAssignable
{
	protected BBParameter<FSM> _nestedFSM;

	private Dictionary<FSM, FSM> instances;

	protected FSM currentInstance;

	public FSM nestedFSM
	{
		[CallerCount(Count = 20)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(NestedFSMState), Member = "CheckInstance")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(NestedFSMState), Member = "NodeCanvas.Framework.IGraphAssignable.set_nestedGraph")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(NestedFSMState), Member = "set_nestedFSM")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected override void OnExit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[Calls(Type = typeof(NestedFSMState), Member = "set_nestedFSM")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedFSMState), Member = "get_nestedFSM")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	protected FSM CheckInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = ".ctor")]
	public NestedFSMState()
	{
	}
}
