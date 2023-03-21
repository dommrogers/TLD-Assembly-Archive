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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void Awake()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "ShowHoverButtonPrompts")]
	public void PrepareInteraction(bool essentialInteraction = true, Action<bool> onInputStatusChanged = null)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	public void ShowInteraction(string interactionText, string action, bool promptEnabled = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CallsUnknownMethods(Count = 3)]
	public void ShowInteraction(string interactionText, string action, Color disabledColor, bool promptEnabled = true)
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "HideHoverButtonPrompts")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "DestroyInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 8)]
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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	public void DestroyInteraction()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallsUnknownMethods(Count = 12)]
	private ButtonPrompt GetNextFreeButtonPrompt()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "RefreshButtonPrompts")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshButtonPrompts()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public GenericInteractionPrompt()
	{
	}
}
