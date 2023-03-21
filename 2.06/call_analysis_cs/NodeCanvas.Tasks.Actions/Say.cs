using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Say : ActionTask<IDialogueActor>
{
	public Statement statement;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Statement), Member = "BlackboardReplace")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public Say()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
