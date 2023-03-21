using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class BinarySelector : BTNode, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	public bool dynamic;

	private ConditionTask _condition;

	private int succeedIndex;

	public override int maxOutConnections
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public override Alignment2x2 commentsAlignment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Alignment2x2);
		}
	}

	public override string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
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

	private ConditionTask condition
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	public BinarySelector()
	{
	}
}
