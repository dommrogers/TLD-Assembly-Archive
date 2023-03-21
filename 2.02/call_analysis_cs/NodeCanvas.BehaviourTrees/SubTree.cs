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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(SubTree), Member = "CheckInstance")]
		[CalledBy(Type = typeof(SubTree), Member = "CheckInstance")]
		[CalledBy(Type = typeof(SubTree), Member = "CheckInstance")]
		[CalledBy(Type = typeof(SubTree), Member = "CheckInstance")]
		[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
		[CalledBy(Type = typeof(SubTree), Member = "NodeCanvas.Framework.IGraphAssignable.get_nestedGraph")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(SubTree), Member = "NodeCanvas.Framework.IGraphAssignable.set_nestedGraph")]
		[CalledBy(Type = typeof(SubTree), Member = "CheckInstance")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private Graph NodeCanvas_002EFramework_002EIGraphAssignable_002EnestedGraph
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubTree), Member = "get_subTree")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(SubTree), Member = "set_subTree")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SubTree), Member = "get_subTree")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(SubTree), Member = "get_subTree")]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(SubTree), Member = "CheckInstance")]
	[Calls(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 5)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphPaused()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public override void OnGraphStoped()
	{
	}

	[Calls(Type = typeof(SubTree), Member = "get_subTree")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SubTree), Member = "OnExecute")]
	[Calls(Type = typeof(SubTree), Member = "set_subTree")]
	[Calls(Type = typeof(SubTree), Member = "get_subTree")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(SubTree), Member = "get_subTree")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SubTree), Member = "get_subTree")]
	private BehaviourTree CheckInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public SubTree()
	{
	}
}
