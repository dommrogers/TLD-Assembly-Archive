using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.OptionalContent;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Sandbox : Panel_AutoReferenced
{
	[Serializable]
	public class MainSurvivalMenuItem
	{
		public enum MainSurvivalMenuItemType
		{
			New,
			Resume,
			Load,
			Challenges,
			Extras,
			Options
		}

		public LocalizedString m_LabelText;

		public LocalizedString m_LabelDescription;

		public MainSurvivalMenuItemType m_Type;

		public UnityEvent m_Callback;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public MainSurvivalMenuItem()
		{
		}
	}

	[Serializable]
	private class GameEditionArt
	{
		public GameObject m_MainTitle;

		public GameObject m_UpdateTitle;

		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public void SetActive(bool value)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public GameEditionArt()
		{
		}
	}

	private PanelReference<Panel_Badges> m_Badges;

	private PanelReference<Panel_ChooseSandbox> m_ChooseSandbox;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_MainMenu> m_MainMenu;

	private PanelReference<Panel_SelectExperience> m_SelectExperience;

	private PanelReference<Panel_Challenges> m_Challenges;

	private PanelReference<Panel_Extras> m_Extras;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UIPanel m_MainPanel;

	public GameObject m_MainWindow;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<MainSurvivalMenuItem> m_MenuItems;

	public UILabel m_CloudMessageLabel;

	public UISprite m_Sprite_FadeOverlay;

	public float m_InitialScreenFadeInDuration;

	public float m_FadeInTimeSeconds;

	public float m_NoInputTimeBeforeFading;

	public float m_MinDOFFocalLength;

	public float m_MaxDOFFocalLength;

	private GameEditionArt m_BaseEditionArt;

	private GameEditionArt m_ExpansionPassEditionArt;

	private OptionalContentConfig m_ExpansionPassConfig;

	private BasicMenu m_BasicMenu;

	private CloudMenuExtension m_CloudMenuExtension;

	private float m_PanelAlphaTarget;

	private float m_ScreenElapsedTime;

	private static float m_AdjustedFadeInDuration;

	private float m_PanelAlpha;

	private float m_TimeNoInput;

	private const float MAX_PANEL_ALPHA = 1f;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Sandbox), Member = "UpdateFading")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_Sandbox), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(InputManager), Member = "AnyInput")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Sandbox), Member = "AddMenuItem")]
	[Calls(Type = typeof(Panel_Extras), Member = "ShouldShowExtras")]
	[Calls(Type = typeof(BasicMenu), Member = "AddExtension")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Sandbox), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Sandbox), Member = "ConfigureMenu")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ResetFadeOverlay()
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowNotEnoughSaveSlotsAvailableNotification")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetNumSaveSlotsInUse")]
	public void OnClickNew()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClickLoad()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnClickResume()
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	public void OnClickChallenges()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(Panel_Badges), Member = "Enable")]
	[Calls(Type = typeof(Panel_Badges), Member = "OnFeats")]
	public void OnClickFeats()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnClickBack()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnClickExtras()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnClickOptions()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateMenuExtensionButtonLegend")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUnusedGameId")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	private void OnNewSandbox()
	{
	}

	[CallerCount(Count = 0)]
	private void FadeInPanel()
	{
	}

	[CallerCount(Count = 0)]
	private void FadeOutPanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private void UpdateFading()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsUnknownMethods(Count = 1)]
	private void SetGameEditionArt()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "Update")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private void SetPanelAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	private bool IsSubMenuEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Sandbox()
	{
	}
}
