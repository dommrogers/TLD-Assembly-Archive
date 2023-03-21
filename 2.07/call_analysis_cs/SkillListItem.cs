using System;
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
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

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void SetSkillPoints(string points)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshSkillsList")]
	[CallsUnknownMethods(Count = 1)]
	public void SetProgress(float normalizedProgress)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableProgressBar(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnSkillItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateSkillListItemsColor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "HandleSkillVerticalNavigation")]
	[CallerCount(Count = 5)]
	public void SetSelected(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	public SkillListItem()
	{
	}
}
