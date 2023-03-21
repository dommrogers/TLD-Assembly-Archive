using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericInteractionCancelUI : MonoBehaviour
{
	public Panel_HUD m_HUD;

	private string m_DisplayText;

	private Action m_OnButtonSelected;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsShowing()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	public void Show(string text, Action onButtonSelected)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	public void Hide()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "Show")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButton")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	private void RefreshButtonPrompt()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GenericInteractionCancelUI()
	{
	}
}
