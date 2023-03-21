using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Action_ShowChoice : DTNode
{
	public int choiceIndex;

	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Dialogue_Speech_Utils), Member = "GetShowChoiceVariableName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public Action_ShowChoice()
	{
	}
}
