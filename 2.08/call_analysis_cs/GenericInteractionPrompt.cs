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

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	public void PrepareInteraction(bool essentialInteraction = true, Action<bool> onInputStatusChanged = null)
	{
	}

	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowInteraction(string interactionText, string action, bool promptEnabled = true)
	{
	}

	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowInteraction(string interactionText, string action, Color disabledColor, bool promptEnabled = true)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "HideInteraction")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "DestroyInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	public void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsShowing()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 6)]
	public void DestroyInteraction()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	private ButtonPrompt GetNextFreeButtonPrompt()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "RefreshButtonPrompts")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshButtonPrompts()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GenericInteractionPrompt()
	{
	}
}
