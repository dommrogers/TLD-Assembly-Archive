using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GamepadButtonSprite : MonoBehaviour
{
	private string m_GamepadAction;

	private UISprite m_ButtonSprite;

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateControllerButtons")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshGamepadButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateButtonStates")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "UpdateControllerButtons")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void UpdateSpriteForActiveController(ButtonLegend legend)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableSprite(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableAllLBRBButtons")]
	[CallsUnknownMethods(Count = 3)]
	public void EnableSpriteIfActionIs(string action, bool enable)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GamepadButtonSprite()
	{
	}
}
