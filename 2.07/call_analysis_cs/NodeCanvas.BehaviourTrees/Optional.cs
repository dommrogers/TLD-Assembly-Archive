using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Optional : BTDecorator
{
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Optional()
	{
	}
}
