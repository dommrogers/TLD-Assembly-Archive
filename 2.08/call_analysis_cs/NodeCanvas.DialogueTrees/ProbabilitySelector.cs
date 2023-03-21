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
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
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
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 7)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Option), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	public override void OnChildConnected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void OnChildDisconnected(int index)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private float GetTotal()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	protected override void OnReset()
	{
	}

	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ProbabilitySelector()
	{
	}
}
