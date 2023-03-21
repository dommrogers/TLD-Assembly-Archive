using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.DialogueTrees;

public class MultipleChoiceRequestInfo
{
	public IDialogueActor actor;

	public Dictionary<IStatement, int> options;

	public float availableTime;

	public bool showLastStatement;

	public Action<int> SelectOption;

	[CallerCount(Count = 0)]
	public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, bool showLastStatement, Action<int> callback)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	public MultipleChoiceRequestInfo(IDialogueActor actor, Dictionary<IStatement, int> options, float availableTime, Action<int> callback)
	{
	}
}
