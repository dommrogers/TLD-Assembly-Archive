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
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(NestedBTState), Member = "NodeCanvas.Framework.IGraphAssignable.get_nestedGraph")]
		[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedBTState), Member = "NodeCanvas.Framework.IGraphAssignable.set_nestedGraph")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(NestedBTState), Member = "set_nestedBT")]
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

	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedBTState), Member = "CheckInstance")]
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

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnFinish(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExit()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnPause()
	{
	}

	[Calls(Type = typeof(NestedBTState), Member = "set_nestedBT")]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	public NestedBTState()
	{
	}
}
