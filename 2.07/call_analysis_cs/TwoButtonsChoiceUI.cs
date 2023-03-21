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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "MaybeShowTwoButtonsUI")]
	[CallsUnknownMethods(Count = 3)]
	public void ShowChoices(string textChoiceA, string textChoiceB, Action<int> onButtonSelected)
	{
	}

	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnButtonSelected")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CalledBy(Type = typeof(PlayableBehaviourWaitUserInput), Member = "OnButtonSelected")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	public void HideChoices()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "ShowChoices")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	private void RefreshChoices(bool gamepadActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TwoButtonsChoiceUI()
	{
	}
}
