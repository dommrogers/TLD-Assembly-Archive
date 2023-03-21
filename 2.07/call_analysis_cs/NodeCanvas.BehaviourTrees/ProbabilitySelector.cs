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

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnChildConnected(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void OnGraphStarted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Connection), Member = "Execute")]
	[Calls(Type = typeof(ProbabilitySelector), Member = "GetTotal")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 10)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Calls(Type = typeof(ProbabilitySelector), Member = "GetTotal")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnReset")]
	[CallsUnknownMethods(Count = 6)]
	private float GetTotal()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public ProbabilitySelector()
	{
	}
}
