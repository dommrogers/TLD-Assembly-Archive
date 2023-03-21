using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class SurveyRegionListItem : MonoBehaviour
{
	public delegate void OnDisplayItemClicked(int index);

	private PanelReference<Panel_Log> m_Log;

	public UILabel m_RegionNameLabel;

	public UILabel m_PercentCompleteLabel;

	public UILabel m_RegionUndiscoveredLabel;

	public Color m_RegionDiscoverColor;

	public Color m_RegionUndiscoverColor;

	public UIButton m_Button;

	public UISprite m_Background;

	public UISprite m_ProgressBarForeground;

	public UITexture m_RegionBackground;

	public Color m_Normal;

	public Color m_Selected;

	[NonSerialized]
	public int m_Index;

	[NonSerialized]
	public OnDisplayItemClicked m_ClickedDelegate;

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "GetRegionButtonTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void SetRegionInfo(SurveyRegionInfo sri)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnListClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	public SurveyRegionListItem()
	{
	}
}
