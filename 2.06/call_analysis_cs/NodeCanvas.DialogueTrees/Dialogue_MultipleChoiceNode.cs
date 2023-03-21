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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
		public Choice()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
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
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(Graph), Member = "Stop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Dialogue_Speech_Utils), Member = "GetShowChoiceVariableName")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SetDialogueTreeChoices")]
	[Calls(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(Node), Member = "Error")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 121)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnExitRequested()
	{
	}

	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocString")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	private void MaybeShowTwoButtonsUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnChoiceSelected")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsUnknownMethods(Count = 3)]
	private void OnButtonSelected(int buttonSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	public Dialogue_MultipleChoiceNode()
	{
	}
}
