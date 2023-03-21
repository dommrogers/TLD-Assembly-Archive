using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StoryMissionListEntry : MonoBehaviour
{
	public enum CompletionDisplayMode
	{
		Percentage,
		Fraction
	}

	public UIWidget m_FadeOnDeselectWidget;

	public UISprite m_CheckboxSprite;

	public UISprite m_MissionSuccessSprite;

	public UISprite m_MissionFailedSprite;

	public UISprite m_MissionTimerSprite;

	public UISprite m_HighlightSprite;

	public UILabel m_EpisodeNameLabel;

	public UILabel m_MissionNameLabel;

	public UILabel m_MissionDescLabel;

	public UILabel m_MissionType;

	public UISprite m_MissionIcon;

	public UILabel m_CompletionPercentageLabel;

	public UISprite m_CompletionPercentageFillSprite;

	public float m_CompletionPercentageFillSpriteOffset;

	public CompletionDisplayMode m_CompletionDisplayMode;

	public float m_DeslectedAlphaValue;

	public Color m_CheckboxColorNormal;

	public Color m_CheckboxColorLowTime;

	public StoryMissionInfo m_MissionInfo;

	public GameObject m_NotificationFlag;

	public bool m_IsSelected;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetActiveCheckboxEntry")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetActiveCheckboxEntry")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Refresh(Panel_MissionsStory ownerPanel, StoryMissionInfo missionInfo, int numCompletedObjectives, int numObjectives)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	private void SetActiveCheckboxEntry(UISprite activeSprite)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StoryMissionListEntry()
	{
	}
}
