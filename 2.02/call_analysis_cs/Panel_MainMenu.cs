using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering.PostProcessing;

public class Panel_MainMenu : Panel_Base
{
	private class MailingListResponse
	{
		public string error;

		public string status;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public MailingListResponse()
		{
		}
	}

	[Serializable]
	public class MainMenuItem
	{
		public enum MainMenuItemType
		{
			Story,
			Sandbox,
			Challenges,
			Extras,
			Options,
			Quit,
			FourDaysOfNight
		}

		public static readonly string FOUR_DAYS_OF_NIGHT_ID;

		public MainMenuItemType m_Type;

		public string m_LabelLocalizationId;

		public bool m_UseOverrideTint;

		public Color m_OverrideTintNormal;

		public Color m_OverrideTintHighlight;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public MainMenuItem()
		{
		}
	}

	private enum NotificationState
	{
		Unknown,
		WaitingForProfileToLoad,
		WaitingForWebRequest,
		Ready
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public string url;

		public Notifications notifications;

		public Panel_MainMenu _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass189_0()
		{
		}

		[CallsUnknownMethods(Count = 8)]
		[Calls(Type = typeof(Notifications), Member = "ParseJson")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal void _003CRetrieveNotificationsFromServer_003Eb__0(UnityWebRequest response)
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		internal void _003CRetrieveNotificationsFromServer_003Eb__1(UnityWebRequest response)
		{
		}
	}

	public ScrollList m_FeatSelectionScrollList;

	public GameObject m_FeatSelectionButtonLeft;

	public GameObject m_FeatSelectionButtonRight;

	public UISprite m_ProgressBarSprite;

	public UILabel m_ProgressLabel;

	public UILabel m_FeatNameLabel;

	public UILabel m_FeatDescLabel;

	public UISprite m_FeatDescLinebreak;

	public GameObject m_ActionButtonObject;

	public UILabel m_ActionButtonLabelMouse;

	public UILabel m_ActionButtonLabelGamepad;

	public UISprite m_ActionButtonSpriteGamepad;

	public GameObject[] m_XPModeSpriteObjects;

	public GameObject[] m_ActiveFeatObjects;

	public float m_ActiveFeatCenteredX;

	public float m_ActiveFeatSpacing;

	public UILabel m_FeatBenefitHeaderLabel;

	public UILabel m_FeatBenefitDescriptionLabel;

	private List<BadgeInfo> m_Feats;

	private List<string> m_SelectedFeats;

	private string m_ActionButtonLocID;

	private bool m_ActionButtonEnabled;

	private UIButton m_HinterlandMailingListWidget;

	private ButtonLegendContainer m_HinterlandMailingListButtonLegendContainer;

	private GameObject m_HinterlandMailingListHoverObject;

	private GameObject m_HinterlandMailingListMouseBackground;

	private BoxCollider m_HinterlandMailingListBoxCollider;

	private uint m_CachedMaxLength;

	private string m_CachedKeyboardDesc;

	private bool m_HinterlandMailingListInitialized;

	private bool m_HinterlandMailingListButtonPressed;

	private UIButton m_SkyboundInsidersWidget;

	private ButtonLegendContainer m_SkyboundInsidersButtonLegendContainer;

	private BoxCollider m_SkyboundInsidersBoxCollider;

	private bool m_SkyboundInsidersInitialized;

	private bool m_SkyboundInsidersButtonPressed;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UIPanel m_MainPanel;

	public string m_MainMenuMusic;

	public GameObject m_VersionLabel;

	public GameObject m_AllObjects;

	public bool m_StartFadedOut;

	public float m_FadeOutTimeSeconds;

	public float m_FadeInTimeSeconds;

	public float m_MinDOFFocalLength;

	public float m_MaxDOFFocalLength;

	public float m_NoInputTimeBeforeFading;

	public WeatherStage m_DefaultWeather;

	public int m_DefaultTODStartHour;

	public int m_DefaultTODStartMinutes;

