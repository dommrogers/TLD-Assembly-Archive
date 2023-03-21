using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class TwoButtonsChoiceUI : MonoBehaviour
{
	public Panel_HUD m_HUD;

	private Action<int> m_OnButtonSelected;

	private string m_FireButtonStr;

	private string m_AltFireButtonStr;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsShowing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsManagingInput()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPlay")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	public void ShowChoices(string textChoiceA, string textChoiceB, Action<int> onButtonSelected)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnButtonSelected")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnButtonSelected")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	public void HideChoices()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	private void RefreshChoices(bool gamepadActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TwoButtonsChoiceUI()
	{
	}
}
