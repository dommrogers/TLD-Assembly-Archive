using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

public class Switch : BTComposite
{
	public enum CaseSelectionMode
	{
		IndexBased,
		EnumBased
	}

	public enum OutOfRangeMode
	{
		ReturnFailure,
		LoopIndex
	}

	public bool dynamic;

	public CaseSelectionMode selectionMode;

	public BBParameter<int> intCase;

	public OutOfRangeMode outOfRangeMode;

	public BBObjectParameter enumCase;

	private int current;

	private int runningIndex;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[CallsUnknownMethods(Count = 6)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Switch()
	{
	}
}
