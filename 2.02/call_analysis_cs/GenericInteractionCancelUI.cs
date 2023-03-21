using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericInteractionCancelUI : MonoBehaviour
{
	private string m_DisplayText;

	private Action m_OnButtonSelected;

	[DeduplicatedMethod]
	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsShowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void Show(string text, Action onButtonSelected)
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideHoverButtonPrompts")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshButtonPrompt()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GenericInteractionCancelUI()
	{
	}
}
