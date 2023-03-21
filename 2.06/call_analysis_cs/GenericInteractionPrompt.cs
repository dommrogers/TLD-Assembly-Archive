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

	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	public void PrepareInteraction(bool essentialInteraction = true, Action<bool> onInputStatusChanged = null)
	{
	}

	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "InitializeInteraction")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowInteraction(string interactionText, string action, bool promptEnabled = true)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "GetNextFreeButtonPrompt")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ShowInteraction(string interactionText, string action, Color disabledColor, bool promptEnabled = true)
	{
	}

	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "PrepareInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "DestroyInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "Move")]
	[CalledBy(Type = typeof(Elevator), Member = "CommenceExitPlayer")]
	[CalledBy(Type = typeof(InteractiveLightsource), Member = "HideInteraction")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void HideInteraction()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsShowing()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void DestroyInteraction()
	{
	}

	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 16)]
	private ButtonPrompt GetNextFreeButtonPrompt()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "RefreshButtonPrompts")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshButtonPrompts()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public GenericInteractionPrompt()
	{
	}
}
