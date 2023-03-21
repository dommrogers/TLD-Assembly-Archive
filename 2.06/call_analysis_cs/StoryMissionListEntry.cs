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
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetActiveCheckboxEntry")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetActiveCheckboxEntry")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void Refresh(Panel_MissionsStory ownerPanel, StoryMissionInfo missionInfo, int numCompletedObjectives, int numObjectives)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	public void SetSelected(bool isSelected)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetActiveCheckboxEntry(UISprite activeSprite)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public StoryMissionListEntry()
	{
	}
}
