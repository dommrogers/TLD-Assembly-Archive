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

	[Calls(Type = typeof(Parallel), Member = "ResetRunning")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Parallel), Member = "ResetRunning")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Connection), Member = "Execute")]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Parallel), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	private void ResetRunning()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Parallel()
	{
	}
}
