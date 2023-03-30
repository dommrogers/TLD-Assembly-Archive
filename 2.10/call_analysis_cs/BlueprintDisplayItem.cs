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

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingEnd")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprintDisplayList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(BlueprintData), Member = "HasRequiredTool")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[Calls(Type = typeof(BlueprintData), Member = "GetDisplayedNameWithCount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void Setup(Panel_Crafting panel, BlueprintData bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public BlueprintData GetBlueprintData()
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
	public BlueprintDisplayItem()
	{
	}
}
