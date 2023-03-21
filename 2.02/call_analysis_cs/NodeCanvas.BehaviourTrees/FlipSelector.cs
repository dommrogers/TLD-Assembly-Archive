using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class FlipSelector : BTComposite
{
	private int current;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FlipSelector), Member = "SendToBack")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(FlipSelector), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 3)]
	private void SendToBack(int i)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public FlipSelector()
	{
	}
}
