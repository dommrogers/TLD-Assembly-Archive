using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SkillListItem : MonoBehaviour
{
	public delegate void OnDisplayItemClicked(int index);

	public UIWidget m_FadeOnDeselectWidget;

	public UISprite m_SkillIcon;

	public UILabel m_SkillLevel;

	public UILabel m_ProgressBarName;

	public UILabel m_SkillPoints;

	public GameObject m_ProgressBarObj;

	public UISprite m_ProgressBarForeground;

	public float m_FillSpriteOffset;

	public GameObject m_SelectedObj;

	public GameObject m_UnselectedObj;

	public float m_DeslectedAlphaValue;

	public Skill m_Skill;

	[NonSerialized]
	public int m_Index;

	[NonSerialized]
	public OnDisplayItemClicked m_ClickedDelegate;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnSkillListItemClicked()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	public void SetSkillLevel(int level)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 1)]
	public void SetSkillIcon(string icon)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void SetProgressBarName(string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void SetSkillPoints(string points)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void SetProgress(float normalizedProgress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableProgressBar(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	public void SetSelected(bool selected)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public SkillListItem()
	{
	}
}
