using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class FinishNode : DTNode
{
	public CompactStatus finishState;

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
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public FinishNode()
	{
	}
}
