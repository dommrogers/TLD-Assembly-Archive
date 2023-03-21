using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class RootSwitcher : BTNode
{
	public string targetNodeTag;

	private Node targetNode;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graph), Member = "get_primeNode")]
	[Calls(Type = typeof(Graph), Member = "set_primeNode")]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public RootSwitcher()
	{
	}
}
