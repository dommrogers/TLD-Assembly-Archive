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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "Awake")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "AdjustSteamDictionary")]
	public void BuildDictionaries()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	private Dictionary<string, ButtonIcon> BuildDictionary(Dictionary<string, string> input, UIAtlas atlas)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void AdjustSteamDictionary(Dictionary<string, ButtonIcon> dictionary)
	{
	}

	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "GetButtonIconSpriteName")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	public ButtonIcon GetButtonIcon(string action)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingSteamControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingPS4ControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	private Dictionary<string, ButtonIcon> GetActiveDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ButtonLegendAtlas()
	{
	}
}
