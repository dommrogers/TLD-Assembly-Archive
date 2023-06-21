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
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BTDecorator), Member = "get_decoratedConnection")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
