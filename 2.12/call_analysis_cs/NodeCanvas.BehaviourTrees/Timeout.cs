using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Timeout : BTDecorator
{
	public BBParameter<float> timeout;

	private float timer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 1)]
	public Timeout()
	{
	}
}
