using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class TwoButtonsChoiceUI : MonoBehaviour
{
	private Action<int> m_OnButtonSelected;

	private string m_FireButtonStr;

	private string m_AltFireButtonStr;

	[DeduplicatedMethod]
	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsShowing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsManagingInput()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	public void ShowChoices(string textChoiceA, string textChoiceB, Action<int> onButtonSelected)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideHoverButtonPrompts")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnButtonSelected")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnButtonSelected")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateHUDText")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	public void HideChoices()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	private void RefreshChoices(bool gamepadActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TwoButtonsChoiceUI()
	{
	}
}
