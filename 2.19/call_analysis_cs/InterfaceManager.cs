using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Interface.PanelRequest;
using NodeCanvas.Tasks.Actions;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Missions;
using TLD.SaveState;
using TLD.Scenes;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class InterfaceManager : MonoBehaviour
{
	private sealed class _003CTakeMapScreenshot_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CTakeMapScreenshot_003Ed__95(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	public GameplayTag m_TalesAvailable;

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

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	private static InterfaceManager m_Instance;

	public static bool s_DebugPanelLoading;

	private Dictionary<Type, Panel_Base> m_PanelCache;

	private List<ILoadPanelRequest> m_AsyncPanelRequests;

	[CallerCount(Count = 0)]
	public static InterfaceManager GetInstance()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelLoaded")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanelsWithComponent")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CallerCount(Count = 17)]
	public static bool HasInstance()
	{
		return false;
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(EmptyScene), Member = "MaybeInstantiateLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateInterfaceSystem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Addressables), Member = "InstantiateAsync")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "WaitForCompletion")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	public static void CreateInterfaceManager()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_atlas_sd")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateCommonGUI")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void SetupBasicMenuPrefab()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(InterfaceManager), Member = "UpdateConfirmPanelRequest")]
	[Calls(Type = typeof(TextureCache), Member = "HasTextureCache")]
	[Calls(Type = typeof(TextureCache), Member = "ClearTextureCache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "UpdateAsyncLoadPanelRequests")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	public static bool ShouldHidePopupBase()
	{
		return false;
	}

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	public static bool IsOverlayActiveImmediate()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsOverlayActiveCached()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsPanelLoadingEnabledOrLoading()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static bool DetermineIfOverlayIsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(PopupBase), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldHidePopupBase")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "AnyOverlayPanelEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static bool DetermineIfOverlayIsActiveInternal(bool checkPopupBaseActive)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_close_ui")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	[Calls(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ClearRequests")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void QuitCurrentScreens()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ShouldImmediatelyExitOverlayDuringStruggle()
	{
		return false;
	}

	[CallerCount(Count = 49)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CallsUnknownMethods(Count = 2)]
	public static bool ShouldImmediatelyExitOverlay()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(Panel_CookWater), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
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
		return false;
	}

	[CallerCount(Count = 82)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 3)]
	public static GameObject GetSoundEmitter()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	public static void UpdateMousePointerState()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameplayTag), Member = "MatchesAnyExact")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsUsingSurvivalTabs()
	{
		return false;
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "ConfigureForMissionStart")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	public void SetTimeWidgetActive(bool active)
	{
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TimeWidget), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void InitializeAndActivateTimeWidget(Transform parent, Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TimeWidget), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void InitializeAndActivateTimeWidget(Transform positionMarker)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 14)]
	private void ParentToCommonGUIAnchor(GameObject panel, Transform anchor)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[CallsUnknownMethods(Count = 1)]
	private bool AreTalesAvailable()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private PlatformSpecificScreens GetSpecificScreensForCurrentPlatform()
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	private void InstantiateCommonGUI()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InstantiateTimeWidget()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	public static void InstantiateInterfaceObjectsForLoading()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateInterfaceSystem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateTimeWidget")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanels")]
	[CallsUnknownMethods(Count = 2)]
	public static void InstantiateInterfaceObjects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallsUnknownMethods(Count = 1)]
	private static void CachePanelReferences()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	private void CacheInstancePanelReferences()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void MapScreenshot(int detailLevel = 4)
	{
	}

	[IteratorStateMachine(typeof(_003CTakeMapScreenshot_003Ed__95))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator TakeMapScreenshot(int detailLevel)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateMousePointerState")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	private static bool ShouldEnableMousePointer()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "FixedUpdateInternal")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "MaybePlayTimeOfDayStingers")]
	[CalledBy(Type = typeof(GearItem), Member = "DecayOverTODHours")]
	[CalledBy(Type = typeof(Frostbite), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DisableSpecialEvent")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCollectibleList")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(HUDManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Update")]
	[CalledBy(Type = typeof(Breath), Member = "ShouldSuppressBreathEffect")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	public static bool IsMainMenuEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsBrightnessCalibrationActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
	[CalledBy(Type = typeof(LoadingScreenInfo), Member = "GetLocalizedSceneName")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetNameForScene(string sceneName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CallerCount(Count = 3)]
	public static string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetLocIDForScene(string sceneName, bool warnIfNotAvailable)
	{
		return null;
	}

	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetLargeRegionBackgroundName")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "GetRegionSpriteName")]
	[CalledBy(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[CalledBy(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	public static void RequestConfirmationPanel(Panel_Confirmation.CallbackDelegate onConfirm)
	{
	}

	[CalledBy(Type = typeof(PopupDefinition), Member = "Show")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static GameObject InstantiatePopup(UIPanel panelPrefab)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateConfirmPanelRequest()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "LoadMissionDataFromResources")]
	[Calls(Type = typeof(BlueprintManager), Member = "ClearUnlockedBlueprints")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideNotifications")]
	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearUISaveData()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "Update")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "EnterPlaying")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public static void HidePanelsForSubtitle()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void RestorePanelsAfterSubtitle()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CallsUnknownMethods(Count = 2)]
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
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void UnloadMainMenuPanels()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPanelLoaded<T>() where T : Panel_Base
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void GetPanelsWithComponent<T>(IList<T> list)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPanelLoaded_Internal(Type panelType)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 93)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPanelEnabled<T>() where T : Panel_Base
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPanelEnabled(Type panelType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPanelEnabled_Internal(Type panelType)
	{
		return false;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public bool AnyOverlayPanelEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 80)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool TrySetPanelEnabled<T>(bool enable) where T : Panel_Base
	{
		return false;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool TrySetPanelEnabled(Type panelType, bool enable)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool TrySetPanelEnabled_Internal(Type panelType, bool enable)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 184)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsUnknownMethods(Count = 10)]
	public static bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return false;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel_Internal")]
	private bool TryGetPanel_Internal(Type panelType, out Panel_Base panel)
	{
		panel = null;
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel_Internal")]
	[CallsUnknownMethods(Count = 7)]
	public static T GetPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	private Panel_Base GetPanel_Internal(Type panelType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(EmptyScene), Member = "MaybeInstantiateLoadingScreen")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjectsForLoading")]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "WinChallenge")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "DraggingAnimationEnd")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WinHunted2Challenge")]
	[CalledBy(Type = typeof(Action_ShowChallengeComplete), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "PlayCredits")]
	[CalledBy(Type = typeof(Action_ShowCredits), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CallsUnknownMethods(Count = 7)]
	public static T LoadPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanels")]
	[CallerCount(Count = 1)]
	public static Panel_Base LoadPanel(Type panelType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[Calls(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[CallsUnknownMethods(Count = 1)]
	private Panel_Base LoadPanel_Internal(Type panelType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallsUnknownMethods(Count = 2)]
	public static AsyncLoadPanelRequest LoadPanelAsync<T>(Action<Panel_Base> panelLoadedCallback = null) where T : Panel_Base
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static AsyncLoadPanelRequest LoadPanelAsync(Type panelType, Action<Panel_Base> panelLoadedCallback = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPendingAsyncPanelRequest")]
	[Calls(Type = typeof(AsyncLoadPanelRequest), Member = ".ctor")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 5)]
	private BatchAsyncLoadPanelRequest GetBatchAsyncPanels_Internal(List<Type> panelTypes, Action<bool> panelLoadedCallback = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private AsyncLoadPanelRequest GetPendingAsyncPanelRequest(string panelName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(DebugPanel_FontRendering), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "DisablePanel")]
	[CalledBy(Type = typeof(Panel_Credits), Member = "Exit")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel_Internal")]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryDestroyPanel<T>() where T : Panel_Base
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CallerCount(Count = 1)]
	public static bool TryDestroyPanel(Type panelType)
	{
		return false;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool TryDestroyPanel_Internal(Type panelType)
	{
		return false;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	private string GetPanelName(Type panelType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	private string GetPanelVariantName(Type panelType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateAsyncLoadPanelRequests()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateAsyncLoadPanelRequests")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "GetPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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
