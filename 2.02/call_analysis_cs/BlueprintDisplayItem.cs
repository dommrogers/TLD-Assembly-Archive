using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BlueprintDisplayItem : MonoBehaviour
{
	public delegate void OnBlueprintItemClicked(int index);

	public UISprite m_Available;

	public UISprite m_Background;

	public UIButton m_Button;

	public UILabel m_DisplayName;

	public UITexture m_Icon;

	public UIWidget m_Root;

	public UISprite m_Unavailable;

	public Color m_Disabled;

	public Color m_Normal;

	public Color m_Selected;

	public GameObject m_NotificationFlag;

	public bool m_IsSelected;

	[NonSerialized]
	public int m_Index;

	[NonSerialized]
	public OnBlueprintItemClicked m_ClickedDelegate;

	private bool m_CanCraftBlueprint;

	private BlueprintItem m_BlueprintItem;

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnButtonClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 17)]
	public void Setup(BlueprintItem bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public BlueprintItem GetBlueprintItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetCraftedResult()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BlueprintDisplayItem()
	{
	}
}
