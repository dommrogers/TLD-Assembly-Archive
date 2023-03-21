using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using TLD.SaveState;
using TLD.Serialization;
using TLD.TimeLib;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Rendering.PostProcessing;

public class Panel_OptionsMenu : Panel_AutoReferenced
{
	[Serializable]
	public class OptionTopMenuItem
	{
		public enum MenuType
		{
			Accessibility,
			Display,
			Quality,
			Brightness,
			Audio,
			Controls,
			KeyBinding,
			Autosave,
			Privacy,
			ControlDiagram
		}

		public MenuType m_Type;

		public string m_LabelLocalizationId;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public OptionTopMenuItem()
		{
		}
	}

	private sealed class _003CStartForceTempResolutionChangeCo_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private Panel_OptionsMenu _003Cpanel_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStartForceTempResolutionChangeCo_003Ed__223(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public ConsoleComboBox m_InteractionTypePopupList;

	public ConsoleComboBox m_ReduceCameraMotionPopupList;

	public ConsoleComboBox m_SubtitleSizePopupList;

	public ConsoleComboBox m_StruggleTypePopupList;

	public ConsoleComboBox m_AutoRunPopupList;

	public ConsoleComboBox m_MisophoniaFilterPopupList;

	public ConsoleComboBox m_SwearFilterPopupList;

	public LocalizedString m_InteractionTypeSwitchString;

	private int m_AccessibilitySelectedButtonIndex;

	private int m_NumFramesInAccessibilityTab;

	private List<GameObject> m_AccessibilityMenuItems;

	public ConsoleSlider m_MasterSlider;

	public ConsoleSlider m_SoundSlider;

	public ConsoleSlider m_MusicSlider;

	public ConsoleSlider m_VoiceSlider;

	public ConsoleComboBox m_PanningRuleList;

	public float m_MasterVolumeDefault;

	public float m_SoundVolumeDefault;

	public float m_MusicVolumeDefault;

	public float m_VoiceVolumeDefault;

	public PanningRule m_PanningRuleDefault;

	private const string PANNING_RULE_HEADPHONES = "GAMEPLAY_PanningRuleHeadphones";

	private const string PANNING_RULE_SPEAKERS = "GAMEPLAY_PanningRuleSpeakers";

	private int m_AudioSelectedButtonIndex;

	private int m_NumFramesInAudioTab;

	private List<GameObject> m_AudioMenuItems;

	public ConsoleSlider m_AutosaveMinutesSlider;

	public float m_AutosaveMinutesDefault;

	public float m_AutosaveMinutesMin;

	public float m_AutosaveMinutesMax;

	private int m_AutosaveSelectedButtonIndex;

	private int m_NumFramesInAutosaveTab;

	private List<GameObject> m_AutosaveMenuItems;

	public GameObject m_BrightnessStandardRoot;

	public GameObject m_BrightnessHDRRoot;

	public ConsoleSlider m_BrightnessSlider;

	public ConsoleSlider m_HDRBrightnessSlider;

	public GameObject m_BrightnessFirstTimeButton;

	public GameObject[] m_ObjectsToDisableOnBrightnessTab;

	private List<GameObject> m_BrightnessMenuItems;

	private int m_BrightnessSelectedButtonIndex;

	private int m_NumFramesInBrightnessTab;

	private string m_BrightnessSavedWeatherState;

	private string m_BrightnessSavedTODState;

	private string m_BrightnessSavedWindState;

	private bool m_IsShowingBrightnessCalibration;

	public GameObject m_ControllerLayoutSwitchHandheld;

	public GameObject m_ControllerLayoutSwitchJoycons;

	public GameObject m_ControllerLayoutSwitchPro;

	public ConsoleComboBox m_EnableGamepadToggle;

	public ConsoleComboBox m_InvertYToggle;

	public ConsoleSlider m_MouseSensitivitySlider;

	public ConsoleSlider m_ZoomSensitivitySlider;

	public ConsoleSlider m_AnalogSticksSensitivitySlider;

	public ConsoleComboBox m_LockMouseToScreenToggle;

	public ConsoleComboBox m_MouseSmoothingToggle;

	public GameObject m_ControllerLayoutXboxOne;

	public GameObject m_ControllerLayoutPS4;

	public ConsoleComboBox m_GyroModeToggle;

	public ConsoleSlider m_GyroLookHorizontalSensitivitySlider;

	public ConsoleSlider m_GyroLookVerticalSensitivitySlider;

	public ConsoleSlider m_GyroAimHorizontalSensitivitySlider;

	public ConsoleSlider m_GryoAimVerticalSensitivitySlider;

	private int m_ControlsSelectedButtonIndex;

	private int m_NumFramesInControlsTab;

	private List<GameObject> m_ControlsMenuItems;

	public GameObject m_ConfirmButton;

	public GameObject m_BackButton;

	public UILabel m_OptionDescriptionLabel;

	public ButtonLegendContainer m_ButtonLegendContainer;

	private float m_DescriptionLabelHorizontalPosition;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private PanelReference<Panel_Sandbox> m_Sandbox;

	public bool m_ForceCloseOnConfirm;

	private PanelReference m_ReturnToPanel;

	private bool m_SettingsNeedConfirmation;

	private bool m_SettingsNeedRestart;

	public ConsoleComboBox m_GraphicsResolutionPopupList;

	public ConsoleComboBox m_GraphicsModePopupList;

	public ConsoleComboBox m_DisplayNumberPopupList;

	public ConsoleComboBox m_UnitsPopupList;

	public ConsoleComboBox m_HudSizePopupList;

	public ConsoleComboBox m_HudTypePopupList;

	public ConsoleComboBox m_WolfMoraleMeterPopupList;

	public ConsoleComboBox m_VsyncPopupList;

	public ConsoleComboBox m_SubtitlesPopupList;

	public ConsoleComboBox m_LanguagePopupList;

	public ConsoleSlider m_FieldOfViewSlider;

	public ConsoleComboBox m_ImageFilterPopupList;

	public ConsoleComboBox m_LockFPSPopupList;

	public float m_FieldOfViewDefault;

	public float m_FieldOfViewMin;

	public float m_FieldOfViewMax;

	public float m_FieldOfViewIndoor;

	private int m_DisplaySelectedButtonIndex;

	private int m_NumFramesInDisplayTab;

	private readonly List<GameObject> m_DisplayMenuItems;

	private readonly List<Resolution> m_Resolutions;

	private readonly List<DisplayInfo> m_Displays;

	private Resolution m_ResolutionAtStartup;

	private bool m_HasAppliedCommandLineParameters;

	private bool m_FullScreenAtStartup;

	private int m_RestoreResolutionIndex;

	private bool m_DeferSwitchToFullscreen;

	private GraphicsMode m_ModeAtLastResolutionRefresh;

	public float m_SliderTimeToMaxScroll;

	public float m_SliderTimerMin;

	public float m_SliderTimerMax;

	public float m_MenuItemSpacing;

	private float m_SliderStickValueLastFrame;

	private float m_SliderMaxScrollTime;

	private float m_SliderNextSlideTime;

	private int m_NumFramesInOptions;

	private int m_FrameLastPopupClick;

	public Collider m_KeyRebindPopup;

	public GameObject m_AutoWalkKeyBinding;

	private GameObject m_CurrentKeyRebindButton;

	private int m_KeyRebindSelectedButtonIndex;

	private bool m_WaitForKeyRebindInput;

	private int m_RebindDelayFramesRemaining;

	public ConsoleComboBox m_SendErrorReports;

	public ConsoleComboBox m_SendTelemetryData;

	public UIButton m_ViewPrivacyPolicy;

	public UIButton m_ManagePrivacyData;

	public string m_PrivacyPolicyURL;

	private int m_PrivacySelectedButtonIndex;

	private List<GameObject> m_PrivacyMenuItems;

	public ConsoleComboBox m_QualityPopupList;

	public ConsoleComboBox m_ShadowsPopupList;

	public ConsoleComboBox m_ShadowQualityPopupList;

	public ConsoleComboBox m_ShadowResolutionPopupList;

	public ConsoleComboBox m_TextureQualityPopupList;

	public ConsoleComboBox m_TextureStreamingPopupList;

	public ConsoleComboBox m_TerrainLodQualityPopupList;

	public ConsoleComboBox m_LodBiasPopupList;

	public ConsoleComboBox m_GraphicsSSAOPopupList;

	public ConsoleComboBox m_PostFxPopupList;

	public ConsoleComboBox m_FootprintsPopupList;

	public ConsoleSlider m_ShadowDrawDistanceSlider;

	public ConsoleSlider m_TreeDrawDistanceSlider;

	public ConsoleSlider m_TreeBillboardDistanceSlider;

	public ConsoleSlider m_TerrainDetailsDrawDistanceSlider;

	public ConsoleSlider m_TerrainDetailsDensitySlider;

	public LocalizedString m_ApplyChangesMessage;

	private int m_QualitySelectedButtonIndex;

	private int m_NumFramesInQualityTab;

	private List<GameObject> m_QualityMenuItems;

	private List<GameObject> m_QualityOptionOnlyMenuItems;

	private Quality m_LastRefreshedQuality;

	private QualityLevelSettings m_UnconfirmedCustomQualitySettings;

	private QualityLevelSettings m_SnapsotOfOriginalQualitySettings;

	private QualityLevelSettings m_SnapsotOfCurrentQualitySettings;

	private bool m_UnconfirmedCustomQualitySettingsPopulated;

	public GameObject m_MainTab;

	public GameObject m_AccessibilityTab;

	public GameObject m_DisplayTab;

	public GameObject m_QualityTab;

	public GameObject m_AudioTab;

	public GameObject m_ControlsTab;

	public GameObject m_ControlsDiagramTab;

	public GameObject m_RebindingTab;

	public GameObject m_BrightnessTab;

	public GameObject m_AutosaveTab;

	public GameObject m_PrivacyTab;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<OptionTopMenuItem> m_MenuItems;

	public UIButton m_MainMenuItem_OptionsHeader;

	public GameObject m_MainMenuItem_AccessibilityBackground;

	public GameObject m_MainMenuItem_DisplayBackground;

	public GameObject m_MainMenuItem_QualityBackground;

	public GameObject m_MainMenuItem_BrightnessBackground;

	public GameObject m_MainMenuItem_AudioBackground;

	public GameObject m_MainMenuItem_ControlsBackground;

	public GameObject m_MainMenuItem_RebindBackground;

	public GameObject m_MainMenuItem_AutosaveBackground;

	public GameObject m_MainMenuItem_PrivacyBackground;

	private BasicMenu m_BasicMenu;

	private int m_SelectedTabIndex;

	private List<GameObject> m_Tabs;

	private List<GameObject> m_MainMenuItemTabs;

	private List<GameObject> m_MainMenuItemsBackground;

	private SettingsState State
	{
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ModeAndResolutionDifferentThanCurrent")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 111)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeAccessibilityMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	private void RefreshAccessibilitySettings()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	private void OnConfirmAccessibility()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	public void ApplyAccessibilityOptions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	private void OnAccessibilityTab()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	private void ProcessAccessibilityMenu()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	public void ApplyVolumeSettings()
	{
	}

	[CallerCount(Count = 0)]
	public void OnAudioSliderChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnAudioTab()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyMasterVolume()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	private void ApplySoundVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	private void ApplyMusicVolume()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	private void ApplyVoiceVolume()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyPanningRule()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void RefreshAudioSettings()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	private void OnConfirmAudio()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	private void InitializeAudioMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void ProcessAudioMenu()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	private void RefreshAudioSliderLabels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnAutosaveTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnAutosaveMinutesChanged()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void RefreshAutosaveSettings()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallAnalysisFailed]
	private void OnConfirmAutosaveMinutes()
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnConfirmAutosave()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void ApplyAutosaveMinutes()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 12)]
	private void InitializeAutosaveMenuItems()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	private void ProcessAutosaveMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAutosaveSliderLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	public void OnBrightnessChanged()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	public void OnConfirmBrightnessSettings()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnBrightnessTab()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshBrightnessSettings()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void OnConfirmBrightness()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	private void InitializeBrightnessMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void ProcessBrightnessMenu()
	{
	}

	[Calls(Type = typeof(Wind), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[Calls(Type = typeof(WeatherTransition), Member = "Serialize")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "Show")]
	[Calls(Type = typeof(Wind), Member = "Serialize")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(TimeOfDay), Member = "Serialize")]
	private void ToggleGameCameraForBrightness(bool toggle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallsUnknownMethods(Count = 6)]
	public void OnControllerDiagramTab()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateControllerDiagram()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	public void ProcessControllerDiagram()
	{
	}

	[CallerCount(Count = 0)]
	public void OnControlsSliderChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnControlsTab()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 7)]
	private void RefreshControlsSettings()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	private void OnConfirmControls()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void ApplyMouseSensitivity()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	private void ApplyZoomSensitivity()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	private void ApplyAnalogSticksSensitivity()
	{
	}

	[Conditional("UNITY_SWITCH")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnConfirmGyro()
	{
	}

	[CallsUnknownMethods(Count = 103)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeControlsMenuItems()
	{
	}

	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	private void ProcessControlsMenu()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	private void RefreshControlsSliderLabels()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private void UpdateControlsMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAutosaveMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializePrivacyMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeTabs")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAccessibilityMenuItems")]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickOptions")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnOptions")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	public void SetPanelToReturnToOnExit(PanelReference panel)
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CallerCount(Count = 2)]
	private void UpdateActiveMenuItems()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	private void Update()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsSelectButtonActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 4)]
	private bool IsSelectButtonActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 0)]
	private void ClearConfirmSettings()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void ApplyDefaultSettingsToState(SettingsState settingsState)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CommandLineParameterValue")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	public void ApplyCommandLineParameters()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAnalogSticksSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMouseSensitivity")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyZoomSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	public void ApplyAllOptions(bool applyGraphicsModeAndResolution)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsInBrightnessCalibration()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControllerDiagram")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnOptionsClicked")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessKeyRebindMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	public void SettingsNeedConfirmation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnOptionsClicked()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAutosaveMinutes")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmControls")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAccessibility")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	public void OnConfirmSettings()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CallerCount(Count = 0)]
	public static void SaveSettings()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	private void ExitOptions()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ClearConfirmSettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshAccessibilitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshAudioSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSettings")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	private void RefreshSettings()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	private void RefreshSliderLabels()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void DisableMenuItemsBasedOnPlatform()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private float CommandLineParameterValue(string arg)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ShowOptionDescriptionLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	private void MaybeShowOptionDescriptionLabel(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void ShowOptionDescriptionLabel(GameObject menuItem, string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[CallsUnknownMethods(Count = 1)]
	public void SetStartupDisplayValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnFOVChanged()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 0)]
	public void OnDisplayTab()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmFOV")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	public void ApplyFOV()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ApplyHudSize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnDisable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	public void ApplyHudType()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void ApplyBrightness()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	private void ApplyVsync()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	private bool ApplyDisplayNumber()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[CallsUnknownMethods(Count = 1)]
	private bool CopyDisplayNumber(int pendingDisplayNumber)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ModeAndResolutionDifferentThanCurrent")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "PopulateDisplayNumberPopupList")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyDisplayNumber")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyDisplayNumber")]
	private int GetCurrentDisplayNumber()
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyDisplayNumber")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	public void ApplyGraphicsModeAndResolution(bool applyDisplayNumber)
	{
	}

	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void RefreshDisplaySettings()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGraphicsModeFromString")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	private void CopyGraphicModeAndResolution()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	private void ApplyGraphicMode()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private void OnConfirmGraphicsOptions()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnConfirmVsyncAndFrameCap()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmSubtitles()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	private void OnConfirmLanguage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmFOV()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmUnits()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	private void OnConfirmHudSize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmHudType()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnConfirmWolfMoraleMeter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmImageFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSubtitles")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnConfirmDisplay()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 234)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeDisplayMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	public void RestoreResolution()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGraphicsModeFromString")]
	private void ProcessDisplayMenu()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void PopulateDisplayNumberPopupList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[CallsUnknownMethods(Count = 5)]
	private bool ModeAndResolutionDifferentThanCurrent()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "PopulateDisplayNumberPopupList")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 3)]
	private string GetDisplayNumberString(int displayNumber)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private int GetDisplayNumberFromString(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	private GraphicsMode GetGraphicsModeFromString(string text)
	{
		return default(GraphicsMode);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private int GetScreenResolutionIndexFromString(string text)
	{
		return default(int);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	private string GetResolutionString(int width, int height)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void SetDefaultVsync()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	public void ForceTempResolutionChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[IteratorStateMachine(typeof(_003CStartForceTempResolutionChangeCo_003Ed__223))]
	public static IEnumerator StartForceTempResolutionChangeCo()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshDisplaySliderLabels()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsResolutionSupported(GraphicsMode mode, int width, int height)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private Resolution GetClosestSupportedResolution(GraphicsMode mode, int width, int height)
	{
		return default(Resolution);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Screen), Member = "get_resolutions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetClosestSupportedResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallsUnknownMethods(Count = 2)]
	private bool ResolutionCompatibleWithGraphicsMode(GraphicsMode mode, int width, int height)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	private Resolution GetHighestCompatibleResolutionForGraphicsMode(GraphicsMode mode)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private void RefreshResolutionsStandalone(GraphicsMode mode)
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CallerCount(Count = 0)]
	private void RefreshResolutions(GraphicsMode mode)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DoSafetyChecksOnCurrentState")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetStartupDisplayValues")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	private static void CopyScreenResolution(ref Resolution dest)
	{
	}

	[CallerCount(Count = 0)]
	private void CopyResolution(ref Resolution dest, Resolution source)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	private bool CanChangeFovOption()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	private void UpdateDisplayMenuItems()
	{
	}

	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanLockFPS()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPopupClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveTab")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAccessibilityTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAudioTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControlsTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnDisplayTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnPrivacyTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnQualityTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControllerDiagramTab")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DisableMenuBackgrounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void OnTabCommon(GameObject tab, List<GameObject> menuItems, int buttonIndex)
	{
	}

	[Calls(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGenericSliderMovementHorizontal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsHoveringOverGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 11)]
	private void UpdateMenuNavigationGeneric(ref int index, List<GameObject> menuItems)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private float GetGenericSliderMovementHorizontal()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void DisableMenuBackgrounds(List<GameObject> menu)
	{
	}

	[CallerCount(Count = 0)]
	private float GetNormalizedValue(float min, float max, float val)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	private int SetupMenuPositions(List<GameObject> menuItems)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	private void InitSlider(ConsoleSlider slider, int numSteps)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGroundDetailsDensityChanged")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGroundDetailsDrawDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTreeBillboardDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTreeDrawDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnShadowDrawDistanceChanged")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveMinutesChanged")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnFOVChanged")]
	private void OnSliderChanged(ConsoleSlider slider, float min, float max, int numFramesInTab)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void RefreshSliderLabel(UISlider slider)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsHoveringOverGameObject(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	public void OnResetKeyBindings()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnKeyRebindButtonPress(GameObject buttonPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	public void OnRebindingTab()
	{
	}

	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	private void ProcessKeyRebindMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	private bool UpdateKeyBindings()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateKeyBindings")]
	[CallsUnknownMethods(Count = 2)]
	private void CancelRebindPopup()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static string GetLanguageStringFromSystemLang()
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void RefreshLanguage()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ForceCurrentMissionDisplayUpdate")]
	private void SetLanguage(string langState)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private string GetLangIDFromName(string langName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnPrivacyTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnViewPrivacyPolicy()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	private static void OnManagePrivacyDataFailed(string reason)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DataPrivacy), Member = "FetchPrivacyUrl")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CallsUnknownMethods(Count = 11)]
	public void OnManagePrivacyData()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 47)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializePrivacyMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnManagePrivacyData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void ProcessPrivacyMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshPrivacySettings()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void OnConfirmPrivacySettings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnShadowDrawDistanceChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnTreeDrawDistanceChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnTreeBillboardDistanceChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnGroundDetailsDrawDistanceChanged()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	[CallerCount(Count = 0)]
	public void OnGroundDetailsDensityChanged()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 0)]
	public void OnQualityTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshQualitySettings()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void SetUiFromQualitySetting(QualityLevelSettings settings)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	private void OnConfirmQuality()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetFootprintQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTextureStreamingFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetSSAOLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLodBiasQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetTerrainLodQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetPostFxQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetTextureResolutionFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowResolutionFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowQualityFromString")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 7)]
	private void SetQualitySettingsFromUi(QualityLevelSettings settings)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 347)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 47)]
	[CallerCount(Count = 1)]
	private void InitializeQualityMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	private void ProcessQualityMenu()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "Match")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	private void MaybeSwitchToCustomQuality(QualityLevelSettings preset, QualityLevelSettings current)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	private string GetQualityLevelString(Quality quality)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetPostFxQualityLevelString(QualityPostFx quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private QualityPostFx GetPostFxQualityLevelFromString(string quality)
	{
		return default(QualityPostFx);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private string GetFootprintQualityLevelString(QualityFootprints quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private QualityFootprints GetFootprintQualityLevelFromString(string quality)
	{
		return default(QualityFootprints);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetSSAOLevelString(QualitySSAO quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private QualitySSAO GetSSAOLevelFromString(string quality)
	{
		return default(QualitySSAO);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private string GetShadowQualityString(QualityShadows quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	private QualityShadows GetShadowQualityFromString(string res)
	{
		return default(QualityShadows);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetShadowResolutionString(ShadowResolution res)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private ShadowResolution GetShadowResolutionFromString(string res)
	{
		return default(ShadowResolution);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	private void SetTextureStreamingFromString(string setting, out bool enabled, out int budget)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref enabled) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref budget) = null;
	}

	[CallerCount(Count = 0)]
	private string GetTextureStreamingString(bool enabled, int budget)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private string GetTextureResolutionString(int textureLimit)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	private int GetTextureResolutionFromString(string textureLimit)
	{
		return default(int);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	private string GetTerrainLodQualityString(QualityTerrainLod quality)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private QualityTerrainLod GetTerrainLodQualityFromString(string quality)
	{
		return default(QualityTerrainLod);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetLodBiasQualityString(QualityLodBias quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private QualityLodBias GetLodBiasQualityFromString(string quality)
	{
		return default(QualityLodBias);
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private Quality GetQualityLevelFromString(string level)
	{
		return default(Quality);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	private void RefreshQualitySliderLabels()
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSafetyChecksOnCurrentState")]
	private void OnBeforeSerialization(SettingsState settingsState)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnAfterDeserialization(SettingsState settingsState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLanguageStringFromSystemLang")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	private void ValidateSettingsState(SettingsState settingsState)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBeforeSerialization")]
	[Calls(Type = typeof(ServerTime), Member = "ValidateTime")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	private void DoSafetyChecksOnCurrentState(SettingsState settingsState)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void InitializeTopMenu()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 40)]
	private void InitializeTabs()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 37)]
	private void InitializeTopMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void ProcessTopMenu()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 46)]
	private Action GetActionFromType(OptionTopMenuItem.MenuType type)
	{
		return null;
	}

	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	private int GetTabSelectedIndex()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private void ConfigureMenu()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	private void MainMenuTabOnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void SetAllTabsActive(bool active)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnRebindingTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	private void SetTabActive(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 95)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	public Panel_OptionsMenu()
	{
	}
}
