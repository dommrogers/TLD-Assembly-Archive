using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Badges : Panel_AutoReferenced
{
	private BadgeUISettings m_UISettings;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonRight;

	public TweenAlpha m_LabelTween;

	public UILabel m_NameLabel;

	public UISprite m_LineBreakSprite;

	public UILabel m_DescLabel;

	public UISprite m_ProgressBarSprite;

	public UILabel m_ProgressLabel;

	public GameObject m_FeatsObject;

	public GameObject m_ChallengesObject;

	public UILabel m_NavButtonHeaderLabel;

	public GameObject m_ScrollListParentObject;

	public ScrollList m_FeatsScrollList;

	public ScrollList m_ChallengesScrollList;

	public GameObject m_FeatsUpsell;

	public GameObject m_ChallengesUpsell;

	public GameObject m_FeatProgressObject;

	public UISprite m_FeatProgressSprite;

	public UILabel m_FeatProgressLabel;

	public Vector2 m_FeatProgressBarRange;

	public List<BadgeUIInfo> m_ChallengeBadges;

	public GameObject m_FeatBenefitHeader;

	public GameObject m_FeatBenefitDescription;

	private ScrollList m_SelectedScrollList;

	private List<BadgeInfo> m_Feats;

	private List<BadgeInfo> m_Challenges;

	private List<BadgeInfo> m_SelectedBadgeInfo;

	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_Feats;

	private ButtonLegendConfigure[] m_ButtonLegendConfigureArray_Challenges;

	private ComingFromScreenCategory m_CameFrom;

	private UILabel m_FeatBenefitDescriptionLabel;

	private UILabel m_FeatBenefitHeaderLabel;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnBadges")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnBadgeLabelClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	public void OnBadgeLabelClicked()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CallsUnknownMethods(Count = 2)]
	public void NextTool()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsUnknownMethods(Count = 2)]
	public void PrevTool()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	public void BadgeIndexSelected(int index)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	public void OnFeats()
	{
	}

	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnChallenges()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	public bool HasAnyUnviewedUnlockedBadges()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	private void SetupScrollLists()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddFeatToList(Feat f)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupFeatScrollList")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	private void SetupFeatScrollList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	private void CleanupFeatScrollList()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void AddChallengeToList(BadgeInfo bi)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private BadgeUIInfo GetBadgeUIInfo(BadgeInfoType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupChallengeScrollList")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CallsUnknownMethods(Count = 18)]
	private void SetupChallengeScrollList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void CleanupChallengeScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 1)]
	private void EnableFeatBenefit(bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "EnableFeatBenefit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshVisualsMainScreen()
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadgeViewed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void RefreshVisualsScrollList()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[CallsUnknownMethods(Count = 3)]
	private void SetTabActive(GameObject tabObj)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	private bool ListHasUnviewedUnlockedBadge(List<BadgeInfo> badgeInfoList)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[Calls(Type = typeof(Panel_Badges), Member = "NextTool")]
	[Calls(Type = typeof(Panel_Badges), Member = "PrevTool")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	private void DoGamepadControls()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CallerCount(Count = 2)]
	private void RefreshVisuals()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Badges()
	{
	}
}
