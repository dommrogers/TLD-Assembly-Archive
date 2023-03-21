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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sequencer), Member = "Shuffle")]
	protected override void OnReset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphStarted()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Sequencer), Member = "OnReset")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private List<Connection> Shuffle(List<Connection> list)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public Sequencer()
	{
	}
}
