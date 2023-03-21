using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GamepadButtonSprite : MonoBehaviour
{
	private string m_GamepadAction;

	private UISprite m_ButtonSprite;

	[CalledBy(Type = typeof(Panel_List<, >), Member = "UpdateControllerButtons")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void UpdateSpriteForActiveController(ButtonLegend legend)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableSprite(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnableSpriteIfActionIs(string action, bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GamepadButtonSprite()
	{
	}
}
