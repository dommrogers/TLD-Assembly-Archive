using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Sequencer : BTComposite
{
	public bool dynamic;

	public bool random;

	private int lastRunningNodeIndex;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnChildDisconnected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	private List<Connection> Shuffle(List<Connection> list)
	{
		return null;
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Sequencer()
	{
	}
}
