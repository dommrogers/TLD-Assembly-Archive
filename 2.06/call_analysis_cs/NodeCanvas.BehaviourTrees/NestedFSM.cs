using System;
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
		[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NestedFSM), Member = "CheckInstance")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	private void OnFSMFinish(bool success)
	{
	}

	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphPaused()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphStoped()
	{
	}

	[CalledBy(Type = typeof(NestedFSM), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private FSM CheckInstance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public NestedFSM()
	{
	}
}
