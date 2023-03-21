using System.Collections.Generic;
using System.Linq;
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
		[CalledBy(Type = typeof(NestedBTState), Member = "NodeCanvas.Framework.IGraphAssignable.get_nestedGraph")]
		[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(NestedBTState), Member = "NodeCanvas.Framework.IGraphAssignable.set_nestedGraph")]
		[CalledBy(Type = typeof(NestedBTState), Member = "CheckInstance")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[Calls(Type = typeof(NestedBTState), Member = "set_nestedBT")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedBTState), Member = "CheckInstance")]
	[Calls(Type = typeof(Node), Member = "get_graphAgent")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void OnFinish(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnPause()
	{
	}

	[CalledBy(Type = typeof(NestedBTState), Member = "OnEnter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NestedBTState), Member = "get_nestedBT")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Graph), Member = "Clone")]
	[Calls(Type = typeof(NestedBTState), Member = "set_nestedBT")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public NestedBTState()
	{
	}
}
