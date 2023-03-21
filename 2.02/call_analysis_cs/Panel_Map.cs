using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
using UnityEngine;

public class Panel_Map : Panel_Base
{
	private enum ResetOpts
	{
		None = 0,
		Zoomed = 1,
		CenterOnPlayer = 2,
		ShowPlayer = 4
	}

	private enum HoverState
	{
		None,
		BigSprite,
		SmallSprite,
		Area
	}

	private enum IconDisplayFilters : short
	{
		None = 0,
		Resources = 1,
		Structures = 2,
		Corpses = 4,
		RockCaches = 8,
		SprayMarkers = 16,
		All = 31
	}

	public static int OBJECT_POOL_SIZE;

	public static int DETAIL_POOL_SIZE;

	public static int AREA_POOL_SIZE;

	public static float MAP_RADIUS;

	public static float FOGOFWAR_RADIUS_MULTIPLIER;

	public static bool s_ForceShowPlayerIcon;

	public GameObject m_SurvivalTabs;

	public GameObject m_StoryTabs;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GenericButtonMouseSpawner m_WorldMapButtonObj;

	public UILabel m_HeaderLabel;

	public Transform m_MapElementsTransform;

	public MapCrosshair m_Crosshair;

	public Transform m_PlayerIcon;

	public GameObject m_BigSpritePrefab;

	public Transform m_BigSpritePoolParent;

	public Transform m_BigSpriteActiveObjects;

	public GameObject m_SmallSpritePrefab;

	public Transform m_SmallSpritePoolParent;

	public Transform m_SmallSpriteActiveObjects;

	public GameObject m_DetailEntryPrefab;

	public Transform m_DetailEntryPoolParent;

	public Transform m_DetailEntryActiveObjects;

	public GameObject m_TextPrefab;

	public Transform m_TextPoolParent;

	public Transform m_TextActiveObjects;

	public GameObject m_AreaPrefab;

	public Transform m_AreaPoolParent;

	public Transform m_AreaActiveObjects;

	public GameObject m_RegionSelectObject;

	public UILabel m_LastUpdatedLabel;

	public GameObject m_MousePromptDelete;

	public float m_DetailSurveyRadiusMeters;

	public float m_DetailSurveyRockCacheRadiusMeters;

	public float m_DetailSurveySprayPaintRadiusMeters;

	public float m_DetailSurvayPolaroidRadiusMeters;

	public float m_RangeToShowMapIcons;

	public float m_ZoomedInSize;

	public float m_GamepadMoveSpeed;

	public float m_MagnetizeSpeed;

	public List<RegionMap> m_MapObjects;

	public RegionMap m_WorldMapObject;

	public List<string> m_LocationsToUseBigSprite;

	public List<string> m_OutdoorLocationLabelsToIgnore;

	public bool m_DoMapCondense;

	public float m_MapCondenseDistance;

	public bool m_DoMapIconSpacing;

	public float m_MapIconSpacingDistance;

	public bool m_MergeMissionIconsWithLocations;

	public float m_MapIconLocationSpacingDistance;

	public string m_MessageMapIcon;

	public LocalizedString m_SprayPaintQuickKeyMapHeader;

	public LocalizedString m_SprayPaintQuickKeyMapMessage;

	public LocalizedString m_VistaLocationDiscoveredHeader;

	public LocalizedString m_VistaLocationDiscoveredMessage;

	public string m_VistaDiscoverDynamicString;

	public int m_ScreenTopOffset;

	public int m_ScreenBottomOffset;

	public int m_ScreenLeftOffset;

	public int m_ScreenRightOffset;

	public string m_OpenMapAudio;

	public string m_CloseMapAudio;

	public string m_ChangeMapAudio;

	public string m_VistaCompletedAudio;

	public float m_HoursThresholdJustNow;

	public float m_HoursThresholdHoursAgo;

	public float m_HoursThresholdToday;

	public float m_HoursThresholdYesterday;

	public TweenAlpha m_ObjectiveTween;

	public UILabel m_ObjectiveLabel;

