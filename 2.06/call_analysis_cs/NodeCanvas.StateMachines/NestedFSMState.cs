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
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 8)]
	protected override void OnEnter()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected override void OnExit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "set_blackboard")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 6)]
	protected FSM CheckInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = ".ctor")]
	public NestedFSMState()
	{
	}
}
