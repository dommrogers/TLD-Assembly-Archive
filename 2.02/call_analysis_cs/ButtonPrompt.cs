using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ButtonPrompt : MonoBehaviour
{
	public UILabel m_KeyboardButtonLabel;

	public UISprite m_KeyboardButtonSprite;

	public UISprite m_KeyboardButtonBGSprite;

	public UILabel m_KeyboardActionLabel;

	public UISprite m_NonKeyboardButtonSprite;

	public UILabel m_NonKeyboardActionLabel;

	public GameObject m_ButtonObjectCmdClickPlace;

	private Dictionary<UIWidget, Color> m_DefaultColorsByWidget;

	public Color m_DisabledColor;

	private string m_PromptStr;

	private string m_InputActionName;

	private bool m_HasInitialized;

	[Calls(Type = typeof(ButtonPrompt), Member = "InitializeValues")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void ResetPrompt()
	{
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 49)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ButtonPrompt), Member = "InitializeValues")]
	[Calls(Type = typeof(ButtonPrompt), Member = "DisableAll")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	public void ShowPromptForKey(string promptStr, string inputActionName, bool forceRefresh = false)
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	public void ShowPromptForKeyWithDisable(string promptStr, string inputActionName, bool isPromptEnabled)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(ButtonPrompt), Member = "DisableAll")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdatePromptLabel(string promptStr)
	{
	}

	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallerCount(Count = 0)]
	public void RefreshPrompt()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "Awake")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 20)]
	private void InitializeValues()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void DisableAll()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public ButtonPrompt()
	{
	}
}