	public UILabel m_ObjectiveDesc;

	public UISprite m_ObjectiveIcon;

	public GameObject m_CartographyFilters;

	public float m_FilterVerticalDelayTimeSeconds;

	public UIButton m_ResourcesButton;

	public UIWidget m_ResourcesOffOnDeselect;

	public UIButton m_StructuresButton;

	public UIWidget m_StructuresOffOnDeselect;

	public UIButton m_CorpsesButton;

	public UIWidget m_CorpsesOffOnDeselect;

	public UIButton m_RockCachesButton;

	public UIWidget m_RockCachesOffOnDeselect;

	public UIButton m_SprayMarkingsButton;

	public UIWidget m_SprayMarkingsOffOnDeselect;

	public int m_CartographyRockCacheSkillLevel;

	public int m_CartographyFilterSkillLevel;

	public int m_CartographyMarkerSkillLevel;

	public List<string> m_StructuresKeywordList;

	public List<string> m_CorpseKeywordList;

	public string m_RockCacheKeyword;

	private const string m_SprayMarkerKeyword = "SprayPaint";

	public string m_UserMarkerKeyword;

	public float m_MarkerClusterMapSize;

	public string m_SprayClusterIcon;

	public string m_RockCacheClusterIcon;

	public string m_MarkerClusterLocID;

	public string m_LowVisibilitySurveyLocId;

	public float m_MultiMarkerIconSize;

	public GameObject m_N2HRoot;

	public UILabel m_N2HProgressLabel;

	public UISprite m_N2HProgressBarSprite;

	public string[] m_LocationNames;

	public string[] m_SpriteAssignments;

	[NonSerialized]
	public bool m_HasBeenUpdated;

	private Dictionary<string, List<MapElementSaveData>> m_MapElementData;

	private Dictionary<Transform, MapElementSaveData> m_TransformToMapData;

	private Dictionary<string, List<DetailSurveyPosition>> m_DetailSurveyPositions;

	private Dictionary<string, float> m_DetailSurveyLastUpdateTimes;

	private Dictionary<string, FogOfWar> m_FogOfWar;

	private Dictionary<string, List<VistaLocationData>> m_SurveyedVistaLocations;

	private List<VistaLocation> m_ActiveVistaLocations;

	private List<VistaLocation> m_VistaLocationList;

	private List<MapElementRemovalData> m_DelayedMapElementRemovals;

	private bool m_IsZoomed;

	private HoverState m_HoverState;

	private Vector3 m_MapElementsOrigPos;

	private MapIcon m_MapIconBeingHovered;

	private MapIcon m_MapIconToRenameDelete;

	private UIWidget m_CrosshairWidget;

	private string m_RegionNameOfLoadedObjects;

	private List<string> m_UnlockedRegionNames;

	private int m_RegionSelectedIndex;

	private MissionMapMarkerInfo[] m_MarkerInfoFromResources;

	private uint m_OpenCloseAudioID;

	private bool m_DoMapCondenseInternal;

	private bool m_DoMapIconSpacingInternal;

	private bool m_MergeMissionIconsWithLocationsInternal;

	private List<Transform> m_MergedLocations;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private MapElementSaveData m_ObjectIconMapData;

	private IconDisplayFilters m_IconDisplayFilters;

	private List<UIWidget> m_FilterOffOnDeselect;

	private bool m_FilterSelecterEnabled;

	private int m_FilterSelectionIndex;

	private List<ClusterCell> m_ClusterCells;

