using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class NestedBTState : FSMState, IGraphAssignable
{
	public enum BTExecutionMode
	{
		Once,
		Repeat
	}

	public enum BTExitMode
	{
		StopAndRestart,
		PauseAndResume
	}

	private BBParameter<BehaviourTree> _nestedBT;

	public BTExecutionMode executionMode;

	public BTExitMode exitMode;

	public string successEvent;

	public string failureEvent;

	private Dictionary<BehaviourTree, BehaviourTree> instances;

	private BehaviourTree currentInstance;

	public BehaviourTree nestedBT
	{
		[DeduplicatedMethod]
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

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NestedBTState), Member = "CheckInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	private void OnFinish(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallerCount(Count = 0)]
	protected override void OnExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 6)]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public NestedBTState()
	{
	}
}
