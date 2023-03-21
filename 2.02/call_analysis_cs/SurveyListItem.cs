using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SurveyListItem : MonoBehaviour
{
	public delegate void OnDisplayItemClicked(int index);

	public UILabel m_AchievementNameLabel;

	public UIButton m_Button;

	public UISprite m_Background;

	public GameObject m_Complete;

	public GameObject m_Incomplete;

	public Color m_Normal;

	public Color m_Selected;

	[NonSerialized]
	public int m_Index;

	[NonSerialized]
	public OnDisplayItemClicked m_ClickedDelegate;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshAchievementListForSelectedRegion")]
	[CallsUnknownMethods(Count = 3)]
	public void SetAchievementInfo(SurveyAchievementInfo sai)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnListClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyClicked")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyBack")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSurveyRegionClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateCartographyPage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsCartography")]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SurveyListItem()
	{
	}
}
