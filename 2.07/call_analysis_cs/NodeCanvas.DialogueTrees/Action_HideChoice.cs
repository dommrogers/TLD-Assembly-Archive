using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Action_HideChoice : DTNode
{
	public int choiceIndex;

	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(Dialogue_Speech_Utils), Member = "GetShowChoiceVariableName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_HideChoice()
	{
	}
}
