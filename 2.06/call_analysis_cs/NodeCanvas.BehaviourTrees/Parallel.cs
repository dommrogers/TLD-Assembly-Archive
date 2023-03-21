using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Parallel : BTComposite
{
	public enum ParallelPolicy
	{
		FirstFailure,
		FirstSuccess,
		FirstSuccessOrFailure
	}

	public ParallelPolicy policy;

	public bool dynamic;

	private readonly List<Connection> finishedConnections;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[Calls(Type = typeof(Parallel), Member = "ResetRunning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnReset()
	{
	}

	[CalledBy(Type = typeof(Parallel), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void ResetRunning()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Parallel()
	{
	}
}
