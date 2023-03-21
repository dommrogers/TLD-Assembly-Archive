using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetDialogueFraming : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<string> dialogueframing;

	[Calls(Type = typeof(DialogueModeRigFP), Member = "ReplaceCameraFraming")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SetDialogueFraming()
	{
	}
}
