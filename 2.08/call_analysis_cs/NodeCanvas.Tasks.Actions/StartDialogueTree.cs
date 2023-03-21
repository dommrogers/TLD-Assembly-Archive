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
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueTreeController), Member = "StartDialogue")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public StartDialogueTree()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
