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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public override Alignment2x2 commentsAlignment
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Alignment2x2);
		}
	}

	public override string name
	{
		[Calls(Type = typeof(string), Member = "ToUpper")]
		[Calls(Type = typeof(Node), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Task task
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 8)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public BinarySelector()
	{
	}
}
