using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_PauseMenu : Panel_Base
{
	public enum PauseMenuItemType
	{
		BackToGame,
		Badges,
		Options,
		Quit,
		SaveGame,
		LoadGame
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UISprite m_PilgrimIcon;

	public UISprite m_VoyageurIcon;

	public UISprite m_StalkerIcon;

	public UISprite m_RescueIcon;

	public UISprite m_HuntedIcon;

	public UISprite m_WhiteoutIcon;

	public UISprite m_NomadIcon;

	public UISprite m_HuntedPart2Icon;

	public UISprite m_NightmareIcon;

	public UISprite m_CustomModeIcon;

	public UISprite m_FourDaysOfNightIcon;

	public UISprite m_ArchivistIcon;

	public UISprite m_DeadManIcon;

	public UISprite m_NowhereToHideIcon;

	public UISprite m_SpecialEventIcon;

	public GameObject m_BuyNowObject;

	public GameObject[] m_ActiveFeatObjects;

	public GameObject m_BasicMenuRoot;

	public List<PauseMenuItemType> m_MenuItems;

	private BasicMenu m_BasicMenu;

	public static bool m_NoMenuBlur;

	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallerCount(Count = 0)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuBuyNowPressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetPauseMenuTogglePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "AddMenuItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public Action GetActionFromType(PauseMenuItemType type)
	{
		return null;
	}

	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 0)]
	private void UpdateMenuNavigation()
	{
	}

	[Calls(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "SetExperienceModeIcon")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPaused")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsGameplayRendering")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSaveGame()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnLoadGame()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 16)]
	public void OnQuitGame()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "OnClickQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	public void DoQuitGame()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public void OnBadges()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void OnOptions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 3)]
	public void OnHelp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SaveStory._003COnQuicksaveCoroutine_003Ed__58), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteSaveNamed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	public void OnDone()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 30)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 75)]
	private void SetExperienceModeIcon()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnBuyNow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemValueIndex")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(BasicMenu), Member = "SetItemSelectable")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemValueIndex")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemValueIndex")]
	private void UpdateSaving()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 17)]
	private void UpdateSelectedFeats()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Panel_PauseMenu()
	{
	}
}
