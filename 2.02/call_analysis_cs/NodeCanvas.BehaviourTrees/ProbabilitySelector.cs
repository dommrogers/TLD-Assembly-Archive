using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class ProbabilitySelector : BTComposite
{
	public List<BBParameter<float>> childWeights;

	public BBParameter<float> failChance;

	public BBParameter<bool> synchronous;

	private float probability;

	private float currentProbability;

	private List<int> failedIndeces;

	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	public override void OnChildConnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnChildDisconnected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnGraphStarted()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ProbabilitySelector), Member = "GetTotal")]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ProbabilitySelector), Member = "GetTotal")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnReset()
	{
	}

	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnReset")]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private float GetTotal()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 35)]
	public ProbabilitySelector()
	{
	}
}
