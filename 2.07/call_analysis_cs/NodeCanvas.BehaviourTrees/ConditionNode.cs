using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class ConditionNode : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	private ConditionTask _condition;

	public Task task
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	public ConditionTask condition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public override string name
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public ConditionNode()
	{
	}
}
