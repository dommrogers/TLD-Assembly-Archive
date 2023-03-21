using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_Cinematic : DTNode
{
	public DialogueAnimationState m_DialogueAnimationState;

	public TextAsset m_SubtitleAsset;

	public string m_AudioEventStart;

	public string m_AudioEventStop;

	public string m_DebugDialogueAnimationStateName;

	public override string name
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CallsUnknownMethods(Count = 1)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	private void OnCinematicFinish()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	public Dialogue_Cinematic()
	{
	}
}
