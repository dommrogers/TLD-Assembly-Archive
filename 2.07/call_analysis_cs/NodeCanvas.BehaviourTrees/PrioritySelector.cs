using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class PrioritySelector : BTComposite
{
	public List<BBParameter<float>> priorities;

	private List<Connection> orderedConnections;

	private int current;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnChildConnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func<, >), Member = ".ctor")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public PrioritySelector()
	{
	}
}
