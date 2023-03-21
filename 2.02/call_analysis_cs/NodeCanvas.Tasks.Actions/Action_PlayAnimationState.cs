using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayAnimationState : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<string> animationState;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "FindDialogueModeRigFp")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_PlayAnimationState()
	{
	}
}
