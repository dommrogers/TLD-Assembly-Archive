using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class NestedFSMState : FSMState, IGraphAssignable
{
	protected BBParameter<FSM> _nestedFSM;

	private Dictionary<FSM, FSM> instances;

	protected FSM currentInstance;

	public FSM nestedFSM
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.Linq.Buffer`1", Member = ".ctor")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Graph), Member = "Clone")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected FSM CheckInstance()
	{
		return null;
	}

	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public NestedFSMState()
	{
	}
}
