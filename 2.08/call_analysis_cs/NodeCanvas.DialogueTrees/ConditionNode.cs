using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class ConditionNode : DTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	private ConditionTask _condition;

	public ConditionTask condition
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		set
		{
		}
	}

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

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override bool requireActorSelection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public ConditionNode()
	{
	}
}
