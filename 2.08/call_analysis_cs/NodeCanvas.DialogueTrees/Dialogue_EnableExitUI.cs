using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_EnableExitUI : DTNode
{
	public bool enableExitUI;

	public override string name
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public Dialogue_EnableExitUI()
	{
	}
}
