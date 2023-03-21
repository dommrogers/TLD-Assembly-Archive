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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Node), Member = "Reset")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BBObjectParameter), Member = ".ctor")]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public Switch()
	{
	}
}
