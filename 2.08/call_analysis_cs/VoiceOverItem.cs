using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;

[Serializable]
public class VoiceOverItem
{
	private string LocIDValue;

	public string speech;

	public BBParameter<string> LocID;

	public bool m_IsUnknownSpeaker;

	public VoiceOverAnimationState m_VoiceOverAnimation;

	public float m_Duration;

	public float m_AfterDuration;

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = ".ctor")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public VoiceOverItem()
	{
	}

	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_PlayerSay), Member = "get_info")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CallerCount(Count = 5)]
	public string GetLocString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	public string GetLocId()
	{
		return null;
	}
}
