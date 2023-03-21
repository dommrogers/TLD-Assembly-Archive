using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class ProbabilitySelector : DTNode, ISubParametersContainer, ISubTasksContainer
{
	public class Option
	{
		public BBParameter<float> weight;

		public ConditionTask condition;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[Calls(Type = typeof(BBParameter), Member = "set_bb")]
		[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnChildConnected")]
		[CallsUnknownMethods(Count = 8)]
		public Option(float weightValue, IBlackboard bbValue)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Option, ConditionTask> _003C_003E9__5_0;

		public static Func<Option, BBParameter<float>> _003C_003E9__6_0;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal ConditionTask _003CGetSubTasks_003Eb__5_0(Option o)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal BBParameter<float> _003CGetSubParameters_003Eb__6_0(Option o)
		{
			return null;
		}
	}

	private List<Option> childOptions;

	private List<int> successIndeces;

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public BBParameter[] GetSubParameters()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Option), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void OnChildConnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void OnChildDisconnected(int index)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProbabilitySelector), Member = "GetTotal")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private float GetTotal()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public ProbabilitySelector()
	{
	}
}
