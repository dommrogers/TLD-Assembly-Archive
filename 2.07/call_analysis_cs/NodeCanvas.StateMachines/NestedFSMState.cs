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
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NestedFSMState), Member = "CheckInstance")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = "OnEnter")]
	protected override void OnEnter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExit()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	protected FSM CheckInstance()
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_CinematicSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_GameplaySubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_SandboxSubFSM), Member = ".ctor")]
	[CalledBy(Type = typeof(State_StorySubFSM), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public NestedFSMState()
	{
	}
}
