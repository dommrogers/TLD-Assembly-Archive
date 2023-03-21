using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using Parlay;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class ParlayNPCResponseNode : DTNode
{
	[Serializable]
	public class Choice
	{
		public bool isUnfolded;

		public StateOfMind stateOfMind;

		public Statement statement;

		public ConditionTask condition;

		public string testString;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Choice()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		public Choice(Statement statement)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Choice, ConditionTask> _003C_003E9__1_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal ConditionTask _003CGetSubTasks_003Eb__1_0(Choice c)
		{
			return null;
		}
	}

	public List<Choice> availableChoices;

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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 7)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public ParlayNPCResponseNode()
	{
	}

	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 1)]
	private void OnStatementFinish()
	{
	}
}
