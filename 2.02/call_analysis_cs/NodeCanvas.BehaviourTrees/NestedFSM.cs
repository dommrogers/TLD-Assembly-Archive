using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class NestedFSM : BTNode, IGraphAssignable
{
	private BBParameter<FSM> _nestedFSM;

	private Dictionary<FSM, FSM> instances;

	private FSM currentInstance;

	public string successState;

	public string failureState;

	public override string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public FSM nestedFSM
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(NestedFSM), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedFSM), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedFSM), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedFSM), Member = "CheckInstance")]
		[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
		[CalledBy(Type = typeof(NestedFSM), Member = "NodeCanvas.Framework.IGraphAssignable.get_nestedGraph")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(NestedFSM), Member = "NodeCanvas.Framework.IGraphAssignable.set_nestedGraph")]
		[CalledBy(Type = typeof(NestedFSM), Member = "CheckInstance")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(NestedFSM), Member = "set_nestedFSM")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[Calls(Type = typeof(NestedFSM), Member = "CheckInstance")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	private void OnFSMFinish(bool success)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	protected override void OnReset()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSM), Member = "get_nestedFSM")]
	[Calls(Type = typeof(NestedFSM), Member = "set_nestedFSM")]
	[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private FSM CheckInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public NestedFSM()
	{
	}
}
