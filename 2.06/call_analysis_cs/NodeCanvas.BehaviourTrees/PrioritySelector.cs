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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	public override void OnChildConnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnChildDisconnected(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 12)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 11)]
	public PrioritySelector()
	{
	}
}
