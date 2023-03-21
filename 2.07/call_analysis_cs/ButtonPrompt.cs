using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	private PanelReference<Panel_HUD> m_HUD;

	private Dictionary<UIWidget, Color> m_DefaultColorsByWidget;

	public Color m_DisabledColor;

	private string m_PromptStr;

	private string m_InputActionName;

	private bool m_HasInitialized;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonPrompt), Member = "InitializeValues")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	public void ResetPrompt()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 49)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ButtonPrompt), Member = "DisableAll")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "InitializeValues")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ShowPromptForKey(string promptStr, string inputActionName, bool forceRefresh = false)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[CalledBy(Type = typeof(Elevator), Member = "UpdateButtonPrompts")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(TwoButtonsChoiceUI), Member = "RefreshChoices")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	public void ShowPromptForKeyWithDisable(string promptStr, string inputActionName, bool isPromptEnabled)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonPrompt), Member = "DisableAll")]
	public void UpdatePromptLabel(string promptStr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	public void RefreshPrompt()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void InitializeValues()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisableAll()
	{
	}

	[CallerCount(Count = 0)]
	public ButtonPrompt()
	{
	}
}
