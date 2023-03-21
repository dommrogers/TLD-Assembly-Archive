using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_MultipleChoiceNode : DTNode
{
	public enum ChoiceCategory
	{
		None = 0,
		MissionUnlockAvailable = 6,
		New = 7,
		NewMissionUnlockAvailable = 8
	}

	[Serializable]
	public class Choice
	{
		public bool isUnfolded;

		public bool isHidden;

		public DialogueOptionTopic topic;

		public ChoiceCategory category;

		public VoiceOverItem statement;

		public ConditionTask condition;

		public ConditionTask showChoiceCondition;

		public BBParameter<float> textSize;

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public Choice()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public Choice(VoiceOverItem statement)
		{
		}
	}

	private bool m_DialogueChoicesSpecified;

	private List<string> m_LocalizedChoices;

	private List<ChoiceCategory> m_CategoryChoices;

	private List<DialogueOptionTopic> m_TopicChoices;

	private Dictionary<int, int> m_LocalizedChoicesMapToAvailableChoices;

	private PanelReference<Panel_HUD> m_HUD;

	public float availableTime;

	public bool saySelection;

	public bool useEndingChoice;

	public int endingChoiceIndex;

	public bool enableExitUI;

	public bool useTwoButtonUI;

	public List<Choice> availableChoices;

	private bool m_ExitRequested;

	private bool m_ChoiceSelected;

	private bool m_EndingChoicePending;

	private PlayerControlMode m_PreviousControlMode;

	private bool m_HasSetEnableExit;

	public override int maxOutConnections
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void OnChildConnected(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void OnChildDisconnected(int index)
	{
	}

	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(Dialogue_Speech_Utils), Member = "GetShowChoiceVariableName")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnExitRequested()
	{
	}

	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeShowTwoButtonsUI()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnChoiceSelected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void OnButtonSelected(int buttonSelected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Dialogue_MultipleChoiceNode()
	{
	}
}
