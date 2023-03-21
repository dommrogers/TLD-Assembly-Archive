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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	public override void OnChildConnected(int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public PrioritySelector()
	{
	}
}
