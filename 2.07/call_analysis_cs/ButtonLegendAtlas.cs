using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using UnityEngine;

public class ButtonLegendAtlas : ScriptableObject
{
	public UIAtlas m_ButtonIconAtlasXbox;

	public UIAtlas m_ButtonIconAtlasSteam;

	public UIAtlas m_ButtonIconAtlasPS4;

	public UIAtlas m_ButtonIconAtlasSwitch;

	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionaryXbox;

	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionarySteam;

	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionaryPS4;

	private Dictionary<string, ButtonIcon> m_ButtonIconsDictionarySwitch;

	[CalledBy(Type = typeof(ButtonLegend), Member = "Awake")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "AdjustSteamDictionary")]
	public void BuildDictionaries()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	private Dictionary<string, ButtonIcon> BuildDictionary(Dictionary<string, string> input, UIAtlas atlas)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsUnknownMethods(Count = 10)]
	private void AdjustSteamDictionary(Dictionary<string, ButtonIcon> dictionary)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "GetButtonIconSpriteName")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	public ButtonIcon GetButtonIcon(string action)
	{
		return null;
	}

	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingPS4ControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingSteamControllerDisconnectedPanel")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 1)]
	private Dictionary<string, ButtonIcon> GetActiveDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public ButtonLegendAtlas()
	{
	}
}
