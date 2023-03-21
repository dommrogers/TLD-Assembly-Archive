using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Say : ActionTask<IDialogueActor>
{
	public Statement statement;

	protected override string info
	{
		[CallsUnknownMethods(Count = 5)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Say()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
