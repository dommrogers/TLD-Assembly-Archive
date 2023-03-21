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
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedBTState), Member = "CheckInstance")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnEnter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 1)]
	private void OnFinish(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	protected override void OnExit()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnPause()
	{
	}

	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
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
