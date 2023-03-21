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

	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnBadges")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "OnBadgeLabelClicked")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	public void OnCancel()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[CallerCount(Count = 0)]
	public void OnBadgeLabelClicked()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	public void NextTool()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void PrevTool()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 1)]
	public void BadgeIndexSelected(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	public void OnFeats()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[CallsUnknownMethods(Count = 3)]
	private void AddFeatToList(Feat f)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetupFeatScrollList()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CleanupFeatScrollList()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallsUnknownMethods(Count = 4)]
	private void AddChallengeToList(BadgeInfo bi)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private BadgeUIInfo GetBadgeUIInfo(BadgeInfoType type)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupChallengeScrollList")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(Panel_Badges), Member = "AddChallengeToList")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CallsUnknownMethods(Count = 17)]
	private void SetupChallengeScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CleanupChallengeScrollList()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	private void EnableFeatBenefit(bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Badges), Member = "EnableFeatBenefit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void RefreshVisualsMainScreen()
	{
	}

	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadgeViewed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void RefreshVisualsScrollList()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void SetTabActive(GameObject tabObj)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
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
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	private void DoGamepadControls()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void RefreshVisuals()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	public Panel_Badges()
	{
	}
}
