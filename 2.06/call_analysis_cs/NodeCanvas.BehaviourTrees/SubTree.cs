using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class SubTree : BTNode, IGraphAssignable
{
	private BBParameter<BehaviourTree> _subTree;

	private Dictionary<BehaviourTree, BehaviourTree> instances;

	private BehaviourTree currentInstance;

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

	public BehaviourTree subTree
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Graph[] NodeCanvas_002EFramework_002EIGraphAssignable_002EGetInstances()
	{
		return null;
	}

	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SubTree), Member = "CheckInstance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnReset()
	{
	}

	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public override void OnGraphPaused()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphStoped()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SubTree()
	{
	}
}
