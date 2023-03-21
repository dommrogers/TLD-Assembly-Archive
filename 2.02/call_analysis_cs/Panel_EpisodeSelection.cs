using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_EpisodeSelection : Panel_Base
{
	[Serializable]
	public class EpisodeMenuItem
	{
		public Episode m_Type;

		public GameObject m_Display;

		public bool m_Future;

		public string m_Mission;

		public AnimationStateRef m_PlayOnSelect;

		public AnimationStateRef m_PlayOnDeselect;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public EpisodeMenuItem()
		{
		}
	}

	[Serializable]
	public class EpisodeDetails
	{
		public GameObject m_SaveDetailsObject;

		public GameObject m_DetailsObject;

		public UILabel m_EpisodeHeader;

		public UILabel m_DescriptionLabel;

		public UILabel m_NameLabel;

		public UILabel m_EpisodeProgression;

		public UILabel m_LastSaveDate;

		[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
		[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
		[CallsUnknownMethods(Count = 2)]
		public void SetActive(bool active)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public EpisodeDetails()
		{
		}
	}

	private delegate void OnDelegate();

	private enum AnimationState
	{
		None,
		EpisodeSelect,
		EpisodeDeselect
	}

	public EpisodeDetails m_EpisodeDetails;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public List<EpisodeMenuItem> m_MenuItems;

	public GameObject m_LockedEpisodeDisplayObject;

	public AnimationStateRef m_PlayOnSelectLocked;

	public AnimationStateRef m_PlayOnDeselectLocked;

	public GameObject m_BasicMenuRoot;

	private BasicMenu m_BasicMenu;

	public Animator m_EpisodeAnimator;

	private int m_LastItemIndexSelected;

	private Episode m_FurthestUnlockedEpisode;

	private EpisodeMenuItem m_PreviousEpisodeMenuItemSelected;

	private AnimationState m_CurrentEpisodeAnimationState;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "HideAllAnimatedItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "HideAllAnimatedItems")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "ConfigureMenu")]
	public override void Enable(bool enable)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void RefreshFurthestUnlockedEpisode()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	public string GetEpisodeStartMission(Episode episode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeStartMission")]
	[CallerCount(Count = 4)]
	private EpisodeMenuItem GetEpisodeMenuItem(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetIndexFromType(Episode type, List<EpisodeMenuItem> menuItems)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	private int GetSelectedIndex()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "OnStartEpisodeSelected")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateUnlockedItemDisplay")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "CanPlayEpisodeSelected")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	private EpisodeMenuItem GetSelectedEpisodeMenuItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Update")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void ProcessMenu()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "SelectionBegins")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[Calls(Type = typeof(EpisodeDetails), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNamedTitleLocId")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(EpisodeDetails), Member = "SetActive")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetHeaderLocId")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateSelection()
	{
	}

	[CallerCount(Count = 0)]
	private bool CanPlayEpisode(Episode episode)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	private bool CanPlayEpisodeSelected()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 5)]
	private void OnlyEnableItem(EpisodeMenuItem enabledItem)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateUnlockedItemDisplay()
	{
	}

	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnStartEpisodeSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	private void PlaySelectedAnimation(EpisodeMenuItem episodeMenuItem)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void PlayDeselectedAnimation(EpisodeMenuItem episodeMenuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreSelection()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void ConfigureMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNamedTitleLocId")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetHeaderLocId")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnimation")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 6)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnimation")]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EpisodeDetails), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Update")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateUnlockedItemDisplay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "OnlyEnableItem")]
	private void UpdateAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	private void SelectionBegins()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Initialize")]
	private void HideAllAnimatedItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_EpisodeSelection()
	{
	}
}
