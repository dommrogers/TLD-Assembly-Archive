using System;
using System.Collections.Generic;
using System.Linq;
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(NestedFSM), Member = "CheckInstance")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	private void OnFSMFinish(bool success)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnReset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	public override void OnGraphPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	public override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	private FSM CheckInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public NestedFSM()
	{
	}
}
