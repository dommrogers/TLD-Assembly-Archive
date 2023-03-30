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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[Calls(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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
		[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ModeAndResolutionDifferentThanCurrent")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
		[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 71)]
	private void InitializeAccessibilityMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UILabel), Member = "ProcessAndRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyAccessibilityOptions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	private void OnAccessibilityTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyMasterVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplySoundVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyMusicVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyVoiceVolume()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyVolumeSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 2)]
	private void ApplyPanningRule()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshAudioSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[CallsUnknownMethods(Count = 5)]
	private void OnConfirmAudio()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 34)]
	private void InitializeAudioMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessAudioMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
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
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyAutosaveMinutes()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void InitializeAutosaveMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void OnBrightnessTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshBrightnessSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[CallsUnknownMethods(Count = 3)]
	private void OnConfirmBrightness()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessBrightnessMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
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
	[CallsUnknownMethods(Count = 15)]
	private void ToggleGameCameraForBrightness(bool toggle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnControllerDiagramTab()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UpdateControllerDiagram()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
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
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetMouseSensitivity")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyMouseSensitivity()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetZoomSensitivity")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyZoomSensitivity()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetGamepadCameraSensitivity")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyAnalogSticksSensitivity()
	{
	}

	[Conditional("UNITY_SWITCH")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnConfirmGyro()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 68)]
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
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessControlsMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshControlsSliderLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "IsPS4Controller")]
	[Calls(Type = typeof(SteamInput), Member = "GetConnectedControllers")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateControlsMenuItems()
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
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "add_OnBeforeSerialization")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "add_OnAfterDeserialization")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public override void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnOptions")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickOptions")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void SetPanelToReturnToOnExit(PanelReference panel)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetupMenuPositions")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateActiveMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetOptionsConfirmPressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 8)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool IsSelectButtonActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	private void ClearConfirmSettings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyDefaultSettingsToState(SettingsState settingsState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIRect), Member = "get_root")]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void ApplyCommandLineParameters()
	{
	}

	[CallerCount(Count = 0)]
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
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyAllOptions(bool applyGraphicsModeAndResolution)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(InputManager), Member = "PopContext")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(InputManager), Member = "PushContext")]
	[Calls(Type = typeof(BasicMenu), Member = "GetSelectedItemIndex")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
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
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnOptionsClicked")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessKeyRebindMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessTopMenu")]
	[CallerCount(Count = 18)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
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
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmControls")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmAudio")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAutosaveMinutes")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 4)]
	public void OnConfirmSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ExitOptions()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ClearConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshAccessibilitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetUiFromQualitySetting")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshAudioSettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSettings")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshLanguage")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshSliderLabels()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void DisableMenuItemsBasedOnPlatform()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsUnknownMethods(Count = 1)]
	private float CommandLineParameterValue(string arg)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ShowOptionDescriptionLabel")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeShowOptionDescriptionLabel(GameObject go)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void ShowOptionDescriptionLabel(GameObject menuItem, string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetStartupDisplayValues()
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
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmFOV")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_RenderingFieldOfViewVertical")]
	[Calls(Type = typeof(Utils), Member = "SetCameraFOVSafe")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ApplyFOV()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyHudSize()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "OnDisable")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(HUDManager), Member = "Start")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyHudType()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmBrightness")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(HDRManager), Member = "SetPeakBrightnessNits")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(float), Member = "ToString")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyBrightness()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(TypeFullName = "Steamworks.NativeMethods", Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ApplyVsync()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool ApplyDisplayNumber()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	private bool CopyDisplayNumber(int pendingDisplayNumber)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyDisplayNumber")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyDisplayNumber")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "PopulateDisplayNumberPopupList")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ModeAndResolutionDifferentThanCurrent")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplays")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private int GetCurrentDisplayNumber()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshDisplays()
	{
	}

	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyAllOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyDisplayNumber")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetClosestSupportedResolution")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIPanel), Member = "SetDirty")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void ApplyGraphicsModeAndResolution(bool applyDisplayNumber)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshDisplaySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetDisplayNumberFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void CopyGraphicModeAndResolution()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	private void ApplyGraphicMode()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmGraphicsOptions()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVsync")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmVsyncAndFrameCap()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmSubtitles()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLangIDFromName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "RefreshMissionMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OnConfirmLanguage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmFOV()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmUnits()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudSize")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmHudSize()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmDisplay")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmHudType()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 1)]
	private void OnConfirmWolfMoraleMeter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmImageFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmVsyncAndFrameCap")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSubtitles")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudSize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmHudType")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(CameraEffects), Member = "SwitchImageFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnConfirmDisplay()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallsUnknownMethods(Count = 168)]
	private void InitializeDisplayMenuItems()
	{
	}

	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void RestoreResolution()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetHighestCompatibleResolutionForGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessDisplayMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PopulateDisplayNumberPopupList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private bool ModeAndResolutionDifferentThanCurrent()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	private string GetDisplayNumberString(int displayNumber)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	private int GetDisplayNumberFromString(string text)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	private GraphicsMode GetGraphicsModeFromString(string text)
	{
		return default(GraphicsMode);
	}

	[CalledBy(Type = typeof(_003CStartForceTempResolutionChangeCo_003Ed__223), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ForceTempResolutionChange")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private int GetScreenResolutionIndexFromString(string text)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetResolutionString(int width, int height)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void SetDefaultVsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetScreenResolutionIndexFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ForceTempResolutionChange()
	{
	}

	[IteratorStateMachine(typeof(_003CStartForceTempResolutionChangeCo_003Ed__223))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 3)]
	private bool IsResolutionSupported(GraphicsMode mode, int width, int height)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private Resolution GetClosestSupportedResolution(GraphicsMode mode, int width, int height)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "get_resolutions")]
	[CallsUnknownMethods(Count = 2)]
	private bool ResolutionCompatibleWithGraphicsMode(GraphicsMode mode, int width, int height)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private Resolution GetHighestCompatibleResolutionForGraphicsMode(GraphicsMode mode)
	{
		return default(Resolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmGraphicsOptions")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutions")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsResolutionSupported")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetResolutionString")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void RefreshResolutionsStandalone(GraphicsMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshResolutionsStandalone")]
	private void RefreshResolutions(GraphicsMode mode)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetStartupDisplayValues")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "CopyGraphicModeAndResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RestoreResolution")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DoSafetyChecksOnCurrentState")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void CopyScreenResolution(ref Resolution dest)
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
	private bool CanChangeFovOption()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CanChangeFovOption")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(TypeFullName = "Steamworks.NativeMethods", Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateDisplayMenuItems()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(TypeFullName = "Steamworks.NativeMethods", Member = "ISteamUtils_IsSteamRunningOnSteamDeck")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanLockFPS()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPopupClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAccessibilityTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAudioTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAutosaveTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControllerDiagramTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnControlsTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnDisplayTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnPrivacyTab")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnQualityTab")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DisableMenuBackgrounds")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateControlsMenuItems")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateDisplayMenuItems")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnTabCommon(GameObject tab, List<GameObject> menuItems, int buttonIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAccessibilityMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAudioMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessAutosaveMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessBrightnessMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessControlsMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessDisplayMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "IsHoveringOverGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMouseOver")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetGenericSliderMovementHorizontal")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateMenuNavigationGeneric(ref int index, List<GameObject> menuItems)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private float GetGenericSliderMovementHorizontal()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void DisableMenuBackgrounds(List<GameObject> menu)
	{
	}

	[CallerCount(Count = 0)]
	private float GetNormalizedValue(float min, float max, float val)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private int SetupMenuPositions(List<GameObject> menuItems)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAudioMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeAutosaveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeBrightnessMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeControlsMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeDisplayMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeQualityMenuItems")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void OnSliderChanged(ConsoleSlider slider, float min, float max, int numFramesInTab)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAudioSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshAutosaveSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshControlsSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplaySliderLabels")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySliderLabels")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(EventDelegate), Member = "IsValid")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshSliderLabel(UISlider slider)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private bool IsHoveringOverGameObject(GameObject go)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	public void OnResetKeyBindings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Collider), Member = "set_enabled")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnKeyRebindButtonPress(GameObject buttonPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	public void OnRebindingTab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromKeyboardPolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "MaybeCreateElementAssignmentFromMousePolling")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonNameForAction")]
	[Calls(Type = typeof(KeyRebindingButton), Member = "SetValueLabel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	private void ProcessKeyRebindMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CancelRebindPopup")]
	private bool UpdateKeyBindings()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateKeyBindings")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void CancelRebindPopup()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[CalledBy(Type = typeof(EmptyScene), Member = "ForceSystemLanguage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetLanguageStringFromSystemLang()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 6)]
	private void RefreshLanguage()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "get_State")]
	[Calls(Type = typeof(Localization), Member = "set_Language")]
	[Calls(Type = typeof(FontManager), Member = "UpdateDummyFonts")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_HUD), Member = "ForceCurrentMissionDisplayUpdate")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[Calls(Type = typeof(UICamera), Member = "get_mainCamera")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void SetLanguage(string langState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmLanguage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "GetForLang")]
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
	public void OnViewPrivacyPolicy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	private static void OnManagePrivacyDataFailed(string reason)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DataPrivacy), Member = "FetchPrivacyUrl")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnManagePrivacyData()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 37)]
	private void InitializePrivacyMenuItems()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(DataPrivacy), Member = "FetchPrivacyUrl")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MaybeShowOptionDescriptionLabel")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessPrivacyMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshPrivacySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	private void RefreshQualitySettings()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void SetUiFromQualitySetting(QualityLevelSettings settings)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "SetAndMaybeApplyQuality")]
	[CallsUnknownMethods(Count = 2)]
	private void OnConfirmQuality()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 7)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetShadowResolutionFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetTextureResolutionFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTextureStreamingFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetTerrainLodQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLodBiasQualityFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetSSAOLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetPostFxQualityLevelFromString")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetFootprintQualityLevelFromString")]
	[CallsUnknownMethods(Count = 6)]
	private void SetQualitySettingsFromUi(QualityLevelSettings settings)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 47)]
	[CallsUnknownMethods(Count = 267)]
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
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessQualityMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "Match")]
	[Calls(Type = typeof(ConsoleComboBox), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSwitchToCustomQuality(QualityLevelSettings preset, QualityLevelSettings current)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshQualitySettings")]
	[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private ShadowResolution GetShadowResolutionFromString(string res)
	{
		return default(ShadowResolution);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	private void SetTextureStreamingFromString(string setting, out bool enabled, out int budget)
	{
		enabled = default(bool);
		budget = default(int);
	}

	[CallerCount(Count = 0)]
	private string GetTextureStreamingString(bool enabled, int budget)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetTextureResolutionString(int textureLimit)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private int GetTextureResolutionFromString(string textureLimit)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private string GetTerrainLodQualityString(QualityTerrainLod quality)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetQualitySettingsFromUi")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private QualityLodBias GetLodBiasQualityFromString(string quality)
	{
		return default(QualityLodBias);
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmQuality")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessQualityMenu")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 5)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSafetyChecksOnCurrentState")]
	[Calls(Type = typeof(InputSystemRewired), Member = "SaveRemapping")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	private void OnBeforeSerialization(SettingsState settingsState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ValidateSettingsState")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "Deserialize")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "SetToken")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(Utils), Member = "EnableAnalytics")]
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
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyQualitySettings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyAccessibilityOptions")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "DoSafetyChecksOnCurrentState")]
	[CallsUnknownMethods(Count = 1)]
	private void OnAfterDeserialization(SettingsState settingsState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetLanguageStringFromSystemLang")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ResolutionCompatibleWithGraphicsMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "RefreshDisplays")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetCurrentDisplayNumber")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[CallsUnknownMethods(Count = 1)]
	private void ValidateSettingsState(SettingsState settingsState)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnBeforeSerialization")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "CopyScreenResolution")]
	[Calls(Type = typeof(ServerTime), Member = "ValidateTime")]
	[CallsUnknownMethods(Count = 3)]
	private void DoSafetyChecksOnCurrentState(SettingsState settingsState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void InitializeTopMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 40)]
	private void InitializeTabs()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 37)]
	private void InitializeTopMenuItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnCancel")]
	[CallsUnknownMethods(Count = 1)]
	private void ProcessTopMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Action GetActionFromType(OptionTopMenuItem.MenuType type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateActiveMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitializeTopMenuItems")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "MainMenuTabOnEnable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "AddMenuItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
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
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	private void MainMenuTabOnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetAllTabsActive(bool active)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnRebindingTab")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void SetTabActive(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 5)]
	public Panel_OptionsMenu()
	{
	}
}