	public WindDirection m_DefaultWindDirection;

	public WindStrength m_DefaultWindStrength;

	public GameObject m_MainWindow;

	public GameObject m_SelectFeatWindow;

	public GameObject m_DefaultSelectedButtonMainMenu;

	public GameObject m_XboxUserPopup;

	public UILabel m_XboxUserNameLabel;

	public UILabel m_TrialModeTimer;

	public UILabel m_SaveErrorMessage;

	public GameObject m_BuyNowObject;

	public float m_InitialScreenFadeInDuration;

	public UISprite m_Sprite_FadeOverlay;

	public GameObject m_HalloweenObject;

	public UILabel m_4DONDayLabel;

	public UILabel m_4DONDailyTimerLabel;

	public static bool m_IsRestarting;

	private StartSettings m_StartSettings;

	private uint m_MusicPlayingID;

	private bool m_Quit;

	private bool m_StartSettingsApplied;

	private float m_PanelAlpha;

	private float m_PanelAlphaTarget;

	private float m_TimeNoInput;

	private SaveSlotType m_SlotTypeSelected;

	private float m_ScreenElapsedTime;

	private string m_SteamMovieFilename;

	private string m_GOGMovieFilename;

	private string m_EpicStoreMovieFilename;

	private string m_XboxMovieFilename;

	private string m_PS4MovieFilename;

	private string m_UwpMovieFilename;

	private string m_SwitchMovieFilename;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<MainMenuItem> m_MenuItems;

	public UILabel m_CloudMessageLabel;

	private BasicMenu m_BasicMenu;

	private float m_WaitingForProfileToLoadTimer;

	private int m_HoldMovieForD3D9Frames;

	private bool m_PlayedIntroMovie;

	private bool m_ShownNotifications;

	private bool m_SelectedFourDaysOfNight;

	private bool m_DoneFourDaysOfNightDeleteCheck;

	private NotificationState m_NotificationUpdateState;

	private static bool m_SavedGamesLoaded;

	private static float m_AdjustedFadeInDuration;

	private static bool m_HasMainMenuFadedIn;

	private bool m_SyncSaveStarted;

	private bool m_SentAnalytics;

	private string m_VersionLabelString;

