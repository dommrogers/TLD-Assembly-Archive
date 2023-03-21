using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RockCacheListItem : MonoBehaviour
{
	public delegate void OnDisplayItemClicked(int index);

	public UILabel m_CustomNameLabel;

	public UILabel m_RegionNameLabel;

	public UILabel m_RegionUndiscoveredLabel;

	public Color m_RegionDiscoverColor;

	public Color m_RegionUndiscoverColor;

	public UILabel m_RockCacheCount;

	public UIButton m_Button;

	public UISprite m_Background;

	public UITexture m_RegionBackground;

	[NonSerialized]
	public int m_Index;

	public Color m_Normal;

	public Color m_Selected;

	[NonSerialized]
	public string m_RockCacheGuid;

	[NonSerialized]
	public OnDisplayItemClicked m_ClickedDelegate;

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnRockCacheListClicked()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Log), Member = "GetRegionButtonTexture")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRegionUnlocked")]
	public void SetRegionInfo(int rockCacheCount, string sceneName)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RockCacheManager), Member = "GetRockCacheNameFromGuid")]
	public void SetItemInfo(RockCacheInfo itemInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildRockCacheRegionScrollList")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RockCacheListItem()
	{
	}
}
