using System;
using System.Collections.Generic;
using System.Diagnostics;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using TLD.IO;
using TLD.News;
using TLD.OptionalContent;
using TLD.SaveState;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass93_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
		[Calls(Type = typeof(Utils), Member = "OpenURL")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CInitialize_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass190_0
	{
		public UITexture targetTexture;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass190_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CLoadFeatureIcon_003Eb__0(AsyncOperationHandle<Texture2D> texOp)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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

	private readonly List<BadgeInfo> m_Feats;

	private readonly List<string> m_SelectedFeats;

	private string m_ActionButtonLocID;

	private bool m_ActionButtonEnabled;

	private readonly Dictionary<object, AsyncOperationHandle<Texture2D>> m_SpriteAssets;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(BasicMenu), Member = "InstantiateMenu")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
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

	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickAllChallenges")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickFeats")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickBack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	public void OnMainMenuTop()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShouldDisableMainMenuButtons")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	public bool IsSubMenuEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SaveGameData), Member = "GetNumPendingOperations")]
	[Calls(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[Calls(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableCamera")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "PlayMainMenuMusic")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	[Calls(Type = typeof(SaveGameSystem), Member = "get_IsInitializingUser")]
	[Calls(Type = typeof(InputManager), Member = "AnyInput")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(WeatherTransition), Member = "ActivateWeatherSetAtFrac")]
	[Calls(Type = typeof(Wind), Member = "StartPhaseImmediate")]
	[Calls(Type = typeof(StartSettings), Member = "SetWeather")]
	[Calls(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[Calls(Type = typeof(StartSettings), Member = "SetTime")]
	[Calls(Type = typeof(Weather), Member = "WarmWeather")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[Calls(Type = typeof(GameManager), Member = "IsTrialMode")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuBuyNowPressed")]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetCommunicationButtonsFocus")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateCommunicationButtons")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[Calls(Type = typeof(GameManager), Member = "TrialModeTimeRemaining")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[Calls(Type = typeof(SaveGameData), Member = "IsAnyOperationPending")]
	[Calls(Type = typeof(Utils), Member = "SendQualitySettingsAnalyticsEvent")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "OnTabCommon")]
	[Calls(Type = typeof(HDRManager), Member = "IsOutputtingHDR")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ToggleGameCameraForBrightness")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 16)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ProfileIsLoading")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeDoSteamSynchronization()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicMenu), Member = "ManualUpdate")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMainWindow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetGameEditionArt")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "MaybeAdjustTreeBillboardDistance")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(NPC), Member = "ClearActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetMainMenuConfig")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ReleaseSpriteAssets")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SlotsAreLoading")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetLoadingPriority")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSandbox()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(OptionalContentManager), Member = "OpenContentInStore")]
	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(Utils), Member = "GenerateCommandLineArgs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void OnStory()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 2)]
	private void LaunchStory(string arguments)
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

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickResume")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseChallenge), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnLoadSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseSandbox), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickResume")]
	[CallerCount(Count = 6)]
	public void OnLoadSaveSlot(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "PrepareSaveSlotForLoad")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void OnLoadGame(SaveSlotType saveSlotType, int slotIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "OnClickJournals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateLogObject")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "OnTocItemClicked")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnLogs()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	public void OnDebugPanel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "StopMainMenuMusic")]
	public void OnQuit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameManager), Member = "RegionLockedBySelectedMode")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[CallsUnknownMethods(Count = 2)]
	public void OnSelectSurvivorBack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSelectSurvivorContinue()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private string NameSandboxGame(SaveSlotType saveSlotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(TextInputField), Member = "Select")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void ShowNameSaveSlotPopup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 3)]
	private void OnRenameNewSandboxComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumUnlockedFeats")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PanelReference<>), Member = "TrySetEnabled")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CallsUnknownMethods(Count = 3)]
	private void OnRenameNewSandboxCancel(bool wasCancelled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 3)]
	public void OnSelectSlotNameContinue()
	{
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void PlayMainMenuMusic()
	{
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnQuit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayMusic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void StopMainMenuMusic()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSandbox")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLogs")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnDebugPanel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DisableMainMenuButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableMainMenuButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void DisableMainMenuButtonColliders()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void EnableMainMenuButtonColliders()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetPanelAlpha")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "EnableMainMenuButtonColliders")]
	[CallsDeduplicatedMethods(Count = 8)]
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

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFading")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void SetPanelAlpha(float alpha)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnMainMenuTop")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsBack")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(BasicMenu), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SelectWindow(GameObject windowToSelect)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "IsSubMenuEnabled")]
	private bool ShouldDisableMainMenuButtons()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "OnBuyNow")]
	public void OnBuyNow()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(SmokeTrail), Member = "FixedUpdateInternal")]
	[CallsUnknownMethods(Count = 2)]
	private void WarmUpSmokeTrails()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeShowResetBindingsConfirmation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "ResetKeybindingsToDefault")]
	[Calls(Type = typeof(InputManager), Member = "UpdateKeyBindingTable")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "DisableMainMenuButtons")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetPanelToReturnToOnExit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetTabActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeAdjustTreeBillboardDistance()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadAllSavedGameFiles")]
	private void LoadAllSlots()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeDoSteamSynchronization")]
	[CallerCount(Count = 4)]
	private bool ProfileIsLoading()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlatformPath), Member = "MaybeCachePath")]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PlayIntroMovie()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BasicMenu), Member = "AddItem")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddMenuItem(int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BasicMenu), Member = "Reset")]
	[Calls(Type = typeof(BasicMenu), Member = "UpdateTitle")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "IsContentOwned")]
	[Calls(Type = typeof(PlatformPath), Member = "IsValid")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "AddMenuItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ConfigureMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void SetGameEditionArt()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SetLanguage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ConfigureMenu")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetGameEditionArt")]
	[Calls(Type = typeof(BasicMenu), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	public bool HasFadedIn()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public float GetAlpha()
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void EnableCamera(bool isEnabled)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void MainMenuLoaded()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(BasicMenu), Member = "SetFocused")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void SetCommunicationButtonsFocus(bool communicationFocused)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshGamepadButtons()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	protected void UpdateSelectFeatWindow()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatLabels")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(ProfileState), Member = "AddUnlockedBadgeViewed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectFeatVisuals()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatProgressBar")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallsUnknownMethods(Count = 1)]
	protected void FeatSelectWindowSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CallsUnknownMethods(Count = 5)]
	public void OnSelectFeatsContinue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	public void OnSelectFeatsBack()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnToggleFeatActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void FeatSelectionNext()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "CleanupFeatScrollList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetNumFeats")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "LoadFeatureIcon")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SetupFeatScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupFeatScrollList()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Feat), Member = "CreateBadgeInfo")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[CallsUnknownMethods(Count = 2)]
	private void AddFeatToList(Feat f)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "LoadFeatureIcon")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateSelectedFeats()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private void LoadFeatureIcon(UITexture targetTexture, AssetReferenceTexture2D spriteReference)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CleanupSelectedFeats()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void ReleaseSpriteAssets()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFeatProgressBar()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "FeatSelectWindowSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MainMenu), Member = "GetNumFeatsForXPMode")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateFeatActionButton()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateFeatMarkerSprites()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryDropPressed")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "SelectWindow")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Panel_MainMenu), Member = "OnSelectFeatsContinue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateFeatControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateFeatButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectFeatVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateFeatLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallerCount(Count = 3)]
	public int GetNumFeatsForXPMode()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxCancel")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnSelectSurvivor")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FeatsManager), Member = "GetFeatFromIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetNumUnlockedFeats()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_MainMenu()
	{
	}
}
