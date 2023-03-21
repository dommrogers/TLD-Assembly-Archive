using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Repeater : BTDecorator
{
	public enum RepeaterMode
	{
		RepeatTimes,
		RepeatUntil,
		RepeatForever
	}

	public enum RepeatUntilStatus
	{
		Failure,
		Success
	}

	public RepeaterMode repeaterMode;

	public BBParameter<int> repeatTimes;

	public RepeatUntilStatus repeatUntilStatus;

	private int currentIteration;

	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public Repeater()
	{
	}
}
