using System;
using System.Collections.Generic;
using System.Globalization;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Map), Member = "CreateObjectPools")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Resources), Member = "LoadAll")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[Calls(Type = typeof(Panel_Map), Member = "CacheComponents")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 86)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[Calls(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[Calls(Type = typeof(Panel_Map), Member = "MaybeFollowMouseWithCrosshair")]
	[Calls(Type = typeof(Panel_Map), Member = "CheckForHoverState")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Map), Member = "MagnetTowardsHoveredIcon")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshLastUpdateTimeLabel")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateFilterButtons")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[Calls(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 86)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Enum), Member = "TryParse")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 93)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey_clear")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void ClearData()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "RevealOnPolaroidDiscovery")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void RevealOnPolaroidDiscovery(string polaroidGearItemName, bool showOnMap)
	{
	}

	[CalledBy(Type = typeof(CharcoalItem), Member = "Update")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DoDetailSurvey(SurveyType surveyType = SurveyType.Charcoal)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealCurrentScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 48)]
	public void DoNearbyDetailsCheck(float radius, bool forceAddSurveyPosition, bool useOverridePosition, Vector3 overridePostion, bool shouldAllowVistaReveals)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldAddSurveyPosition()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CalledBy(Type = typeof(Action_UnlockMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_UnlockAllMaps), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public void RevealFogForScene(string sceneName)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CallerCount(Count = 2)]
	public void Enable(bool enable, bool cameFromDetailSurvey)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnJournalNav()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnterState")]
	[Calls(Type = typeof(Panel_Log), Member = "Refresh")]
	[Calls(Type = typeof(Panel_Log), Member = "UpdateSectionNavButtonColors")]
	[Calls(Type = typeof(Panel_Log), Member = "SetRegionAndRockCacheSelected")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void OnRockCacheNav(string rockCacheName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnCraftingNav()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnMissionsNav()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void ToggleWorldMap()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldCenterOnPlayer")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnNextRegion()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldCenterOnPlayer")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnPrevRegion()
	{
	}

	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsRegionUnlocked([In] ref string regionName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_WorldMap), Member = "SelectRegionMap")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockMapCurrentScene")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_map_unlock_region")]
	[CalledBy(Type = typeof(Action_UnlockMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_UnlockAllMaps), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public void UnlockRegionMap(string regionName)
	{
	}

	[CallerCount(Count = 0)]
	public void GetUnlockedRegionNames(ref List<string> unlockRegionNames)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_map_reveal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void RevealCurrentScene()
	{
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "GatherItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ClusterCell FindCluster(int x, int y)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Enable_Internal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnUserMarkerRenameConfirm")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void ForceUpdateRegion()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	public void RefreshIconVisibility()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLegacyUserMarker")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapCondense")]
	[Calls(Type = typeof(Panel_Map), Member = "MergeNearbyMissionMapIconsWithLocations")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(FogOfWar), Member = "ProcessList")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 59)]
	public void LoadMapElementsForScene(string sceneName)
	{
	}

	[CalledBy(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void RenameMapMarkerFromGuid(string guid, string newName)
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "UpdateCustomName")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void AddMapDetailToMap(MapDetail mapDetail)
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "UpdateCustomName")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveMapDetailFromMap(MapDetail mapDetail, float delayHours)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddIndoorSpaceTrigger(string triggerID, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddLoadScene(string sceneName, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AddDisplayLocationLabel(string locationLocID, Vector3 worldPos)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mapmarker_add")]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public bool AddMapMarkerToMap(string markerID, bool isSurveyed = true)
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mapmarker_remove")]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMarkerFromWorldPos")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 32)]
	public void RemoveMapMarkerFromMap(string markerID)
	{
	}

	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public void AddMapIconFromFSM(string markerID, bool nameIsKnown)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public bool AddDecalMapMarker(DecalProjectorInstance decal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveDecalMapMarker(DecalProjectorInstance decal)
	{
	}

	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FogOfWar), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public float GetDetailLevelAlpha()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(HUDObjectives), Member = "RestoreDisplay")]
	[CalledBy(Type = typeof(HUDObjectives), Member = "Show")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoOpenMap")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMapNam")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool NoMapsUnlocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNavigationRadial")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoOpenMap")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "OnMapNam")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnMapNav")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapAction")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowNoMapsUnlockedMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetNumberOfUnlockedMapElements")]
	public bool CheckRegionForAchievement(string sceneName, int numTopLevelIconsRequired, int numLocationTriggersRequired, ref int numComplete)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "CheckRegionForAchievement")]
	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public int GetNumberOfUnlockedMapElements(string sceneName)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public List<string> GetLocIdsOfUnlockedMapElements(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ProcessInput")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public string GetSelectedMission()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public void CenterOn(string missionId)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void CenterOnPoint(Vector3 point)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
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

	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Map), Member = "MapPositionToWorldPosition")]
	[Calls(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 41)]
	public void AddSurveyedVistaLocation(string regionName, VistaLocation vistaLocation)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool HasVistaLocationBeenSurveyed(VistaLocation vistaLocation)
	{
		return false;
	}

	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AreAnyUnsurveyedVistasActive")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private bool HasVistaLocationBeenSurveyed(string regionName, VistaLocation vistaLocation)
	{
		return false;
	}

	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool HasVistaLocationRequiredGearItem(VistaLocation vistaLocation)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RemoveActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CalledBy(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool AreAnyUnsurveyedVistasActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public MapIcon GetMapIconFromMapElement(MapElementSaveData mesd)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMarkerRemove")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public void DeleteMarker(MapElementSaveData mesd, MapIcon mapIcon, bool shouldClearHoveredIcon)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void ResetNotificationsData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsPartOfCluster(MapElementSaveData me)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool IsCluster(MapElementSaveData me)
	{
		return false;
	}

	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "CanOpen")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsRockCache(MapElementSaveData me)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static bool IsLegacyUserMarker(MapElementSaveData me)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "CanDelete")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 11)]
	public static bool IsSprayPaint(MapElementSaveData me)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static bool IsLocationIdSprayPaint(string locationName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	private void RemoveMapElementCurrentRegion(string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[CalledBy(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveDecalMapMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveExpiredMapElements")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void RemoveMapElement(string regionName, string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[CalledBy(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddIndoorSpaceTrigger")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDisplayLocationLabel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 27)]
	private MapElementSaveData AddMapElement(string regionName, string locationLocID, string spriteName, bool bigSprite, bool nameIsKnown, Vector3 worldPos, bool isDetail = false, bool isArea = false, bool showDirectional = false, float directionalAngle = float.NaN, Vector2 areaZoneSize = default(Vector2), string customName = "", bool worldPosIsMapPos = false, string optionalGuid = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 31)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapElementExists")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MissionMapDataIsMatch")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromWorldPos")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private Vector3 WorldPositionToMapPosition(string regionName, Vector3 worldPos)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private void MapPositionToWorldPosition(string regionName, Vector2 mapPosition, float radius, out Vector3 worldPos, out float worldRadius)
	{
		worldPos = default(Vector3);
		worldRadius = default(float);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "SignedAngle")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private Quaternion WorldRotationToMapRotation(string regionName, Quaternion worldRotation)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 20)]
	private void CreateObjectPools()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 42)]
	private void UnloadMapElements()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddIndoorSpaceTrigger")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private string GetSpriteNameForLocation(string location)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public bool MapElementExists(string regionName, string locationNameLocID, Vector3 worldPos)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool MapDataIsMatch(MapElementSaveData mapData, string locationNameLocID, Vector3 worldPos, string regionName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool MissionMapDataIsMatch(MapElementSaveData mapData, string missionNameLocID, Vector3 worldPos, string regionName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ProcessFilterButtons")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void HideFilterButtonLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void ProcessFilterButtons()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	private void FilterSelectionToggle()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuToolSelectPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Panel_Map), Member = "ProcessFilterButtons")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[Calls(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 21)]
	private void DoGamepadControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ShowClusterList(MapElementSaveData mesd, MapIcon mapBeingHovered)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private void DoMouseControls()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void ForceZoomIn()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAlwaysBeZoomed")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void ToggleZoom()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	private void CheckForHoverState()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateCrosshairState()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(MapIcon), Member = "HideHoverWidget")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[Calls(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void SetMapIconBeingHovered(MapIcon newMapIcon)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeShowClusterListOnHover()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 27)]
	private void RefreshHoverIconText(MapIcon hoverIcon)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private void UpdateObjectiveGroup(MapElementSaveData mapData)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MapCrosshair), Member = "ResetToNormal")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAlwaysBeZoomed")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldRotationToMapRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 52)]
	private void ResetToNormal(ResetOpts opts)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void MagnetTowardsHoveredIcon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void RemoveExpiredMapElements(bool force)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 64)]
	private void CheckForExpiredMissionTimers()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 29)]
	private void MaybeFollowMouseWithCrosshair()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private int GetIndexOfCurrentScene()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Resources), Member = "LoadAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LoadMarkerDataFromResources()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	private int GetMapMarkerIndex(string markerID)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 57)]
	private void AddMarkerToWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 106)]
	private void AddMarkerToLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void RemoveMarkerFromWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private void RemoveMarkerFromLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	private void RefreshLastUpdateTimeLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockMapCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(RegionManager), Member = "SceneIsRegion")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool SceneCanBeMapped(string sceneName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 18)]
	private void DoMapCondense(Transform mapIconParent)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 17)]
	private void DoMapIconSpacing(Transform mapIconParentStatic, Transform mapIconParentMoveable)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[Calls(Type = typeof(MapIcon), Member = "SetLocationMapIcon")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 21)]
	private void MergeNearbyMissionMapIconsWithLocations(Transform mapIconMissionParent, Transform mapIconLocationParent)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldAlwaysBeZoomed()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "CheckRegionForAchievement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetNumberOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[CallsDeduplicatedMethods(Count = 2)]
	private string GetMapNameOfScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetMapNameOfCurrentScene()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MapIcon), Member = "GetLocationMapTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MapIcon), Member = "SetState")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 18)]
	private void UpdateIconsForOffscreenMissionMarkers()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
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

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsStructure(string locNameID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool IsCorpse(string locNameID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnToggleResourcesFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "IsStructure")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCorpse")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateIconVisibility_Resources()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 2)]
	public void OnToggleStructuresFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "IsStructure")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void UpdateIconVisibility_Structures()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 2)]
	public void OnToggleCorpsesFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCorpse")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void UpdateIconVisibility_Corpses()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 2)]
	public void OnToggleRockCacheFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void UpdateIconVisibility_RockCache()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallerCount(Count = 2)]
	public void OnToggleSprayMarkingsFilter()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void UpdateIconVisibility_SprayMarkings()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void OnSprayPaintMarkerRemove(MapElementSaveData mesd)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[CallerCount(Count = 0)]
	private void OnSprayPaintMarkerRemoveCancel(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TextInputField), Member = "GetText")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void OnUserMarkerRenameConfirm()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnMarkerRemove(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void LoadMapElementsForSceneDone()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void EnableCartographyFilters()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "GetOrCreateClusterCell")]
	[Calls(Type = typeof(ClusterCell), Member = "UpdateFrom")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private void GatherClustersElementsForScene(List<MapElementSaveData> mapData)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(ClusterCell), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private ClusterCell GetOrCreateClusterCell(Vector2 positionOnMap, float width)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMapElementsPositionChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnMapClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMapElementsPositionChanged")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMapClicked")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CloseMarkerListIfActive()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool ShouldCenterOnPlayer()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateNowhereToHide()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 50)]
	public Panel_Map()
	{
	}
}
