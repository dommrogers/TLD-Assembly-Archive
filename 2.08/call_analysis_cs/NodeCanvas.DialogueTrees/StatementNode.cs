using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class StatementNode : DTNode
{
	private Statement statement;

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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 1)]
	private void OnStatementFinish()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public StatementNode()
	{
	}
}
