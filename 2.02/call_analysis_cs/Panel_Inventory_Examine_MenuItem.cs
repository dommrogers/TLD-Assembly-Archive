using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Inventory_Examine_MenuItem : MonoBehaviour
{
	public UILabel m_LabelTitle;

	public UISprite m_SpriteBackground;

	public UISprite m_SpriteX;

	public Color m_TextColor_Normal;

	public Color m_TextColor_NormalHover;

	public Color m_TextColor_NormalSelected;

	public Color m_TextColor_Disabled;

	public Color m_TextColor_DisabledHover;

	public Color m_TextColor_DisabledSelected;

	public Color m_SpriteColorSelected;

	public Color m_SpriteColorSelectedHover;

	public Color m_SpriteColorUnselected;

	public Color m_SpriteColorUnselectedHover;

	public UIButton m_ButtonSpriteRef;

	private bool m_Selected;

	private bool m_Hover;

	private bool m_Disabled;

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RefreshMainWindow")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshMainWindow")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnHover(bool hover)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetDisabled(bool disabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Inventory_Examine_MenuItem()
	{
	}
}
