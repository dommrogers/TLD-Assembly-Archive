using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class NodeToggler : BTNode
{
	public enum ToggleMode
	{
		Enable,
		Disable,
		Toggle
	}

	public ToggleMode toggleMode;

	public string targetNodeTag;

	private List<Node> targetNodes;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 27)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public NodeToggler()
	{
	}
}
