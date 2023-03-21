using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Say : ActionTask<IDialogueActor>
{
	public Statement statement;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Substring")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Say()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
