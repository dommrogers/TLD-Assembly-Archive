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

	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionary")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "AdjustSteamDictionary")]
	public void BuildDictionaries()
	{
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private Dictionary<string, ButtonIcon> BuildDictionary(Dictionary<string, string> input, UIAtlas atlas)
	{
		return null;
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "BuildDictionaries")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 9)]
	private void AdjustSteamDictionary(Dictionary<string, ButtonIcon> dictionary)
	{
	}

	[CalledBy(Type = typeof(BMSymbol), Member = "SetSpriteLocation")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "GetButtonIconSpriteName")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CalledBy(Type = typeof(ButtonLegend), Member = "AddButton")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshHoursToRead")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RefreshGamepadPrompts")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdateKeyBindingLabels")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "TryUpdateSteamControllerActionSet")]
	[Calls(Type = typeof(ButtonLegendAtlas), Member = "GetActiveDictionary")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public ButtonIcon GetButtonIcon(string action)
	{
		return null;
	}

	[CalledBy(Type = typeof(ButtonLegendAtlas), Member = "GetButtonIcon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingSteamControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "HasReconnectedJoystick")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingPS4ControllerDisconnectedPanel")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsUnknownMethods(Count = 2)]
	private Dictionary<string, ButtonIcon> GetActiveDictionary()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public ButtonLegendAtlas()
	{
	}
}
