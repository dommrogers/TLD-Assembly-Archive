using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.DialogueTrees;

public class SubtitlesRequestInfo
{
	public IDialogueActor actor;

	public IStatement statement;

	public Action Continue;

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public SubtitlesRequestInfo(IDialogueActor actor, IStatement statement, Action callback)
	{
	}
}
