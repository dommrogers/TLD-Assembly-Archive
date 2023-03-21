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
		return default(bool);
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ProcessInteraction")]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Show(string text, Action onButtonSelected)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideHoverButtonPrompts")]
	[CallsUnknownMethods(Count = 6)]
	public void Hide()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshButtonPrompt()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public GenericInteractionCancelUI()
	{
	}
}
