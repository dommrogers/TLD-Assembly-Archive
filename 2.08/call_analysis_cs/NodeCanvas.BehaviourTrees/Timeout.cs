using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Timeout : BTDecorator
{
	public BBParameter<float> timeout;

	private float timer;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnReset()
	{
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Timeout()
	{
	}
}
