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

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(StoryMissionListEntry), Member = "SetActiveCheckboxEntry")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 26)]
	public void Refresh(StoryMissionInfo missionInfo, int numCompletedObjectives, int numObjectives)
	{
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnNavigationChanged")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshScrollList")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private void SetActiveCheckboxEntry(UISprite activeSprite)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StoryMissionListEntry()
	{
	}
}
