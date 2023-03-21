using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActionPickerItem : MonoBehaviour
{
	private Panel_ActionPicker m_ActionPicker;

	public UISprite m_Sprite;

	public UILabel m_Label;

	public UIWidget m_Widget;

	public UISprite m_HoverSprite;

	private int m_Index;

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void Setup(ActionPickerItemData itemData, int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateGamepadSelection(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ActionPickerItem()
	{
	}
}