	private MapElementSaveData m_LastMapElementAdded;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	[Calls(Type = typeof(Panel_Map), Member = "CacheComponents")]
	[CallsUnknownMethods(Count = 86)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Map), Member = "CreateObjectPools")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Map), Member = "CheckForHoverState")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(Panel_Map), Member = "MagnetTowardsHoveredIcon")]
	[Calls(Type = typeof(Panel_Map), Member = "MaybeFollowMouseWithCrosshair")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateFilterButtons")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[Calls(Type = typeof(Panel_Map), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshLastUpdateTimeLabel")]
	[Calls(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 86)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 93)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 40)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey_clear")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallsUnknownMethods(Count = 5)]
	public void ClearData()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void RevealOnPolaroidDiscovery(string polaroidGearItemName, bool showOnMap)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	public void DoDetailSurvey(SurveyType surveyType = SurveyType.Charcoal)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsUnknownMethods(Count = 48)]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	public void DoNearbyDetailsCheck(float radius, bool forceAddSurveyPosition, bool useOverridePosition, Vector3 overridePostion, bool shouldAllowVistaReveals)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	public bool ShouldAddSurveyPosition()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_UnlockMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_UnlockAllMaps), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 19)]
	public void RevealFogForScene(string sceneName)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public void Enable(bool enable, bool cameFromDetailSurvey)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CallsUnknownMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnJournalNav()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[Calls(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheNav(string rockCacheName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnCraftingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	public void OnMissionsNav()
	{
	}

	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void ToggleWorldMap()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldCenterOnPlayer")]
	public void OnNextRegion()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldCenterOnPlayer")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void OnPrevRegion()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public bool IsRegionUnlocked([In] ref string regionName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	public void SetRegion(string regionName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	public void UnlockMapCurrentScene()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockMapCurrentScene")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Action_UnlockMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_map_unlock_region")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_UnlockAllMaps), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallerCount(Count = 6)]
	public void UnlockRegionMap(string regionName)
	{
	}

	[CallerCount(Count = 0)]
	public void GetUnlockedRegionNames(ref List<string> unlockRegionNames)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_map_reveal")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallerCount(Count = 1)]
	public void RevealCurrentScene()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "GatherItems")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public ClusterCell FindCluster(int x, int y)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnUserMarkerRenameConfirm")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Enable_Internal")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	public void ForceUpdateRegion()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	public void RefreshIconVisibility()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(Type = typeof(FogOfWar), Member = "ProcessList")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapCondense")]
	[Calls(Type = typeof(Panel_Map), Member = "MergeNearbyMissionMapIconsWithLocations")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLegacyUserMarker")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	public void LoadMapElementsForScene(string sceneName)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void RenameMapMarkerFromGuid(string guid, string newName)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateCustomName")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[CallsUnknownMethods(Count = 5)]
	public void AddMapDetailToMap(MapDetail mapDetail)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateCustomName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void RemoveMapDetailFromMap(MapDetail mapDetail, float delayHours)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	public void AddIndoorSpaceTrigger(string triggerID, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	public void AddLoadScene(string sceneName, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void AddDisplayLocationLabel(string locationLocID, Vector3 worldPos)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "OnUpdate")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mapmarker_add")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	public bool AddMapMarkerToMap(string markerID, bool isSurveyed = true)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mapmarker_remove")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMarkerFromWorldPos")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void RemoveMapMarkerFromMap(string markerID)
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void AddMapIconFromFSM(string markerID, bool nameIsKnown)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	public bool AddDecalMapMarker(DecalProjectorInstance decal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	public void RemoveDecalMapMarker(DecalProjectorInstance decal)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(FogOfWar), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	public float GetDetailLevelAlpha()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMapNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMapNam")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoOpenMap")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Show")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "RestoreDisplay")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMapNav")]
	public bool NoMapsUnlocked()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMapNam")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoOpenMap")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public void ShowNoMapsUnlockedMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetNumberOfUnlockedMapElements")]
	public bool CheckRegionForAchievement(string sceneName, int numTopLevelIconsRequired, int numLocationTriggersRequired, ref int numComplete)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckRegionForAchievement")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public int GetNumberOfUnlockedMapElements(string sceneName)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public List<string> GetLocIdsOfUnlockedMapElements(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedMission()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	public void CenterOn(string missionId)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CallsUnknownMethods(Count = 3)]
	public void CenterOnPoint(Vector3 point)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	public MapElementSaveData AddMapElementCurrentRegion(string locationLocID, string spriteName, bool bigSprite, bool nameIsKnown, Vector3 worldPos, bool isDetail = false, bool isArea = false, bool showDirectional = false, float directionalAngle = float.NaN, string customName = "", bool worldPosIsMapPos = false, string optionalGuid = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	public void RemoveMapElementCurrentRegion(string locationLocID, Vector3 worldPos)
	{
	}

	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "MapPositionToWorldPosition")]
	[Calls(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	public void AddSurveyedVistaLocation(string regionName, VistaLocation vistaLocation)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool HasVistaLocationBeenSurveyed(VistaLocation vistaLocation)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AreAnyUnsurveyedVistasActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private bool HasVistaLocationBeenSurveyed(string regionName, VistaLocation vistaLocation)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallerCount(Count = 3)]
	public bool HasVistaLocationRequiredGearItem(VistaLocation vistaLocation)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void AddActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void RemoveActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[CalledBy(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAnyUnsurveyedVistasActive()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CallsUnknownMethods(Count = 3)]
	public MapIcon GetMapIconFromMapElement(MapElementSaveData mesd)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMarkerRemove")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	public void DeleteMarker(MapElementSaveData mesd, MapIcon mapIcon, bool shouldClearHoveredIcon)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	public void ResetNotificationsData()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static bool IsPartOfCluster(MapElementSaveData me)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	private static bool IsCluster(MapElementSaveData me)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "CanOpen")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	public static bool IsRockCache(MapElementSaveData me)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsLegacyUserMarker(MapElementSaveData me)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "CanDelete")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	public static bool IsSprayPaint(MapElementSaveData me)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	private static bool IsLocationIdSprayPaint(string locationName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	private void RemoveMapElementCurrentRegion(string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElementCurrentRegion")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveExpiredMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveDecalMapMarker")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	private void RemoveMapElement(string regionName, string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDisplayLocationLabel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddIndoorSpaceTrigger")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private MapElementSaveData AddMapElement(string regionName, string locationLocID, string spriteName, bool bigSprite, bool nameIsKnown, Vector3 worldPos, bool isDetail = false, bool isArea = false, bool showDirectional = false, float directionalAngle = float.NaN, Vector2 areaZoneSize = default(Vector2), string customName = "", bool worldPosIsMapPos = false, string optionalGuid = null)
	{
		return null;
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MissionMapDataIsMatch")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapElementExists")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	private Vector3 WorldPositionToMapPosition(string regionName, Vector3 worldPos)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private void MapPositionToWorldPosition(string regionName, Vector2 mapPosition, float radius, out Vector3 worldPos, out float worldRadius)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref worldPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref worldRadius) = null;
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "SignedAngle")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private Quaternion WorldRotationToMapRotation(string regionName, Quaternion worldRotation)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void CreateObjectPools()
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void UnloadMapElements()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddIndoorSpaceTrigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private string GetSpriteNameForLocation(string location)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public bool MapElementExists(string regionName, string locationNameLocID, Vector3 worldPos)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	private bool MapDataIsMatch(MapElementSaveData mapData, string locationNameLocID, Vector3 worldPos, string regionName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsUnknownMethods(Count = 2)]
	private bool MissionMapDataIsMatch(MapElementSaveData mapData, string missionNameLocID, Vector3 worldPos, string regionName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ProcessFilterButtons")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	private void HideFilterButtonLabels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallsUnknownMethods(Count = 6)]
	private void ProcessFilterButtons()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	private void FilterSelectionToggle()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "ProcessFilterButtons")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuToolSelectPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuToolSelectPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	private void DoGamepadControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	private void ShowClusterList(MapElementSaveData mesd, MapIcon mapBeingHovered)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	private void DoMouseControls()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	public void ForceZoomIn()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAlwaysBeZoomed")]
	private void ToggleZoom()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	private void CheckForHoverState()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	private void UpdateCrosshairState()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[Calls(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MapIcon), Member = "HideHoverWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[Calls(Type = typeof(MapIcon), Member = "HideHoverWidget")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	private void SetMapIconBeingHovered(MapIcon newMapIcon)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void MaybeShowClusterListOnHover()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RefreshHoverIconText(MapIcon hoverIcon)
	{
	}

	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	private void UpdateObjectiveGroup(MapElementSaveData mapData)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldRotationToMapRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MapCrosshair), Member = "ResetToNormal")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAlwaysBeZoomed")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	private void ResetToNormal(ResetOpts opts)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void MagnetTowardsHoveredIcon()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void RemoveExpiredMapElements(bool force)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 64)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[CallsDeduplicatedMethods(Count = 29)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void CheckForExpiredMissionTimers()
	{
	}

	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	private void MaybeFollowMouseWithCrosshair()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	private int GetIndexOfCurrentScene()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void LoadMarkerDataFromResources()
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CallsUnknownMethods(Count = 3)]
	private int GetMapMarkerIndex(string markerID)
	{
		return default(int);
	}

	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	private void AddMarkerToWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CallsUnknownMethods(Count = 106)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	private void AddMarkerToLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void RemoveMarkerFromWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void RemoveMarkerFromLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void RefreshLastUpdateTimeLabel()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(RegionManager), Member = "SceneIsRegion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockMapCurrentScene")]
	private bool SceneCanBeMapped(string sceneName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	private void DoMapCondense(Transform mapIconParent)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	private void DoMapIconSpacing(Transform mapIconParentStatic, Transform mapIconParentMoveable)
	{
	}

	[Calls(Type = typeof(MapIcon), Member = "SetLocationMapIcon")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	private void MergeNearbyMissionMapIconsWithLocations(Transform mapIconMissionParent, Transform mapIconLocationParent)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private bool ShouldAlwaysBeZoomed()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetNumberOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckRegionForAchievement")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	private string GetMapNameOfScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	private string GetMapNameOfCurrentScene()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(MapIcon), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MapIcon), Member = "GetLocationMapTransform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapIcon), Member = "SetState")]
	private void UpdateIconsForOffscreenMissionMarkers()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	private void UpdateFilterButtons()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetButtonState(UIButton button, bool selected)
	{
	}

	[CallerCount(Count = 0)]
	private void ToggleIconDisplayFlag(IconDisplayFilters flagToToggle)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private bool IsStructure(string locNameID)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsCorpse(string locNameID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	public void OnToggleResourcesFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCorpse")]
	[Calls(Type = typeof(Panel_Map), Member = "IsStructure")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateIconVisibility_Resources()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public void OnToggleStructuresFilter()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[Calls(Type = typeof(Panel_Map), Member = "IsStructure")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	public void UpdateIconVisibility_Structures()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	public void OnToggleCorpsesFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCorpse")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void UpdateIconVisibility_Corpses()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	public void OnToggleRockCacheFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void UpdateIconVisibility_RockCache()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	public void OnToggleSprayMarkingsFilter()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	public void UpdateIconVisibility_SprayMarkings()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CallsUnknownMethods(Count = 17)]
	private void OnSprayPaintMarkerRemove(MapElementSaveData mesd)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[CallerCount(Count = 0)]
	private void OnSprayPaintMarkerRemoveCancel(bool wasCancelled)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnUserMarkerRenameConfirm()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallsUnknownMethods(Count = 3)]
	private void OnMarkerRemove(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void LoadMapElementsForSceneDone()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallsUnknownMethods(Count = 6)]
	private void EnableCartographyFilters()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "GetOrCreateClusterCell")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClusterCell), Member = "UpdateFrom")]
	private void GatherClustersElementsForScene(List<MapElementSaveData> mapData)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[Calls(Type = typeof(ClusterCell), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	private ClusterCell GetOrCreateClusterCell(Vector2 positionOnMap, float width)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsUnknownMethods(Count = 1)]
	private void OnMapElementsPositionChanged()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMapClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMapClicked")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMapElementsPositionChanged")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	private void CloseMarkerListIfActive()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private bool ShouldCenterOnPlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateNowhereToHide()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CallsUnknownMethods(Count = 5)]
	private void CacheComponents()
	{
	}

	[CallsUnknownMethods(Count = 50)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Map()
	{
	}
}
