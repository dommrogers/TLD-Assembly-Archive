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

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public CommunicationButton communicationButton;

		public Panel_MainMenu _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass91_0()
		{
		}

		[Calls(Type = typeof(Panel_MainMenu), Member = "OnClickCommunicationButton")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal void _003CInitialize_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UITexture targetTexture;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass187_0()
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

	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[CallsUnknownMethods(Count = 21)]
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

	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
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

	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "TrialModeTimeRemaining")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateCommunicationButtons")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(Utils), Member = "SendQualitySettingsAnalyticsEvent")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuBuyNowPressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableCamera")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[Calls(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "get_IsInitializingUser")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(Weather), Member = "WarmBlowingSnow")]
	[Calls(Type = typeof(Weather), Member = "UpdateFallingSnowPreset")]
	[Calls(Type = typeof(Weather), Member = "WarmWeatherState")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[Calls(Type = typeof(InputManager), Member = "AnyInput")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	private void Update()
	{
	}

	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	private void MaybeDoSteamSynchronization()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMainWindow()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ReleaseSpriteAssets")]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeAdjustTreeBillboardDistance")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetGameEditionArt")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	public void OnSandbox()
	{
	}

	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	public void OnStory()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[CallsUnknownMethods(Count = 1)]
	public void OnTFTFTUpsell()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickResume")]
	[CallerCount(Count = 6)]
	[CallAnalysisFailed]
	public void OnLoadSaveSlot(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "PrepareSaveSlotForLoad")]
	public void OnLoadGame(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickJournals")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateLogObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	public void OnLogs()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnDebugPanel()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	public void OnSelectSurvivorContinue()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	private string NameSandboxGame(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	private void ShowNameSaveSlotPopup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 3)]
	private void OnRenameNewSandboxComplete()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnRenameNewSandboxCancel(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	public void OnSelectSlotNameContinue()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public void PlayMainMenuMusic()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnQuit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	public void StopMainMenuMusic()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnDebugPanel")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	private void DisableMainMenuButtons()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnableMainMenuButtons()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void DisableMainMenuButtonColliders()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private void EnableMainMenuButtonColliders()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableMainMenuButtonColliders")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
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
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	private void SetPanelAlpha(float alpha)
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsBack")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
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

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	private void MaybeShowResetBindingsConfirmation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	private void ResetBindings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	private void SetVersionLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void PlayIntroMovie()
	{
	}

	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetActionFromType")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	private void SetGameEditionArt()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetGameEditionArt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void EnableCamera(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void MainMenuLoaded()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BasicMenu), Member = "SetFocused")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	private void SetCommunicationButtonsFocus(bool communicationFocused)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallAnalysisFailed]
	private void UpdateCommunicationButtons()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "OpenURL")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass91_0), Member = "<Initialize>b__0")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClickCommunicationButton(CommunicationButton button)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	private void RefreshGamepadButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	protected void UpdateSelectFeatWindow()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadgeViewed")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatLabels")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void UpdateSelectFeatVisuals()
	{
	}

	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	protected void FeatSelectWindowSelected()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	public void OnToggleFeatActive()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsUnknownMethods(Count = 2)]
	public void FeatSelectionNext()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void FeatSelectionPrev()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
	public void FeatSelectionIndexSelected(int index)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "LoadFeatureIcon")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupFeatScrollList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void SetupFeatScrollList()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	private void CleanupFeatScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[CallsUnknownMethods(Count = 3)]
	private void AddFeatToList(Feat f)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "LoadFeatureIcon")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void UpdateSelectedFeats()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CallsUnknownMethods(Count = 22)]
	private void LoadFeatureIcon(UITexture targetTexture, string spriteName)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupSelectedFeats()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void ReleaseSpriteAssets()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFeatProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private void UpdateFeatActionButton()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	private void UpdateFeatMarkerSprites()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateFeatLabels()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumFeatsForXPMode()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private int GetNumUnlockedFeats()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 21)]
	public Panel_MainMenu()
	{
	}
}
