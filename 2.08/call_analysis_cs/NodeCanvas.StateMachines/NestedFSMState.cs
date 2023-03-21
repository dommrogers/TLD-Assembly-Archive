using System.Collections.Generic;
using System.Linq;
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

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
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
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	protected override void OnExit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	protected FSM CheckInstance()
	{
		return null;
	}

	[CalledBy(Type = typeof(State_StorySubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public NestedFSMState()
	{
	}
}
