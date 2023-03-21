using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	public bool isDynamic;

	private ConditionTask _condition;

	private bool accessed;

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private ConditionTask condition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public ConditionalEvaluator()
	{
	}
}
