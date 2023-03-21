using System;
using System.Collections.Generic;
using System.Diagnostics;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using TLD.IO;
using TLD.News;
using TLD.OptionalContent;
using TLD.SaveState;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Panel_MainMenu : Panel_AutoReferenced
{
	[Serializable]
	public class MainMenuItem
	{
		public enum MainMenuItemType
		{
			Sandbox,
			Story,
			TFTFTUpsell,
			Quit,
			Debug
		}

		public MainMenuItemType m_Type;

		public string m_LabelLocalizationId;

		public bool m_UseOverrideTint;

		public Color m_OverrideTintNormal;

		public Color m_OverrideTintHighlight;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public MainMenuItem()
		{
		}
	}

	[Serializable]
	private class CommunicationButton
	{
		public UIButton m_Button;

		public string m_URL;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public CommunicationButton()
		{
		}
	}

	[Serializable]
	private class GameEditionArt
	{
		public GameObject m_Title;

		public GameObject m_Background;

		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public void SetActive(bool value)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public GameEditionArt()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public CommunicationButton communicationButton;

		public Panel_MainMenu _003C_003E4__this;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass93_0()
		{
		}

		[Calls(Type = typeof(Utils), Member = "OpenURL")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
		internal void _003CInitialize_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public UITexture targetTexture;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass189_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CLoadFeatureIcon_003Eb__0(AsyncOperationHandle<Texture2D> texOp)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CLoadFeatureIcon_003Eb__1(AsyncOperationHandle<Texture2D> texOp)
		{
		}
	}

	private PanelReference<Panel_Badges> m_Badges;

	private PanelReference<Panel_Challenges> m_Challenges;

	private PanelReference<Panel_ChooseChallenge> m_ChooseChallenge;

	private PanelReference<Panel_ChooseSandbox> m_ChooseSandbox;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Credits> m_Credits;

	private PanelReference<Panel_CustomXPSetup> m_CustomXPSetup;

	private PanelReference<Panel_Debug> m_Debug;

	private PanelReference<Panel_Extras> m_Extras;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	private PanelReference<Panel_Sandbox> m_Sandbox;

	private PanelReference<Panel_SelectChallengeType> m_SelectChallengeType;

	private PanelReference<Panel_SelectExperience> m_SelectExperience;

	private PanelReference<Panel_SelectRegion_Map> m_SelectRegion_Map;

	private PanelReference<Panel_SelectSurvivor> m_SelectSurvivor;

	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	private PanelReference<Panel_SelectWorldMap> m_SelectWorld;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UIPanel m_MainPanel;

	public AK.Wwise.Event m_StartMusic;

	public AK.Wwise.Event m_StopMusic;

	public UILabel m_VersionLabel;

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

	private GameplayTag m_UseSpecialHalloweenTOD;

	public static bool m_IsRestarting;

	private StartSettings m_StartSettings;

	private uint m_MusicPlayingID;

	private bool m_Quit;

	private bool m_StartSettingsApplied;

	private float m_PanelAlpha;

	private float m_PanelAlphaTarget;

	private float m_TimeNoInput;

	private float m_ScreenElapsedTime;

	public PlatformPath m_StoryModeApplicationPath;

	public PlatformPath m_StoryModeApplicationArguments;

	public PlatformPath m_IntroMovieFilename;

	public string m_TitleLocalizationId;

	public GameObject m_BasicMenuRoot;

	public List<MainMenuItem> m_MenuItems;

	public UILabel m_CloudMessageLabel;

	private List<CommunicationButton> m_CommunicationButtons;

	private GameObject m_CommunicationSelect;

	private GameObject m_CommunicationDeselect;

	private NewsCarousel m_NewsCarousel;

	private GameEditionArt m_BaseEditionArt;

	private GameEditionArt m_WintermuteEditionArt;

	private GameEditionArt m_ExpansionPassEditionArt;

	private OptionalContentConfig m_ExpansionPassConfig;

	private OptionalContentConfig m_WintermuteConfig;

	private const bool BYPASS_WM_OWNERSHIP_CHECK = false;

	private BasicMenu m_BasicMenu;

	private int m_CommunicationButtonSelectedIndex;

	private float m_WaitingForProfileToLoadTimer;

	private int m_HoldMovieForD3D9Frames;

	private bool m_PlayedIntroMovie;

	private bool m_DoneFourDaysOfNightDeleteCheck;

	private static bool m_SavedGamesLoaded;

	private static float m_AdjustedFadeInDuration;

	private static bool m_HasMainMenuFadedIn;

	private bool m_SyncSaveStarted;

	private bool m_SentAnalytics;

	private string m_VersionLabelString;

	private List<BoxCollider> m_ButtonColliders;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private BadgeUISettings m_BadgeUISettings;

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

	public GameObject[] m_ActiveFeatObjects;

	public float m_ActiveFeatCenteredX;

	public float m_ActiveFeatSpacing;

	public UILabel m_FeatBenefitHeaderLabel;

	public UILabel m_FeatBenefitDescriptionLabel;

	private List<BadgeInfo> m_Feats;

	private List<string> m_SelectedFeats;

	private string m_ActionButtonLocID;

	private bool m_ActionButtonEnabled;

	private Dictionary<string, AsyncOperationHandle<Texture2D>> m_SpriteAssets;

	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Action GetActionFromType(MainMenuItem.MainMenuItemType type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public void ResetSlotsRequests()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickBack")]
	public void OnMainMenuTop()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShouldDisableMainMenuButtons")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 15)]
	public bool IsSubMenuEnabled()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "TrialModeTimeRemaining")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateCommunicationButtons")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[Calls(Type = typeof(Utils), Member = "SendQualitySettingsAnalyticsEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableCamera")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[Calls(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuBuyNowPressed")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(SaveGameSystem), Member = "get_IsInitializingUser")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(InputManager), Member = "AnyInput")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDoSteamSynchronization()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	private void UpdateMainWindow()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ReleaseSpriteAssets")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetGameEditionArt")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeAdjustTreeBillboardDistance")]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	public void OnSandbox()
	{
	}

	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GenerateCommandLineArgs")]
	[CallsUnknownMethods(Count = 5)]
	public void OnStory()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	public void OnTFTFTUpsell()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickResume")]
	public void OnLoadSaveSlot(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(SaveGameSlots), Member = "PrepareSaveSlotForLoad")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	public void OnLoadGame(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickJournals")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateLogObject")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnLogs()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	public void OnDebugPanel()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnQuit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSelectSurvivorBack()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	public void OnSelectSurvivorContinue()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	private string NameSandboxGame(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CallsUnknownMethods(Count = 2)]
	private void ShowNameSaveSlotPopup()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallerCount(Count = 0)]
	private void OnRenameNewSandboxComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 3)]
	private void OnRenameNewSandboxCancel(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnSelectSlotNameContinue()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnCreditsEnd")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	public void PlayMainMenuMusic()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnQuit")]
	[CallsUnknownMethods(Count = 2)]
	public void StopMainMenuMusic()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnDebugPanel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	private void DisableMainMenuButtons()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void EnableMainMenuButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableMainMenuButtonColliders()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[CallsUnknownMethods(Count = 4)]
	private void EnableMainMenuButtonColliders()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableMainMenuButtonColliders")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
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
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	private void SetPanelAlpha(float alpha)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsBack")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	private void SelectWindow(GameObject windowToSelect)
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldDisableMainMenuButtons()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	public void OnBuyNow()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 2)]
	private void WarmUpSmokeTrails()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	private void MaybeShowResetBindingsConfirmation()
	{
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ResetBindings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void SetVersionLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeAdjustTreeBillboardDistance()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	private void LoadAllSlots()
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeDoSteamSynchronization")]
	private bool ProfileIsLoading()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlayIntroMovie()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	private void SetGameEditionArt()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetGameEditionArt")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CallsUnknownMethods(Count = 1)]
	public void Refresh()
	{
	}

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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableCamera(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void MainMenuLoaded()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BasicMenu), Member = "SetFocused")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	private void SetCommunicationButtonsFocus(bool communicationFocused)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	private void UpdateCommunicationButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClickCommunicationButton(CommunicationButton button)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	private void RefreshGamepadButtons()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void UpdateSelectFeatWindow()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadgeViewed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatLabels")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateSelectFeatVisuals()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	protected void FeatSelectWindowSelected()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	public void OnSelectFeatsContinue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnSelectFeatsBack()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnToggleFeatActive()
	{
	}

	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void FeatSelectionNext()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 2)]
	public void FeatSelectionPrev()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void FeatSelectionIndexSelected(int index)
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "LoadFeatureIcon")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupFeatScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	private void SetupFeatScrollList()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void CleanupFeatScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[CallsUnknownMethods(Count = 3)]
	private void AddFeatToList(Feat f)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "LoadFeatureIcon")]
	private void UpdateSelectedFeats()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CallsUnknownMethods(Count = 7)]
	private void LoadFeatureIcon(UITexture targetTexture, string spriteName)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupSelectedFeats()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void ReleaseSpriteAssets()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFeatProgressBar()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateFeatActionButton()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	private void UpdateFeatMarkerSprites()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	private void UpdateFeatControls()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateFeatButtonLegend()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateFeatLabels()
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	public int GetNumFeatsForXPMode()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	private int GetNumUnlockedFeats()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_MainMenu()
	{
	}
}
