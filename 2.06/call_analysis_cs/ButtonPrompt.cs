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

	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKeyWithDisable")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "RefreshPrompt")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdatePlacementButtonLabels")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopup")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowGenericPopupWithDefaultActions")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CalledBy(Type = typeof(GenericInteractionCancelUI), Member = "RefreshButtonPrompt")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "RefreshButtonPrompts")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ExitDialogueUpdate")]
	[CalledBy(Type = typeof(TimedActionPopup), Member = "SetPrompt")]
	[CallerCount(Count = 49)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(ButtonPrompt), Member = "InitializeValues")]
	[Calls(Type = typeof(ButtonPrompt), Member = "DisableAll")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Application), Member = "get_platform")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInPlacementMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(InputManager), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(char), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 3)]
	public void ShowPromptForKey(string promptStr, string inputActionName, bool forceRefresh = false)
	{
	}

	[CalledBy(Type = typeof(EquipItemPopup), Member = "ShowEquippedItem")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CalledBy(Type = typeof(GenericInteractionPrompt), Member = "ShowInteraction")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public void ShowPromptForKeyWithDisable(string promptStr, string inputActionName, bool isPromptEnabled)
	{
	}

	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateButtonStatus")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ButtonPrompt), Member = "DisableAll")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdatePromptLabel(string promptStr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	public void RefreshPrompt()
	{
	}

	[CalledBy(Type = typeof(ButtonPrompt), Member = "Awake")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeValues()
	{
	}

	[CalledBy(Type = typeof(ButtonPrompt), Member = "ShowPromptForKey")]
	[CalledBy(Type = typeof(ButtonPrompt), Member = "UpdatePromptLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void DisableAll()
	{
	}

	[CallerCount(Count = 0)]
	public ButtonPrompt()
	{
	}
}
