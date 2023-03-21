using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GamepadButtonSprite : MonoBehaviour
{
	private string m_GamepadAction;

	private UISprite m_ButtonSprite;

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "RefreshGamepadButtons")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "UpdateControllerButtons")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	public void UpdateSpriteForActiveController(ButtonLegend legend)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableSprite(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableSpriteIfActionIs(string action, bool enable)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public GamepadButtonSprite()
	{
	}
}
