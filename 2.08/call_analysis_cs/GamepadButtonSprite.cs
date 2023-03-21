using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GamepadButtonSprite : MonoBehaviour
{
	private string m_GamepadAction;

	private UISprite m_ButtonSprite;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "RefreshGamepadButtons")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "UpdateControllerButtons")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	public void UpdateSpriteForActiveController(ButtonLegend legend)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableSprite(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void EnableSpriteIfActionIs(string action, bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GamepadButtonSprite()
	{
	}
}
