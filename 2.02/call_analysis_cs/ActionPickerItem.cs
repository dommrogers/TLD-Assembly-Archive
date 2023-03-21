using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActionPickerItem : MonoBehaviour
{
	public UISprite m_Sprite;

	public UILabel m_Label;

	public UIWidget m_Widget;

	public UISprite m_HoverSprite;

	private int m_Index;

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	public void Setup(Panel_ActionPicker.ActionPickerItemData itemData, int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateGamepadSelection(bool isSelected)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ActionPickerItem()
	{
	}
}
