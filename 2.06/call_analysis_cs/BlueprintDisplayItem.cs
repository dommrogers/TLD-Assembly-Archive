using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.Gear;
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

	private BlueprintData m_BlueprintData;

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnButtonClicked()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "SetNavigationArea")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(BlueprintData), Member = "GetDisplayedNameWithCount")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(BlueprintData), Member = "CanCraftBlueprint")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	public void Setup(Panel_Crafting panel, BlueprintData bpi)
	{
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public BlueprintData GetBlueprintData()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public GearItem GetCraftedResult()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public BlueprintDisplayItem()
	{
	}
}
