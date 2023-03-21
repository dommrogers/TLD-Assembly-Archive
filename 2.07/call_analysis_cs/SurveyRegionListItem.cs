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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Clear()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Panel_Log), Member = "GetRegionButtonTexture")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void SetRegionInfo(SurveyRegionInfo sri)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnListClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	public SurveyRegionListItem()
	{
	}
}
