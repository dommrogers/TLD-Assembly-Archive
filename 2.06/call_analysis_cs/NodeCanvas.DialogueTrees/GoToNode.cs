using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class GoToNode : DTNode
{
	private DTNode _targetNode;

	public override int maxOutConnections
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "EnterNode")]
	[Calls(Type = typeof(Node), Member = "Error")]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public GoToNode()
	{
	}
}
