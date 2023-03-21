using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_PauseMenu : Panel_AutoReferenced
{
	public enum PauseMenuItemType
	{
		BackToGame,
		Badges,
		Options,
		Quit,
		Debug
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UISprite m_GameModeIcon;

	public GameObject m_BuyNowObject;

	public GameObject[] m_ActiveFeatObjects;

	private PanelReference<Panel_Badges> m_Badges;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	private PanelReference<Panel_SaveIcon> m_SaveIcon;

	private PanelReference<Panel_Debug> m_PanelDebug;

	public GameObject m_BasicMenuRoot;

	public List<PauseMenuItemType> m_MenuItems;

	private BasicMenu m_BasicMenu;

	public static bool m_NoMenuBlur;

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetPauseMenuTogglePressed")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuBuyNowPressed")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action GetActionFromType(PauseMenuItemType type)
	{
		return null;
	}

	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	private void ConfigureMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateMenuNavigation()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "SetExperienceModeIcon")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPaused")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "CleanupSelectedFeats")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsGameplayRendering")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void OnQuitGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnGameQuit")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "OnDone")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 1)]
	public void DoQuitGame()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnBadges()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[CallsUnknownMethods(Count = 1)]
	public void OnOptions()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnDebugPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteSaveNamed")]
	[CalledBy(Type = typeof(Panel_SaveStory._003COnQuicksaveCoroutine_003Ed__58), Member = "MoveNext")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	public void OnDone()
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetExperienceModeIcon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	public void OnBuyNow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateSelectedFeats()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	private void CleanupSelectedFeats()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_PauseMenu()
	{
	}
}
