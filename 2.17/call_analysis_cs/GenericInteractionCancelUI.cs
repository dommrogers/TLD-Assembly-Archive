using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericInteractionCancelUI : MonoBehaviour
{
	public Panel_HUD m_HUD;

	private string m_DisplayText;

	private Action m_OnButtonSelected;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 57)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsShowing()
	{
		return false;
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "PerformInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Show(string text, Action onButtonSelected)
	{
	}

	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "HideInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshButtonPrompt()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GenericInteractionCancelUI()
	{
	}
}
