using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using UnityEngine;

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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 2)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NestedBTState), Member = "CheckInstance")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	protected override void OnEnter()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 11)]
	private void OnFinish(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	protected override void OnExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public NestedBTState()
	{
	}
}
