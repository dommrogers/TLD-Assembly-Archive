using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using Steamworks;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class Panel_OptionsMenu : Panel_Base
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
		[CallerCount(Count = 7)]
		public OptionTopMenuItem()
		{
		}
	}

	private delegate void OnDelegate();

	private sealed class _003CStartForceTempResolutionChangeCo_003Ed__183 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStartForceTempResolutionChangeCo_003Ed__183(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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

	public ConsoleComboBox m_GraphicsResolutionPopupList;

	public ConsoleComboBox m_GraphicsModePopupList;

	public ConsoleComboBox m_DisplayNumberPopupList;

	public ConsoleComboBox m_UnitsPopupList;

	public ConsoleComboBox m_HudSizePopupList;

	public ConsoleComboBox m_HudTypePopupList;

	public ConsoleComboBox m_WolfMoraleMeterPopupList;

	public ConsoleComboBox m_ShowStoryPlayerPositionPopupList;

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

	private List<GameObject> m_DisplayMenuItems;

	private List<Resolution> m_Resolutions;

	private Resolution m_ResolutionAtStartup;

	private bool m_HasAppliedCommandLineParameters;

	private bool m_FullScreenAtStartup;

	private int m_RestoreResolutionIndex;

	private bool m_DeferSwitchToFullscreen;

	private bool m_IsLockedFPSEnabled;

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

	private static int m_CurrentVersion;

	private static int m_LowestCompatibleVersion;

	public GameObject m_ConfirmButton;

	public GameObject m_BackButton;

	public UILabel m_OptionDescriptionLabel;

	public ButtonLegendContainer m_ButtonLegendContainer;

	private float m_DescriptionLabelHorizontalPosition;

	public ProfileState m_State;

	public bool m_EnablePauseMenuOnExit;

	public bool m_ForceCloseOnConfirm;

	private bool m_OptionsAppliedAtStartup;

	private bool m_SettingsNeedConfirmation;

	private bool m_SettingsNeedRestart;

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 155)]
	private void InitializeAccessibilityMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void RefreshAccessibilitySettings()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	private void OnConfirmAccessibility()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void ApplyAccessibilityOptions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	private void OnAccessibilityTab()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessAccessibilityMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyMasterVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ApplySoundVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyMusicVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyVoiceVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyPanningRule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAudioSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	private void OnConfirmAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 91)]
	private void InitializeAudioMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessAudioMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAutosaveSettings()
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnConfirmAutosaveMinutes()
	{
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnConfirmAutosave()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ApplyAutosaveMinutes()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private void InitializeAutosaveMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(HDRManager), Member = "SetPaperWhiteNits")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void OnBrightnessChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessChanged")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	public void OnConfirmBrightnessSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "InitializeDefaultKeybindings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void OnBrightnessTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshBrightnessSettings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmBrightness()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 36)]
	private void InitializeBrightnessMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessBrightnessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[Calls(Type = typeof(WeatherTransition), Member = "Serialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Serialize")]
	[Calls(Type = typeof(Wind), Member = "Serialize")]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "Show")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(Wind), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private void ToggleGameCameraForBrightness(bool toggle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void OnControllerDiagramTab()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void UpdateControllerDiagram()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	private void RefreshControlsSettings()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	private void OnConfirmControls()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyMouseSensitivity()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyZoomSensitivity()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyAnalogSticksSensitivity()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnConfirmGyro()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 150)]
	private void InitializeControlsMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "ShowSteamControllerBindingPanel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void ProcessControlsMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshControlsSliderLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 31)]
	private void UpdateControlsMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnFOVChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnDisplayTab()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmFOV")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public void ApplyFOV()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 37)]
	public void ApplyHudSize()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnDisable")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyHudType()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HDRManager), Member = "SetPaperWhiteNits")]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public void ApplyBrightness()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_vsync")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void ApplyVsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool ApplyDisplayNumber()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool CopyDisplayNumber(int pendingDisplayNumber)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__183), Member = "MoveNext")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 32)]
	public void ApplyGraphicsModeAndResolution(bool applyDisplayNumber)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 38)]
	private void RefreshDisplaySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGraphicsModeFromString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void CopyGraphicModeAndResolution()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	private void ApplyGraphicMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmGraphicsOptions()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnConfirmVsyncAndFrameCap()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnConfirmSubtitles()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshObjectiveLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmLanguage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmFOV()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmUnits()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnConfirmHudSize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void OnConfirmHudType()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmWolfMoraleMeter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmShowStoryPlayerPosition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Enum), Member = "TryParse")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnConfirmImageFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshObjectiveLabel")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Enum), Member = "TryParse")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 36)]
	private void OnConfirmDisplay()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupLockedFPS")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "PopulateDisplayNumberPopupList")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallsUnknownMethods(Count = 337)]
	private void InitializeDisplayMenuItems()
	{
	}

	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__183), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void RestoreResolution()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGraphicsModeFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void ProcessDisplayMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void PopulateDisplayNumberPopupList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private bool ModeAndResolutionDifferentThanCurrent()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetDisplayNumberString(int displayNumber)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	private int GetDisplayNumberFromString(string text)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	private GraphicsMode GetGraphicsModeFromString(string text)
	{
		return default(GraphicsMode);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__183), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private int GetScreenResolutionIndexFromString(string text)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetResolutionString(int width, int height)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetDefaultVsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void ForceTempResolutionChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool IsResolutionSupported(GraphicsMode mode, int width, int height)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private Resolution GetClosestSupportedResolution(GraphicsMode mode, int width, int height)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetClosestSupportedResolution")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Screen), Member = "get_resolutions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool ResolutionCompatibleWithGraphicsMode(GraphicsMode mode, int width, int height)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private Resolution GetHighestCompatibleResolutionForGraphicsMode(GraphicsMode mode)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutions")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	private void RefreshResolutionsStandalone(GraphicsMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	private void RefreshResolutions(GraphicsMode mode)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void CopyScreenResolution(ref Resolution dest)
	{
	}

	[CallerCount(Count = 0)]
	private void CopyResolution(ref Resolution dest, Resolution source)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool CanChangeFovOption()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(TypeFullName = "Steamworks.NativeMethods", Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void SetupLockedFPS()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateDisplayMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnPopupClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAccessibilityTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAudioTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControllerDiagramTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControlsTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnDisplayTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnPrivacyTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnQualityTab")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DisableMenuBackgrounds")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private void OnTabCommon(GameObject tab, List<GameObject> menuItems, int buttonIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsHoveringOverGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGenericSliderMovementHorizontal")]
	[Calls(Type = typeof(ConsoleSlider), Member = "OnIncrease")]
	[Calls(Type = typeof(ConsoleSlider), Member = "OnDecrease")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 29)]
	private void UpdateMenuNavigationGeneric(ref int index, List<GameObject> menuItems)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private float GetGenericSliderMovementHorizontal()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void DisableMenuBackgrounds(List<GameObject> menu)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAutosaveSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetNormalizedValue(float min, float max, float val)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private int SetupMenuPositions(List<GameObject> menuItems)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void InitSlider(ConsoleSlider slider, int numSteps)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveMinutesChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnFOVChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnShadowDrawDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTreeDrawDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTreeBillboardDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGroundDetailsDrawDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGroundDetailsDensityChanged")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void OnSliderChanged(ConsoleSlider slider, float min, float max, int numFramesInTab)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAudioSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAutosaveSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshSliderLabel(UISlider slider)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private bool IsHoveringOverGameObject(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnResetKeyBindings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void OnKeyRebindButtonPress(GameObject buttonPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "InitializeDefaultKeybindings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnRebindingTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ProcessKeyRebindMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool UpdateKeyBindings()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateKeyBindings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void CancelRebindPopup()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	public static string GetLanguageStringFromSystemLang()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void RefreshLanguage()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SetDefaultLanguage()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(Panel_HUD), Member = "ForceCurrentMissionDisplayUpdate")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	private static void SetLanguage(string langState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnViewPrivacyPolicy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void OnManagePrivacyDataFailed(string reason)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataPrivacy), Member = "FetchPrivacyUrl")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public void OnManagePrivacyData()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 64)]
	private void InitializePrivacyMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnManagePrivacyData")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void ProcessPrivacyMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshPrivacySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	public void OnGroundDetailsDensityChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnQualityTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshQualitySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 28)]
	private void SetUiFromQualitySetting(QualityLevelSettings settings)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void OnConfirmQuality()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowResolutionFromString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTextureStreamingFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetTerrainLodQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLodBiasQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetSSAOLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetPostFxQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetFootprintQualityLevelFromString")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	private void SetQualitySettingsFromUi(QualityLevelSettings settings)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 44)]
	[CallsUnknownMethods(Count = 465)]
	private void InitializeQualityMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void ProcessQualityMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "Match")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSwitchToCustomQuality(QualityLevelSettings preset, QualityLevelSettings current)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 2)]
	private string GetQualityLevelString(Quality quality)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetPostFxQualityLevelString(QualityPostFx quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private QualityFootprints GetFootprintQualityLevelFromString(string quality)
	{
		return default(QualityFootprints);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetSSAOLevelString(QualitySSAO quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private QualityShadows GetShadowQualityFromString(string res)
	{
		return default(QualityShadows);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetShadowResolutionString(ShadowResolution res)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private ShadowResolution GetShadowResolutionFromString(string res)
	{
		return default(ShadowResolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetTextureStreamingFromString(string setting, out bool enabled, out int budget)
	{
		enabled = default(bool);
		budget = default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetTextureStreamingString(bool enabled, int budget)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetTextureResolutionString(int textureLimit)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private int GetTextureResolutionFromString(string textureLimit)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetTerrainLodQualityString(QualityTerrainLod quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private QualityTerrainLod GetTerrainLodQualityFromString(string quality)
	{
		return default(QualityTerrainLod);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private string GetLodBiasQualityString(QualityLodBias quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	private QualityLodBias GetLodBiasQualityFromString(string quality)
	{
		return default(QualityLodBias);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Quality GetQualityLevelFromString(string level)
	{
		return default(Quality);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshQualitySliderLabels()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(FeatsManager), Member = "Serialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public static string Serialize(bool saveFeatData)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_systemLanguage")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(InputManager), Member = "ApplyRemapping")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetCurrentQualityLevel")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "SetToken")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 22)]
	private static void DeserializeSettings(ProfileState currentState, ProfileState restoredState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void DeserializeFeats(ProfileState currentState, ProfileState restoredState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	[Calls(Type = typeof(EpisodeManager), Member = "Deserialize")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 32)]
	private static void DeserializeProgress(ProfileState currentState, ProfileState restoredState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void TryToFindAndReplaceInvalidNowhereToHideEnumEntry(ref string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "TryToFindAndReplaceInvalidNowhereToHideEnumEntry")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DeserializeProgress")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static bool Deserialize(string text, ProfileSerializationOptions deserializeFlags)
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_4DONDayComplete), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void Mark4DONCurrentDayComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool Is4DONCurrentDayComplete()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void Reset4DONBadgeProgress()
	{
	}

	[CallerCount(Count = 0)]
	public static Quality GetQualityLevelFromLegacyQuality(int legacyQualityLevel)
	{
		return default(Quality);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsUpsellViewed(UpSell upsell)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnChallenges")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void ViewUpsell(UpSell upsell)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "ValidateTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void DoSaftyChecksOnCurrentState()
	{
	}

	[CallerCount(Count = 0)]
	private static float GetNormalizedSensitivity(float current, float min, float mid, float max)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static bool ResolutionIsValid(Resolution res)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetCurrentQualityLevel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void RestoreLegacyQualityLevel(int legacyQualityLevel)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeTopMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 44)]
	private void InitializeTabs()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 38)]
	private void InitializeTopMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessTopMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 63)]
	private Action GetActionFromType(OptionTopMenuItem.MenuType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	private int GetTabSelectedIndex()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 25)]
	private void MainMenuTabOnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetAllTabsActive(bool active)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnRebindingTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SetTabActive(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockCoastalRegion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockRuralRegion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockWhalingStationRegion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockCrashMountainRegion()
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void MarkBadgeAsViewed(string badgeLocID)
	{
	}

	[CalledBy(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasBadgeBeenViewed(string badgeLocID)
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnStop")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public bool MarkCinematicAsViewed(string cinematic)
	{
		return false;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForInterrupt")]
	[CalledBy(Type = typeof(PlayableAssetJumpToTime), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSkip), Member = "CreatePlayable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasCinematicBeenViewed(string cinematic)
	{
		return false;
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasMarkedAchievementUnlocked")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void MarkAchievementUnlocked(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MarkAchievementUnlocked")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasMarkedAchievementUnlocked(Achievement achievement)
	{
		return false;
	}

	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasNotificationBeenViewed(string notification)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public void MarkNotificationAsViewed(string notification)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeTabs")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAccessibilityMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAutosaveMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializePrivacyMenuItems")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemValueIndex")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateActiveMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 18)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsSelectButtonActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private bool IsSelectButtonActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	private void ClearConfirmSettings()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 1)]
	public void SetDefaultOptionsAtStartup()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetCurrentQualityLevel")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public void ApplyCommandLineParameters()
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMouseSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyZoomSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAnalogSticksSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyAllOptions(bool applyGraphicsModeAndResolution)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsInBrightnessCalibration()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControllerDiagram")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessKeyRebindMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnOptionsClicked")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	public void SettingsNeedConfirmation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnOptionsClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAccessibility")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmControls")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAutosaveMinutes")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[Calls(Type = typeof(InputManager), Member = "ApplyRemapping")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SaveSettings")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void OnConfirmSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SaveToken")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.AuthenticateOperation", Member = "SaveToken")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SaveSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void ExitOptions()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ClearConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshAccessibilitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 31)]
	private void RefreshSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void RefreshSliderLabels()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void DisableMenuItemsBasedOnPlatform()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsUnknownMethods(Count = 5)]
	private float CommandLineParameterValue(string arg)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ShowOptionDescriptionLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeShowOptionDescriptionLabel(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	private void ShowOptionDescriptionLabel(GameObject menuItem, string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 118)]
	public Panel_OptionsMenu()
	{
	}
}
