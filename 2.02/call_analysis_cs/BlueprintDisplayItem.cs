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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	public void Clear()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnButtonClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BlueprintItem), Member = "CanCraftBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Setup(BlueprintItem bpi)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BlueprintItem GetBlueprintItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItem GetCraftedResult()
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public BlueprintDisplayItem()
	{
	}
}
