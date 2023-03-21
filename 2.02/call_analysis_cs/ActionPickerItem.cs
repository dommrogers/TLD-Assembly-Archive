using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ActionPickerItem : MonoBehaviour
{
	public UISprite m_Sprite;

	public UILabel m_Label;

	public UIWidget m_Widget;

	public UISprite m_HoverSprite;

	private int m_Index;

	[CalledBy(Type = typeof(Panel_ActionPicker), Member = "EnableWithCurrentList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void Setup(Panel_ActionPicker.ActionPickerItemData itemData, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateGamepadSelection(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_ActionPicker), Member = "OnSelect")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ActionPickerItem()
	{
	}
}