	private List<BoxCollider> m_ButtonColliders;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void UpdateSelectFeatWindow()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "MarkBadgeAsViewed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatLabels")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void UpdateSelectFeatVisuals()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetIndexFromSandboxExperience")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	protected void FeatSelectWindowSelected()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	public void OnSelectFeatsContinue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnSelectFeatsBack()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameManager), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnToggleFeatActive()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 3)]
	public void FeatSelectionNext()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void FeatSelectionPrev()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 2)]
	public void FeatSelectionIndexSelected(int index)
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "AddFeatToList")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[CallerCount(Count = 1)]
	private void SetupFeatScrollList()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void AddFeatToList(Feat f)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetBadgeIcon")]
	[Calls(Type = typeof(GameManager), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void UpdateSelectedFeats()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private void UpdateFeatProgressBar()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateFeatActionButton()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "HasBadgeBeenViewed")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	private void UpdateFeatMarkerSprites()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void UpdateFeatControls()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateFeatButtonLegend()
	{
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 35)]
	private void UpdateFeatLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	private int GetNumUnlockedFeats()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnEnable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallerCount(Count = 1)]
	private void InitializeHinterlandMailingListWidget()
	{
	}

	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnClickHinterlandMailingListWidget()
	{
	}

	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(NGUIMath), Member = "CalculateRelativeWidgetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButtonPressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	private void UpdateHinterlandMailingListWidget()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void InitializeSkyboundInsidersWidget()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnClickSkyboundInsidersWidget()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void UpdateSkyboundInsidersWidget()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 49)]
	public Action GetActionFromType(MainMenuItem.MainMenuItemType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ResetSlotsRequests()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "InitializeHinterlandMailingListWidget")]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ExitOptions")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickBack")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	public void OnMainMenuTop()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShouldDisableMainMenuButtons")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 3)]
	public bool IsSubMenuEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "TrialModeTimeRemaining")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateMainWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuBuyNowPressed")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Notifications), Member = "Enable")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	[CallsUnknownMethods(Count = 68)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnBrightnessTab")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(Panel_Notifications), Member = "HasNotifications")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[Calls(Type = typeof(Utils), Member = "SendQualitySettingsAnalyticsEvent")]
	[Calls(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "RetrieveNotificationsFromServer")]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "RunInitCommandStory")]
	[CallsDeduplicatedMethods(Count = 31)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableCamera")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[Calls(Type = typeof(InputSystemRewired), Member = "AnyButtonsOrKeysPressed")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[Calls(Type = typeof(BasicMenu), Member = "HasActiveItemByID")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetAnyMouseOrStickMovement")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	private void MaybeDoSteamSynchronization()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateHinterlandMailingListWidget")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	private void UpdateMainWindow()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeAdjustTreeBillboardDistance")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	public void OnStory()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnSandbox()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	public void OnFourDaysOfNight()
	{
	}

	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_Sandbox4DON), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_Choose4DON), Member = "OnLoadSlotClicked")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickResume")]
	public void OnLoadSaveSlot(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(GameManager), Member = "RelaunchBuildToLoadSave")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadSaveSlot")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "PrepareSaveSlotForLoad")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	public void OnLoadGame(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ViewUpsell")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	public void OnChallenges()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickJournals")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableTableOfContentsView")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ViewUpsell")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	public void OnLogs()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[CallsUnknownMethods(Count = 2)]
	public void OnOptions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	public void OnExtras()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnQuit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	public void OnSelectSurvivorBack()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	public void OnSelectSurvivorContinue()
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string NameSandboxGame(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CallsUnknownMethods(Count = 17)]
	private void ShowNameSaveSlotPopup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	private void OnRenameNewSandboxComplete()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnRenameNewSandboxCancel(bool wasCancelled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(GameManager), Member = "RelaunchBuildForNewGame")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxComplete")]
	[CallsUnknownMethods(Count = 7)]
	public void OnSelectSlotNameContinue()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnCreditsEnd")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	public void PlayMainMenuMusic()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnQuit")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStorySaveSlot")]
	[CallsUnknownMethods(Count = 2)]
	public void StopMainMenuMusic()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnExtras")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnOptions")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnFourDaysOfNight")]
	private void DisableMainMenuButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableMainMenuButtons()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	private void DisableMainMenuButtonColliders()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[CallsUnknownMethods(Count = 14)]
	private void EnableMainMenuButtonColliders()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableMainMenuButtonColliders")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtonColliders")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void UpdateFading()
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

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	private void SetPanelAlpha(float alpha)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void SelectWindow(GameObject windowToSelect)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private bool ShouldDisableMainMenuButtons()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnBuyNow()
	{
	}

	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void WarmUpSmokeTrails()
	{
	}

	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	private ExperienceModeType GetSandboxExperienceForIndex(int index)
	{
		return default(ExperienceModeType);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallsUnknownMethods(Count = 6)]
	private int GetIndexFromSandboxExperience(ExperienceModeType mode)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeShowResetBindingsConfirmation()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "InitializeDefaultKeybindings")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	private void ResetBindings()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetVersionLabel()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeAdjustTreeBillboardDistance()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	private void LoadAllSlots()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeDoSteamSynchronization")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameData), Member = "AsyncOperationInProgress")]
	private bool ProfileIsLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	private void PlayIntroMovie()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void ConfigureMenu()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	public void Refresh()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool HasFadedIn()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public float GetAlpha()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private static void EnableCamera(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void MainMenuLoaded()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void MaybeUpdateNotificationsFromServer()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Notifications), Member = "GetWebNotificationUrl")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "WebRequest")]
	public void RetrieveNotificationsFromServer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 35)]
	public Panel_MainMenu()
	{
	}
}
