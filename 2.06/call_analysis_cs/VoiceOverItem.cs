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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence.ActorVoiceOverItem), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = ".ctor")]
	public VoiceOverItem()
	{
	}

	[CalledBy(Type = typeof(Action_PlayerSay), Member = "get_info")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	public string GetLocString()
	{
		return null;
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	public string GetLocId()
	{
		return null;
	}
}
