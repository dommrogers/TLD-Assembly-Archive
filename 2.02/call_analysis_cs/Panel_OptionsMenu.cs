using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
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
		[CallerCount(Count = 2)]
		public OptionTopMenuItem()
		{
		}
	}

	private delegate void OnDelegate();

	private sealed class _003CStartForceTempResolutionChangeCo_003Ed__183 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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

		[DeduplicatedMethod]
		[DebuggerHidden]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[CallsUnknownMethods(Count = 7)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
		private bool MoveNext()
		{
			return default(bool);
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
	[CallsUnknownMethods(Count = 155)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeAccessibilityMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_fontSize")]
	public void ApplyAccessibilityOptions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	private void OnAccessibilityTab()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	private void ProcessAccessibilityMenu()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	private void ApplyMasterVolume()
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
	private void ApplySoundVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	private void ApplyMusicVolume()
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
	private void ApplyVoiceVolume()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	private void ApplyPanningRule()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAudioSettings()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void OnConfirmAudio()
	{
	}

	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsUnknownMethods(Count = 91)]
	private void InitializeAudioMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void ProcessAudioMenu()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	private void RefreshAudioSliderLabels()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 0)]
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

	[CallAnalysisFailed]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnConfirmAutosave()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void ApplyAutosaveMinutes()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 18)]
	private void InitializeAutosaveMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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
	[Calls(Type = typeof(HDRManager), Member = "SetPaperWhiteNits")]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
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

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(InputManager), Member = "InitializeDefaultKeybindings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnBrightnessTab()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	private void RefreshBrightnessSettings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmBrightness()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[CallsUnknownMethods(Count = 36)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	private void InitializeBrightnessMenuItems()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void ProcessBrightnessMenu()
	{
	}

	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[Calls(Type = typeof(Wind), Member = "Deserialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(BrightnessCalibration), Member = "Show")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeatherTransition), Member = "ForceUnmanagedWeatherStage")]
	[Calls(Type = typeof(Wind), Member = "Serialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Serialize")]
	[Calls(Type = typeof(WeatherTransition), Member = "Serialize")]
	[Calls(Type = typeof(Weather), Member = "DisableWindEffect")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	private void ToggleGameCameraForBrightness(bool toggle)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallsUnknownMethods(Count = 7)]
	public void OnControllerDiagramTab()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void UpdateControllerDiagram()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ProcessControllerDiagram()
	{
	}

	[CallerCount(Count = 0)]
	public void OnControlsSliderChanged()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 0)]
	public void OnControlsTab()
	{
	}

	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void RefreshControlsSettings()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	private void OnConfirmControls()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyMouseSensitivity()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ApplyZoomSensitivity()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyAnalogSticksSensitivity()
	{
	}

	[DeduplicatedMethod]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 2)]
	private void OnConfirmGyro()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 150)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	private void InitializeControlsMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "ShowSteamControllerBindingPanel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
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

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	private void UpdateControlsMenuItems()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	[CallerCount(Count = 0)]
	public void OnFOVChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	public void OnDisplayTab()
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Reset")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmFOV")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponFromID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	public void ApplyFOV()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void ApplyHudSize()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnDisable")]
	public void ApplyHudType()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	[Calls(Type = typeof(HDRManager), Member = "SetPaperWhiteNits")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	public void ApplyBrightness()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_vsync")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[CallerCount(Count = 4)]
	public void ApplyVsync()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool ApplyDisplayNumber()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool CopyDisplayNumber(int pendingDisplayNumber)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__183), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	public void ApplyGraphicsModeAndResolution(bool applyDisplayNumber)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	private void RefreshDisplaySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGraphicsModeFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberFromString")]
	private void CopyGraphicModeAndResolution()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	private void OnConfirmVsyncAndFrameCap()
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnConfirmSubtitles()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshObjectiveLabel")]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmLanguage()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnConfirmFOV()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmUnits()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[CallsUnknownMethods(Count = 5)]
	private void OnConfirmHudSize()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void OnConfirmHudType()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmWolfMoraleMeter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmShowStoryPlayerPosition()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private void OnConfirmImageFilter()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshObjectiveLabel")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	private void OnConfirmDisplay()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "PopulateDisplayNumberPopupList")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupLockedFPS")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 337)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeDisplayMenuItems()
	{
	}

	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__183), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RestoreResolution()
	{
	}

	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGraphicsModeFromString")]
	private void ProcessDisplayMenu()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CallsUnknownMethods(Count = 6)]
	private void PopulateDisplayNumberPopupList()
	{
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "GetInt")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private bool ModeAndResolutionDifferentThanCurrent()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetDisplayNumberString(int displayNumber)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private int GetDisplayNumberFromString(string text)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	private GraphicsMode GetGraphicsModeFromString(string text)
	{
		return default(GraphicsMode);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__183), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private int GetScreenResolutionIndexFromString(string text)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
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

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void ForceTempResolutionChange()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 6)]
	private bool IsResolutionSupported(GraphicsMode mode, int width, int height)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private Resolution GetClosestSupportedResolution(GraphicsMode mode, int width, int height)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetClosestSupportedResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Screen), Member = "get_resolutions")]
	private bool ResolutionCompatibleWithGraphicsMode(GraphicsMode mode, int width, int height)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CallsUnknownMethods(Count = 11)]
	private Resolution GetHighestCompatibleResolutionForGraphicsMode(GraphicsMode mode)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[CallerCount(Count = 6)]
	private void RefreshResolutionsStandalone(GraphicsMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	private void RefreshResolutions(GraphicsMode mode)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	private void CopyScreenResolution(ref Resolution dest)
	{
	}

	[CallerCount(Count = 0)]
	private void CopyResolution(ref Resolution dest, Resolution source)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanChangeFovOption()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	private void SetupLockedFPS()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateDisplayMenuItems()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnPopupClicked()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnQualityTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnPrivacyTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnDisplayTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControlsTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControllerDiagramTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAccessibilityTab")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAudioTab")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DisableMenuBackgrounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void OnTabCommon(GameObject tab, List<GameObject> menuItems, int buttonIndex)
	{
	}

	[Calls(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[Calls(Type = typeof(ConsoleSlider), Member = "OnDecrease")]
	[Calls(Type = typeof(ConsoleSlider), Member = "OnIncrease")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsHoveringOverGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGenericSliderMovementHorizontal")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	private void UpdateMenuNavigationGeneric(ref int index, List<GameObject> menuItems)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	private float GetGenericSliderMovementHorizontal()
	{
		return default(float);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void DisableMenuBackgrounds(List<GameObject> menu)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAutosaveSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
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
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGroundDetailsDrawDistanceChanged")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGroundDetailsDensityChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTreeBillboardDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnShadowDrawDistanceChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnFOVChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveMinutesChanged")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTreeDrawDistanceChanged")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void OnSliderChanged(ConsoleSlider slider, float min, float max, int numFramesInTab)
	{
	}

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshSliderLabel(UISlider slider)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsHoveringOverGameObject(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	public void OnResetKeyBindings()
	{
	}

	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void OnKeyRebindButtonPress(GameObject buttonPressed)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "InitializeDefaultKeybindings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[CallsUnknownMethods(Count = 1)]
	public void OnRebindingTab()
	{
	}

	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	private void ProcessKeyRebindMenu()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	private bool UpdateKeyBindings()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateKeyBindings")]
	private void CancelRebindPopup()
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static string GetLanguageStringFromSystemLang()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void RefreshLanguage()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void SetDefaultLanguage()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_HUD), Member = "ForceCurrentMissionDisplayUpdate")]
	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	private static void SetLanguage(string langState)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private string GetLangIDFromName(string langName)
	{
		return null;
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 0)]
	public void OnPrivacyTab()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnViewPrivacyPolicy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private static void OnManagePrivacyDataFailed(string reason)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataPrivacy), Member = "FetchPrivacyUrl")]
	[CallsUnknownMethods(Count = 16)]
	public void OnManagePrivacyData()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 64)]
	private void InitializePrivacyMenuItems()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnManagePrivacyData")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ProcessPrivacyMenu()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RefreshPrivacySettings()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	private void OnConfirmPrivacySettings()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnSliderChanged")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void RefreshQualitySettings()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void SetUiFromQualitySetting(QualityLevelSettings settings)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	private void OnConfirmQuality()
	{
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetFootprintQualityLevelFromString")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowResolutionFromString")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTextureStreamingFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetTerrainLodQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLodBiasQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetSSAOLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetPostFxQualityLevelFromString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void SetQualitySettingsFromUi(QualityLevelSettings settings)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 465)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 44)]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void InitializeQualityMenuItems()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeSwitchToCustomQuality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	private void ProcessQualityMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "CopyQualitySettings")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "Match")]
	private void MaybeSwitchToCustomQuality(QualityLevelSettings preset, QualityLevelSettings current)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	private string GetQualityLevelString(Quality quality)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetPostFxQualityLevelString(QualityPostFx quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private QualityPostFx GetPostFxQualityLevelFromString(string quality)
	{
		return default(QualityPostFx);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private string GetFootprintQualityLevelString(QualityFootprints quality)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private QualityFootprints GetFootprintQualityLevelFromString(string quality)
	{
		return default(QualityFootprints);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private string GetSSAOLevelString(QualitySSAO quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private QualitySSAO GetSSAOLevelFromString(string quality)
	{
		return default(QualitySSAO);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private string GetShadowQualityString(QualityShadows quality)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private QualityShadows GetShadowQualityFromString(string res)
	{
		return default(QualityShadows);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private string GetShadowResolutionString(ShadowResolution res)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private ShadowResolution GetShadowResolutionFromString(string res)
	{
		return default(ShadowResolution);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	private void SetTextureStreamingFromString(string setting, out bool enabled, out int budget)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref enabled) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref budget) = null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetTextureStreamingString(bool enabled, int budget)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	private string GetTextureResolutionString(int textureLimit)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private int GetTextureResolutionFromString(string textureLimit)
	{
		return default(int);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetTerrainLodQualityString(QualityTerrainLod quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private QualityTerrainLod GetTerrainLodQualityFromString(string quality)
	{
		return default(QualityTerrainLod);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private string GetLodBiasQualityString(QualityLodBias quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private QualityLodBias GetLodBiasQualityFromString(string quality)
	{
		return default(QualityLodBias);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private Quality GetQualityLevelFromString(string level)
	{
		return default(Quality);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	private void RefreshQualitySliderLabels()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FeatsManager), Member = "Serialize")]
	public static string Serialize(bool saveFeatData)
	{
		return null;
	}

	[Calls(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "SetToken")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetCurrentQualityLevel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[Calls(Type = typeof(InputManager), Member = "ApplyRemapping")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(Application), Member = "get_systemLanguage")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetMappingFromCInput")]
	private static void DeserializeSettings(ProfileState currentState, ProfileState restoredState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 4)]
	private static void DeserializeFeats(ProfileState currentState, ProfileState restoredState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[Calls(Type = typeof(EpisodeManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 32)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "MaybeInitializeAllTimeBestStats")]
	private static void DeserializeProgress(ProfileState currentState, ProfileState restoredState)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "UpdateProfileAgainstFile")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static void TryToFindAndReplaceInvalidNowhereToHideEnumEntry(ref string text)
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DeserializeSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "TryToFindAndReplaceInvalidNowhereToHideEnumEntry")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DeserializeProgress")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static bool Deserialize(string text, ProfileSerializationOptions deserializeFlags)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Action_4DONDayComplete), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	public void Mark4DONCurrentDayComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	public bool Is4DONCurrentDayComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	public void Reset4DONBadgeProgress()
	{
	}

	[CallerCount(Count = 0)]
	public static Quality GetQualityLevelFromLegacyQuality(int legacyQualityLevel)
	{
		return default(Quality);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static bool IsUpsellViewed(UpSell upsell)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Panel_Badges), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnChallenges")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallsUnknownMethods(Count = 6)]
	public static void ViewUpsell(UpSell upsell)
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[Calls(Type = typeof(GameManager), Member = "ValidateTime")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private static void DoSaftyChecksOnCurrentState()
	{
	}

	[CallerCount(Count = 0)]
	private static float GetNormalizedSensitivity(float current, float min, float mid, float max)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private static bool ResolutionIsValid(Resolution res)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetCurrentQualityLevel")]
	[CallsUnknownMethods(Count = 2)]
	private static void RestoreLegacyQualityLevel(int legacyQualityLevel)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeTopMenu()
	{
	}

	[CallsUnknownMethods(Count = 44)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void InitializeTabs()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 38)]
	private void InitializeTopMenuItems()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	private void ProcessTopMenu()
	{
	}

	[CallsUnknownMethods(Count = 63)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	private Action GetActionFromType(OptionTopMenuItem.MenuType type)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	private int GetTabSelectedIndex()
	{
		return default(int);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	private void MainMenuTabOnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	private void SetAllTabsActive(bool active)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnRebindingTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UnlockCrashMountainRegion()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "RefreshVisualsScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallsUnknownMethods(Count = 13)]
	public void MarkBadgeAsViewed(string badgeLocID)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "ListHasUnviewedUnlockedBadge")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasBadgeBeenViewed(string badgeLocID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "OnStop")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public bool MarkCinematicAsViewed(string cinematic)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForInterrupt")]
	[CalledBy(Type = typeof(PlayableAssetJumpToTime), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSkip), Member = "CreatePlayable")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasCinematicBeenViewed(string cinematic)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasMarkedAchievementUnlocked")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CallsUnknownMethods(Count = 12)]
	public void MarkAchievementUnlocked(Achievement achievement)
	{
	}

	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MarkAchievementUnlocked")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool HasMarkedAchievementUnlocked(Achievement achievement)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CalledBy(Type = typeof(Notifications), Member = "LoadNotifications")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasNotificationBeenViewed(string notification)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Populate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void MarkNotificationAsViewed(string notification)
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializePrivacyMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAutosaveMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeTabs")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitializeAccessibilityMenuItems")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemValueIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	private void UpdateActiveMenuItems()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsSelectButtonActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private bool IsSelectButtonActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	private void ClearConfirmSettings()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	public void SetDefaultOptionsAtStartup()
	{
	}

	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetCurrentQualityLevel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallerCount(Count = 1)]
	public void ApplyCommandLineParameters()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAnalogSticksSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMouseSensitivity")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyZoomSensitivity")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	public void ApplyAllOptions(bool applyGraphicsModeAndResolution)
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(BasicMenu), Member = "GetItemCount")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsInBrightnessCalibration()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControllerDiagram")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnOptionsClicked")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessKeyRebindMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Weather), Member = "EnableWindEffect")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 15)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	public void SettingsNeedConfirmation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 2)]
	public void OnOptionsClicked()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "ApplyRemapping")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SaveSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAutosaveMinutes")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightnessSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmControls")]
	[Calls(Type = typeof(HDRManager), Member = "GetPaperWhiteFromRange")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAccessibility")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	public void OnConfirmSettings()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SaveToken")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.AuthenticateOperation), Member = "SaveToken")]
	public static void SaveSettings()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	private void ExitOptions()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetNormalizedValue")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ClearConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CallsUnknownMethods(Count = 31)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshAccessibilitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSettings")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	private void RefreshSettings()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
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
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	private void RefreshSliderLabels()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void DisableMenuItemsBasedOnPlatform()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 6)]
	private float CommandLineParameterValue(string arg)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ShowOptionDescriptionLabel")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ShowOptionDescriptionLabel")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeShowOptionDescriptionLabel(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void ShowOptionDescriptionLabel(GameObject menuItem, string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 118)]
	public Panel_OptionsMenu()
	{
	}
}
