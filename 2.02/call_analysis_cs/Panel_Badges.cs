using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Badges : Panel_Base
{
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

	public Color m_ColorHeaderLocked;

	public Color m_ColorHeaderUnlocked;

	public Color m_ColorDescriptionLocked;

	public Color m_ColorDescriptionUnlocked;

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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnBadges")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ViewUpsell")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnBadgeLabelClicked")]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	public void OnBadgeLabelClicked()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	public void NextTool()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	public void PrevTool()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void BadgeIndexSelected(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	public void OnFeats()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	public void OnChallenges()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	public bool HasAnyUnviewedUnlockedBadges()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	private void SetupScrollLists()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddFeatToList(Feat f)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Badges), Member = "AddFeatToList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	private void SetupFeatScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	private void AddChallengeToList(BadgeInfo bi)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private BadgeUIInfo GetBadgeUIInfo(BadgeInfoType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	private void SetupChallengeScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void EnableFeatBenefit(bool isEnabled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Badges), Member = "EnableFeatBenefit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void RefreshVisualsMainScreen()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 47)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MarkBadgeAsViewed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void RefreshVisualsScrollList()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void SetTabActive(GameObject tabObj)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasBadgeBeenViewed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CallsUnknownMethods(Count = 4)]
	private bool ListHasUnviewedUnlockedBadge(List<BadgeInfo> badgeInfoList)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Badges), Member = "PrevTool")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Badges), Member = "NextTool")]
	private void DoGamepadControls()
	{
	}

	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void RefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Badges()
	{
	}
}
