using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericInteractionCancelUI : MonoBehaviour
{
	public Panel_HUD m_HUD;

	private string m_DisplayText;

	private Action m_OnButtonSelected;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Start()
	{
	}

	[CallerCount(Count = 55)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsShowing()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsUnknownMethods(Count = 4)]
	public void Show(string text, Action onButtonSelected)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CallerCount(Count = 2)]
	public void Hide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Update")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	private void RefreshButtonPrompt()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GenericInteractionCancelUI()
	{
	}
}
