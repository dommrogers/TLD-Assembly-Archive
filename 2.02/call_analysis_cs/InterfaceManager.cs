using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Interface.PanelRequest;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
	private sealed class _003CTakeMapScreenshot_003Ed__175 : IDisposable, IEnumerator<object>, IEnumerator
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
		public _003CTakeMapScreenshot_003Ed__175(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static bool s_DebugPanelLoading;

	private Dictionary<Type, Panel_Base> m_PanelCache;

	private List<ILoadPanelRequest> m_AsyncPanelRequests;

	public GameObject m_TimeWidgetPrefab;

	public GameObject m_CommonGUIPrefab;

	public SceneNameMapping m_SceneNameMappingAsset;

	private GameObject m_BasicMenuPrefab;

	private GameObject m_BasicMenuSwitchPrefab;

	public static GameObject s_BasicMenuPrefab;

	private PlatformSpecificScreens m_SwitchSpecificScreens;

	public float m_DisplayLabelCoolDownTimeSeconds;

	public float m_DisplayLabelTimeSeconds;

	public string m_DisplayLabelDefaultStingerAudio;

	public Color m_TabHighlightColor;

	public Color m_TabUnselectedColor;

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

	public static Panel_Actions m_Panel_Actions;

	public static Panel_ActionPicker m_Panel_ActionPicker;

	public static Panel_ActionsRadial m_Panel_ActionsRadial;

	public static Panel_Affliction m_Panel_Affliction;

	public static Panel_Badges m_Panel_Badges;

	public static Panel_BedRollSelect m_Panel_BedRollSelect;

	public static Panel_BodyHarvest m_Panel_BodyHarvest;

	public static Panel_BreakDown m_Panel_BreakDown;

	public static Panel_CanOpening m_Panel_CanOpening;

	public static Panel_ChooseStory m_Panel_ChooseStory;

	public static Panel_Clothing m_Panel_Clothing;

	public static Panel_Confirmation m_Panel_Confirmation;

	public static Panel_Container m_Panel_Container;

	public static Panel_Cooking m_Panel_Cooking;

	public static Panel_Crafting m_Panel_Crafting;

	public static Panel_Diagnosis m_Panel_Diagnosis;

	public static Panel_EpisodeContinue m_Panel_EpisodeContinue;

	public static Panel_Debug m_Panel_Debug;

	public static Panel_FeedFire m_Panel_FeedFire;

	public static Panel_FireStart m_Panel_FireStart;

	public static Panel_FirstAid m_Panel_FirstAid;

	public static Panel_GearSelect m_Panel_GearSelect;

	public static Panel_GenericProgressBar m_Panel_GenericProgressBar;

	public static Panel_Harvest m_Panel_Harvest;

	public static Panel_Help m_Panel_Help;

	public static Panel_HUD m_Panel_HUD;

	public static Panel_IceFishing m_Panel_IceFishing;

	public static Panel_IceFishingHoleClear m_Panel_IceFishingHoleClear;

	public static Panel_Inventory m_Panel_Inventory;

	public static Panel_Inventory_Examine m_Panel_Inventory_Examine;

	public static Panel_Knowledge m_Panel_Knowledge;

	public static Panel_Loading m_Panel_Loading;

	public static Panel_Log m_Panel_Log;

	public static Panel_Map m_Panel_Map;

	public static Panel_MarkerList m_Panel_MarkerList;

	public static Panel_Milling m_Panel_Milling;

	public static Panel_MissionsStory m_Panel_MissionsStory;

	public static Panel_Notifications m_Panel_Notifications;

	public static Panel_OptionsMenu m_Panel_OptionsMenu;

	public static Panel_PauseMenu m_Panel_PauseMenu;

	public static Panel_PickUnits m_Panel_PickUnits;

	public static Panel_PickWater m_Panel_PickWater;

	public static Panel_Repair m_Panel_Repair;

	public static Panel_Rest m_Panel_Rest;

	public static Panel_SafeCracking m_Panel_SafeCracking;

	public static Panel_SaveIcon m_Panel_SaveIcon;

	public static Panel_SaveStory m_Panel_SaveStory;

	public static Panel_SnowShelterBuild m_Panel_SnowShelterBuild;

	public static Panel_SnowShelterInteract m_Panel_SnowShelterInteract;

	public static Panel_SprayPaint m_Panel_SprayPaint;

	public static Panel_LeanToBuild m_Panel_LeanToBuild;

	public static Panel_LeanToInteract m_Panel_LeanToInteract;

	public static Panel_TorchLight m_Panel_TorchLight;

	public static Panel_TutorialPopup m_Panel_TutorialPopup;

	public static Panel_WeaponPicker m_Panel_WeaponPicker;

	public static Panel_WorldMap m_Panel_WorldMap;

	public static Panel_Subtitles m_Panel_Subtitles;

	public const string SD_ATLAS_SUFFIX = "_sd";

	public const string HD_ATLAS_SUFFIX = "_hd";

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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPanelLoaded<T>() where T : Panel_Base
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPanelLoaded_Internal(Type panelType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool IsPanelEnabled<T>() where T : Panel_Base
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsPanelEnabled(Type panelType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsPanelEnabled_Internal(Type panelType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public bool AnyOverlayPanelEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 67)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsUnknownMethods(Count = 3)]
	public static bool TrySetPanelEnabled<T>(bool enable) where T : Panel_Base
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static bool TrySetPanelEnabled(Type panelType, bool enable)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CallsUnknownMethods(Count = 1)]
	private bool TrySetPanelEnabled_Internal(Type panelType, bool enable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 65)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled_Internal")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	private bool TryGetPanel_Internal(Type panelType, out Panel_Base panel)
	{
		panel = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 41)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel_Internal")]
	[CallsUnknownMethods(Count = 7)]
	public static T GetPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private Panel_Base GetPanel_Internal(Type panelType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	public static T LoadPanel<T>() where T : Panel_Base
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanels")]
	public static Panel_Base LoadPanel(Type panelType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(LoadPanelRequest), Member = ".ctor")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	private Panel_Base LoadPanel_Internal(Type panelType)
	{
		return null;
	}

	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
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

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPendingAsyncPanelRequest")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[Calls(Type = typeof(AsyncLoadPanelRequest), Member = ".ctor")]
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

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private BatchAsyncLoadPanelRequest GetBatchAsyncPanels_Internal(List<Type> panelTypes, Action<bool> panelLoadedCallback = null)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallsUnknownMethods(Count = 5)]
	private AsyncLoadPanelRequest GetPendingAsyncPanelRequest(string panelName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel_Internal")]
	[CallsUnknownMethods(Count = 2)]
	public static bool TryDestroyPanel<T>() where T : Panel_Base
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[CallAnalysisFailed]
	public static bool TryDestroyPanel(Type panelType)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CallsUnknownMethods(Count = 5)]
	private bool TryDestroyPanel_Internal(Type panelType)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanelVariantName")]
	[CallsUnknownMethods(Count = 1)]
	private string GetPanelName(Type panelType)
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync_Internal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanelName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private string GetPanelVariantName(Type panelType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "FinishLoadPanelRequest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateAsyncLoadPanelRequests()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateAsyncLoadPanelRequests")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel_Internal")]
	[Calls(Type = typeof(BaseLoadPanelRequest), Member = "GetPanel")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void FinishLoadPanelRequest(ILoadPanelRequest panelRequest)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static InterfaceManager GetInstance()
	{
		return null;
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanelsAsync")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CalledBy(Type = typeof(BatchAsyncLoadPanelRequest), Member = "LoadNextPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanelAsync")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "IsPanelLoaded")]
	[CalledBy(Type = typeof(Panel_Extras), Member = "PlayCredits")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	public static bool HasInstance()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateInterfaceSystem")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(EmptyScene), Member = "MaybeInstantiateLoadingScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static void CreateInterfaceManager()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Awake")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_atlas_sd")]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_atlas_sd")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void LoadReplacementAtlases(string suffix)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 3)]
	public void ResetReplacementAtlases()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateCommonGUI")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadReplacementAtlases")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIAtlas), Member = "set_replacement")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void SetupBasicMenuPrefab()
	{
	}

	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(InterfaceManager), Member = "UpdateAsyncLoadPanelRequests")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetLastLocations")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(Utils), Member = "ClearUITextureCache")]
	[Calls(Type = typeof(Utils), Member = "HasUITextureCache")]
	[Calls(Type = typeof(InterfaceManager), Member = "RequestConfirmationPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActive")]
	[CallsUnknownMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActiveInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool ShouldHidePopupBase()
	{
		return default(bool);
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "DetermineIfOverlayIsActive")]
	public static bool IsOverlayActiveImmediate()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsOverlayActiveCached()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPanelLoadingEnabledOrLoading()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "LateUpdate")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private static bool DetermineIfOverlayIsActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ShouldHidePopupBase")]
	[CalledBy(Type = typeof(PopupBase), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "AnyOverlayPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	private static bool DetermineIfOverlayIsActiveInternal(bool checkPopupBaseActive)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Enable")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(Action_PlayTimeline), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_close_ui")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ClearRequests")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ForceQuit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 106)]
	[Calls(Type = typeof(Panel_Milling), Member = "Disable")]
	[Calls(Type = typeof(InterfaceManager), Member = "UnloadMainMenuPanels")]
	[Calls(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[Calls(Type = typeof(Panel_Log), Member = "ExitInterface")]
	public static void QuitCurrentScreens()
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "Update")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public static bool ShouldImmediatelyExitOverlayDuringStruggle()
	{
		return default(bool);
	}

	[CallerCount(Count = 50)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static bool ShouldImmediatelyExitOverlay()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "ResetNotificationsData")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Log), Member = "ResetNotificationsData")]
	[Calls(Type = typeof(Panel_Crafting), Member = "ResetNotificationsData")]
	[Calls(Type = typeof(Panel_Inventory), Member = "ResetNotificationsData")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "ExitFeedFireInterface")]
	[Calls(Type = typeof(Panel_Cooking), Member = "ExitCookingInterface")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "ProgressBarEnded")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void CloseOverlaysDueToSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool SetCameraViewPort(float x, float y, float w, float h)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 73)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GameObject GetSoundEmitter()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldEnableMousePointer")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	public static void UpdateMousePointerState()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "SetActiveTab")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	public static bool IsUsingSurvivalTabs()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "OnFish")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "ConfigureForMissionStart")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Update")]
	public void SetTimeWidgetActive(bool active)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Rest), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_IceFishing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(TimeWidget), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Enable")]
	public void InitializeAndActivateTimeWidget(Transform parent, Vector3 pos)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(TimeWidget), Member = "Update")]
	[CalledBy(Type = typeof(AccelTimePopup), Member = "SetActive")]
	[CallsUnknownMethods(Count = 11)]
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
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 9)]
	private void InstantiateCommonGUI()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InstantiateTimeWidget()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void InstantiateInterfaceObjectsForLoading()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateInterfaceSystem")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadMainMenuPanels")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateTimeWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InterfaceManager), Member = "CachePanelReferences")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static void InstantiateInterfaceObjects()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 58)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	private static void CachePanelReferences()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void MapScreenshot(int detailLevel = 4)
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator TakeMapScreenshot(int detailLevel)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_HUD), Member = "IsShowingCollectibleNote")]
	[Calls(Type = typeof(PlayerManager), Member = "IsClickHoldActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "IsCancelableActionInProgress")]
	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateMousePointerState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Panel_IceFishing), Member = "IsFishing")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Rest), Member = "IsPassingTimeOnly")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static bool ShouldEnableMousePointer()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 49)]
	public static bool IsMainMenuEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsBrightnessCalibrationActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationLookup")]
	[CalledBy(Type = typeof(RockCache), Member = "Awake")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[Calls(Type = typeof(SceneNameMapping), Member = "GetNameForScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	public static string GetNameForScene(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "GetChecklistNameForKey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(SceneNameMapping), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	public static string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(SceneNameMapping), Member = "IsChildOfAnother")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	public static string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "UpdateConfirmPanelRequest")]
	[CallsUnknownMethods(Count = 1)]
	public static void RequestConfirmationPanel(Panel_Confirmation.CallbackDelegate onConfirm)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PopupDefinition), Member = "Show")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject InstantiatePopup(UIPanel panelPrefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "RequestConfirmationPanel")]
	private void UpdateConfirmPanelRequest()
	{
	}

	[Calls(Type = typeof(TwoButtonsChoiceUI), Member = "HideChoices")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[Calls(Type = typeof(GenericInteractionPrompt), Member = "HideInteraction")]
	[Calls(Type = typeof(BlueprintItem), Member = "ClearUnlockedBlueprints")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Map), Member = "ClearData")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideNotifications")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
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
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematic")]
	public static void HidePanelsForSubtitle()
	{
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "OnCinematicDone")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoExit")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnEnter_DialogueModeStatePlayCinematicComplete")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitlesImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void RestorePanelsAfterSubtitle()
	{
	}

	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void LoadMainMenuPanels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "HasInstance")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetBatchAsyncPanels_Internal")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public static ILoadPanelRequest LoadMainMenuPanelsAsync()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	public static void UnloadMainMenuPanels()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	public InterfaceManager()
	{
	}
}
