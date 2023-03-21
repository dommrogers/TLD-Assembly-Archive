using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.ResourceManagement.AsyncOperations;

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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnBadges")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 3)]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnBadgeLabelClicked")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "OnCancel")]
	public void OnBadgeLabelClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void NextTool()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PrevTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void BadgeIndexSelected(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	public void OnFeats()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetTabActive")]
	public void OnChallenges()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	public bool HasAnyUnviewedUnlockedBadges()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	private void SetupScrollLists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsUnknownMethods(Count = 2)]
	private void AddFeatToList(Feat f)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetupFeatScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupFeatScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void AddChallengeToList(BadgeInfo bi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private BadgeUIInfo GetBadgeUIInfo(BadgeInfoType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupScrollLists")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Badges), Member = "CleanupChallengeScrollList")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void SetupChallengeScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupChallengeScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void EnableFeatBenefit(bool isEnabled)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Badges), Member = "EnableFeatBenefit")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshVisualsMainScreen()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadgeViewed")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 18)]
	private void RefreshVisualsScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetTabActive(GameObject tabObj)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "HasAnyUnviewedUnlockedBadges")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 6)]
	private bool ListHasUnviewedUnlockedBadge(List<BadgeInfo> badgeInfoList)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisuals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendConfigure), Member = "ConfigureButton")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshButtonConfigure(ButtonLegendConfigure[] buttonLegendConfigureArray)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_Badges), Member = "PrevTool")]
	[Calls(Type = typeof(Panel_Badges), Member = "NextTool")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnChallenges")]
	[CallsUnknownMethods(Count = 1)]
	private void DoGamepadControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsMainScreen")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Badges), Member = "RefreshButtonConfigure")]
	[CallsUnknownMethods(Count = 1)]
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
