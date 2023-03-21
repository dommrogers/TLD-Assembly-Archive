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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "GetNodesWithTag")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 28)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public NodeToggler()
	{
	}
}
