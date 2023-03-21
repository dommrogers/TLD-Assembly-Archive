using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Interface.PanelRequest;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Scenes;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class InterfaceManager : MonoBehaviour
{
	private sealed class _003CTakeMapScreenshot_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CTakeMapScreenshot_003Ed__92(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public GameObject m_TimeWidgetPrefab;

	public GameObject m_CommonGUIPrefab;

	public AssetLabelReference m_DebugPanelLabel;

	public SceneNameMapping m_SceneNameMappingAsset;

	private BlueprintManager m_BlueprintManager;

	private GameObject m_BasicMenuPrefab;

	private GameObject m_BasicMenuSwitchPrefab;

	public static GameObject s_BasicMenuPrefab;

	private PlatformSpecificScreens m_SwitchSpecificScreens;

	public float m_DisplayLabelCoolDownTimeSeconds;

	public float m_DisplayLabelTimeSeconds;

	public string m_DisplayLabelDefaultStingerAudio;

	public Color m_TabHighlightColor;

	public Color m_TabUnselectedColor;

	public GameplayTag m_DontUseSurvivalTabs;

	public float m_ContainerSearchSeconds;

	public float m_ContainerOpenSeconds;

	public float m_SceneTransitionSeconds;

	public float m_DoorInteractSeconds;

	public float m_PlotObjectInteractSeconds;

	public Color m_StatusMainSpriteRegularColor;

	public Color m_StatusMainSpriteBelowThresholdColor;

	public Color m_StatusOuterBoxRegularColor;

	public Color m_StatusOuterBoxBelowThresholdColor;

	public Color m_StatusOuterBoxEmptyColor;

	public Color m_ConditionMainSpriteRegularColor;

	public Color m_ConditionMainSpriteBelowThresholdColor;

	public Color m_ConditionOuterBoxRegularColor;

	public Color m_ConditionOuterBoxBelowThresholdColor;

	public Color m_ConditionOuterBoxEmptyColor;

	public float m_ConditionHeartTweenScale;

	public float m_ConditionHeartTweenDuration;

	public UITweener.Method m_ConditionHeartTweenMethod;

	public UIAtlas[] m_ScalableAtlases;

	public static Transform s_CommonUIAnchor;

	public static Color m_FirstAidRedColor;

	public static Color m_FirstAidRiskColor;

	public static Color m_FirstAidBuffColor;

	public static bool m_ImmediatelyExitOverlay;

	public static bool m_ShowCalories;

	public static bool m_ShowTemperature;

	private Panel_Crafting m_Panel_Crafting;

	public const string SD_ATLAS_LABEL = "SD";

	public const string HD_ATLAS_LABEL = "HD";

	private static GameObject m_TimeWidget;

	private static Panel_Confirmation.CallbackDelegate m_ConfirmRequest;

	private static bool s_IsOverlayActive;

	public static bool s_UseSdAtlases;

	private static HudDisplayMode m_SubtitleRestoreHudDisplayMode;

	private static List<GameObject> m_SubtitleHiddenPanels;

	private static int m_SubtitleUiCount;

	private static bool m_MainMenuPanelsLoaded;

	private static Type[] m_InstantiatedPanels;

	private static List<Type> m_MainMenuPanels;

	private static InterfaceManager m_Instance;

	public static bool s_DebugPanelLoading;

	private Dictionary<Type, Panel_Base> m_PanelCache;

	private List<ILoadPanelRequest> m_AsyncPanelRequests;

	[CallerCount(Count = 0)]
	public static InterfaceManager GetInstance()
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanelsWithComponent")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelLoaded")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	public static bool HasInstance()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateInterfaceSystem")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(EmptyScene), Member = "MaybeInstantiateLoadingScreen")]
	[Calls(Type = typeof(Addressables), Member = "InstantiateAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	public static void CreateInterfaceManager()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_atlas_sd")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Awake")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_atlas_sd")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void LoadReplacementAtlases(string label)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 2)]
	public void ResetReplacementAtlases()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateCommonGUI")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void SetupBasicMenuPrefab()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "UpdateAsyncLoadPanelRequests")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(TextureCache), Member = "HasTextureCache")]
	[Calls(Type = typeof(InterfaceManager), Member = "UpdateConfirmPanelRequest")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCache), Member = "ClearTextureCache")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	public static bool ShouldHidePopupBase()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallerCount(Count = 42)]
	public static bool IsOverlayActiveImmediate()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsOverlayActiveCached()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsPanelLoadingEnabledOrLoading()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static bool DetermineIfOverlayIsActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldHidePopupBase")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PopupBase), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(InterfaceManager), Member = "AnyOverlayPanelEnabled")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static bool DetermineIfOverlayIsActiveInternal(bool checkPopupBaseActive)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_close_ui")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ClearRequests")]
	[Calls(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[CallsDeduplicatedMethods(Count = 55)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	public static void QuitCurrentScreens()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldImmediatelyExitOverlayDuringStruggle()
	{
		return default(bool);
	}

	[CallerCount(Count = 47)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	public static bool ShouldImmediatelyExitOverlay()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	public static void CloseOverlaysDueToSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void ResetNotificationsDataIfNotNull(INotificationHandler handler)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool SetCameraViewPort(float x, float y, float w, float h)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 80)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public static GameObject GetSoundEmitter()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	public static void UpdateMousePointerState()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Map), Member = "EnableNavigationTabs")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "EnableNavigationTabs")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	public static bool IsUsingSurvivalTabs()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "ConfigureForMissionStart")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	public void SetTimeWidgetActive(bool active)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[Calls(Type = typeof(TimeWidget), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	public void InitializeAndActivateTimeWidget(Transform parent, Vector3 pos)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(TimeWidget), Member = "Update")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	public void InitializeAndActivateTimeWidget(Transform positionMarker)
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	private void ParentToCommonGUIAnchor(GameObject panel, Transform anchor)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private PlatformSpecificScreens GetSpecificScreensForCurrentPlatform()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 17)]
	private void InstantiateCommonGUI()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void InstantiateTimeWidget()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void InstantiateInterfaceObjectsForLoading()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanels")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateInterfaceSystem")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateTimeWidget")]
	public static void InstantiateInterfaceObjects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void CachePanelReferences()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void CacheInstancePanelReferences()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void MapScreenshot(int detailLevel = 4)
	{
	}

	[IteratorStateMachine(typeof(_003CTakeMapScreenshot_003Ed__92))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator TakeMapScreenshot(int detailLevel)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateMousePointerState")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static bool ShouldEnableMousePointer()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableSpecialEvent")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CalledBy(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[CalledBy(Type = typeof(Frostbite), Member = "Update")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	public static bool IsMainMenuEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsBrightnessCalibrationActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(LoadingScreenInfo), Member = "GetLocalizedSceneName")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	public static string GetNameForScene(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	public static string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	public static string GetLocIDForScene(string sceneName, bool warnIfNotAvailable)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionSpriteName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetLargeRegionBackgroundName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	public static string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestConfirmationPanel(Panel_Confirmation.CallbackDelegate onConfirm)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(PopupDefinition), Member = "Show")]
	[CallsUnknownMethods(Count = 5)]
	public static GameObject InstantiatePopup(UIPanel panelPrefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateConfirmPanelRequest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideNotifications")]
	[Calls(Type = typeof(BlueprintManager), Member = "ClearUnlockedBlueprints")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "LoadMissionDataFromResources")]
	public static void ClearUISaveData()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "EnterPlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	public static void HidePanelsForSubtitle()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	public static void RestorePanelsAfterSubtitle()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	private static void LoadMainMenuPanels()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[CallsUnknownMethods(Count = 2)]
	public static ILoadPanelRequest LoadMainMenuPanelsAsync()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallsUnknownMethods(Count = 5)]
	public static void UnloadMainMenuPanels()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsPanelLoaded<T>() where T : Panel_Base
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetPanelsWithComponent<T>(IList<T> list)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPanelLoaded_Internal(Type panelType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 94)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	public static bool IsPanelEnabled<T>() where T : Panel_Base
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPanelEnabled(Type panelType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool IsPanelEnabled_Internal(Type panelType)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallsUnknownMethods(Count = 8)]
	public bool AnyOverlayPanelEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 75)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TrySetPanelEnabled<T>(bool enable) where T : Panel_Base
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	public static bool TrySetPanelEnabled(Type panelType, bool enable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool TrySetPanelEnabled_Internal(Type panelType, bool enable)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 205)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsUnknownMethods(Count = 10)]
	public static bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel_Internal")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	private bool TryGetPanel_Internal(Type panelType, out Panel_Base panel)
	{
		panel = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel_Internal")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	public static T GetPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsUnknownMethods(Count = 1)]
	private Panel_Base GetPanel_Internal(Type panelType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CallsUnknownMethods(Count = 7)]
	public static T LoadPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanels")]
	[CallAnalysisFailed]
	public static Panel_Base LoadPanel(Type panelType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[Calls(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CallsUnknownMethods(Count = 1)]
	private Panel_Base LoadPanel_Internal(Type panelType)
	{
		return null;
	}

	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	public static AsyncLoadPanelRequest LoadPanelAsync<T>(Action<Panel_Base> panelLoadedCallback = null) where T : Panel_Base
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static AsyncLoadPanelRequest LoadPanelAsync(Type panelType, Action<Panel_Base> panelLoadedCallback = null)
	{
		return null;
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync")]
	[Calls(Type = typeof(AsyncLoadPanelRequest), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPendingAsyncPanelRequest")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	private AsyncLoadPanelRequest LoadPanelAsync_Internal(Type panelType, Action<Panel_Base> panelLoadedCallback = null)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static BatchAsyncLoadPanelRequest GetBatchAsyncPanels(List<Type> panelTypes, Action<bool> panelLoadedCallback = null)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[CallsUnknownMethods(Count = 5)]
	private BatchAsyncLoadPanelRequest GetBatchAsyncPanels_Internal(List<Type> panelTypes, Action<bool> panelLoadedCallback = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private AsyncLoadPanelRequest GetPendingAsyncPanelRequest(string panelName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel_Internal")]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryDestroyPanel<T>() where T : Panel_Base
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	public static bool TryDestroyPanel(Type panelType)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsUnknownMethods(Count = 3)]
	private bool TryDestroyPanel_Internal(Type panelType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	private string GetPanelName(Type panelType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	private string GetPanelVariantName(Type panelType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateAsyncLoadPanelRequests()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateAsyncLoadPanelRequests")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "GetPanel")]
	private void FinishLoadPanelRequest(ILoadPanelRequest panelRequest)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public InterfaceManager()
	{
	}
}
