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

	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "Awake")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "AdjustSteamDictionary")]
	public void BuildDictionaries()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallsUnknownMethods(Count = 17)]
	private Dictionary<string, ButtonIcon> BuildDictionary(Dictionary<string, string> input, UIAtlas atlas)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private void AdjustSteamDictionary(Dictionary<string, ButtonIcon> dictionary)
	{
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "GetButtonIconSpriteName")]
	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	public ButtonIcon GetButtonIcon(string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingPS4ControllerDisconnectedPanel")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingSteamControllerDisconnectedPanel")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	private Dictionary<string, ButtonIcon> GetActiveDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	public ButtonLegendAtlas()
	{
	}
}
