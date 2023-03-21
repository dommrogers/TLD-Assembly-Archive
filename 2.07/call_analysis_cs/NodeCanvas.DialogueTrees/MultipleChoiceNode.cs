using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class MultipleChoiceNode : DTNode, ISubTasksContainer
{
	[Serializable]
	public class Choice
	{
		public bool isUnfolded;

		public Statement statement;

		public ConditionTask condition;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public Choice()
		{
		}

		[CallerCount(Count = 0)]
		public Choice(Statement statement)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Choice, ConditionTask> _003C_003E9__4_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal ConditionTask _003CGetSubTasks_003Eb__4_0(Choice c)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public MultipleChoiceNode _003C_003E4__this;

		public int index;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
		[Calls(Type = typeof(DialogueTree), Member = "Continue")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003COnOptionSelected_003Eb__0()
		{
		}
	}

	public float availableTime;

	public bool saySelection;

	private List<Choice> availableChoices;

	public override int maxOutConnections
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public override bool requireActorSelection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestMultipleChoices")]
	[Calls(Type = typeof(MultipleChoiceRequestInfo), Member = ".ctor")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	private void OnOptionSelected(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public MultipleChoiceNode()
	{
	}
}
