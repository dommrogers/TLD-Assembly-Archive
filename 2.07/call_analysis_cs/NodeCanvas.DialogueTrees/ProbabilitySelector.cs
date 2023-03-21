using System;
using System.Collections.Generic;
using System.Linq;
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

		[CalledBy(Type = typeof(ProbabilitySelector), Member = "OnChildConnected")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal BBParameter<float> _003CGetSubParameters_003Eb__6_0(Option o)
		{
			return null;
		}
	}

	private List<Option> childOptions;

	private List<int> successIndeces;

	public override int maxOutConnections
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 7)]
	public BBParameter[] GetSubParameters()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Option), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public override void OnChildConnected(int index)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 12)]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	private float GetTotal()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ProbabilitySelector()
	{
	}
}
