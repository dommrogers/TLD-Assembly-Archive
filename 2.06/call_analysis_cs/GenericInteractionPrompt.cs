using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericInteractionPrompt : MonoBehaviour
{
	private const int PROMPT_WARNING_COUNT = 4;

	public ButtonPrompt m_ButtonPromptPrefab;

	public UIGrid m_Grid;

	public Color m_DefaultDisabledColor;

	private List<ButtonPrompt> m_SpawnedPrompts;

	private bool m_CurrentInteractionState;

	private bool m_IsEssentialInteraction;

	private HudDisplayMode m_HudDisplayMode;

	private Action<bool> m_OnInputStatusChanged;

	private bool m_IsShowing;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	public void PrepareInteraction(bool essentialInteraction = true, Action<bool> onInputStatusChanged = null)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	public void ShowInteraction(string interactionText, string action, bool promptEnabled = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowInteraction(string interactionText, string action, Color disabledColor, bool promptEnabled = true)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "HideInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "DestroyInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsShowing()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	public void DestroyInteraction()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallsUnknownMethods(Count = 16)]
	private ButtonPrompt GetNextFreeButtonPrompt()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "RefreshButtonPrompts")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshButtonPrompts()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public GenericInteractionPrompt()
	{
	}
}
