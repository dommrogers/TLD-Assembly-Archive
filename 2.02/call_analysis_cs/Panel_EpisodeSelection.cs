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

		[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
		[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public void SetActive(bool active)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "HideAllAnimatedItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "HideAllAnimatedItems")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RefreshFurthestUnlockedEpisode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	public string GetEpisodeStartMission(Episode episode)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeStartMission")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private EpisodeMenuItem GetEpisodeMenuItem(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private int GetIndexFromType(Episode type, List<EpisodeMenuItem> menuItems)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	private int GetSelectedIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Update")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ProcessMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "CanPlayEpisodeSelected")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateUnlockedItemDisplay")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "OnStartEpisodeSelected")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private EpisodeMenuItem GetSelectedEpisodeMenuItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "EnableConfirm")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "SelectionBegins")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(EpisodeDetails), Member = "SetActive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetHeaderLocId")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNamedTitleLocId")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateSelection()
	{
	}

	[CallerCount(Count = 0)]
	private bool CanPlayEpisode(Episode episode)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	private bool CanPlayEpisodeSelected()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void OnlyEnableItem(EpisodeMenuItem enabledItem)
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateUnlockedItemDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnStartEpisodeSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void PlaySelectedAnimation(EpisodeMenuItem episodeMenuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void PlayDeselectedAnimation(EpisodeMenuItem episodeMenuItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void RestoreSelection()
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "AddMenuItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void ConfigureMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetHeaderLocId")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNamedTitleLocId")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetState")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "IsUnlocked")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnimation")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private bool IsPlayingAnySelectionAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnimation")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnySelectionAnimation")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnyDeselectionAnimation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnyDeselectionAnimation")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "IsPlayingAnySelectionAnimation")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetSelectedEpisodeMenuItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "OnlyEnableItem")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateUnlockedItemDisplay")]
	[Calls(Type = typeof(EpisodeDetails), Member = "SetActive")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "UpdateSelection")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
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

	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_EpisodeSelection), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void HideAllAnimatedItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Panel_EpisodeSelection()
	{
	}
}
