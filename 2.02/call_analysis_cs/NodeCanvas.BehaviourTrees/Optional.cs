using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Optional : BTDecorator
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public Optional()
	{
	}
}
