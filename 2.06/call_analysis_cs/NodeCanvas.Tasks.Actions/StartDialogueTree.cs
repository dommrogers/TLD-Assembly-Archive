using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class StartDialogueTree : ActionTask<IDialogueActor>
{
	public BBParameter<DialogueTreeController> dialogueTreeController;

	public bool waitActionFinish;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public StartDialogueTree()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
