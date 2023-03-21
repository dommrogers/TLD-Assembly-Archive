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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private ConditionTask condition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	public ConditionalEvaluator()
	{
	}
}
