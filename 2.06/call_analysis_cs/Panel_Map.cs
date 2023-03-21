using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.PDID;
using TLD.Scenes;
using TLD.Serialization;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Panel_Map : Panel_AutoReferenced, INotificationHandler
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

	private sealed class _003C_003Ec__DisplayClass157_0
	{
		public Panel_Map _003C_003E4__this;

		public ZoneSpecification zone;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass157_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_Map), Member = "OnRegionMapInstanceCreated")]
		internal void _003CAddRegionMap_003Eb__0(AsyncOperationHandle<GameObject> op)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass159_0
	{
		public Panel_Map _003C_003E4__this;

		public ZoneSpecification zone;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass159_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CAddMapIcon_003Eb__0(AsyncOperationHandle<GameObject> op)
		{
		}
	}

	public const float MAP_RADIUS = 300f;

	private const int OBJECT_POOL_SIZE = 100;

	private const int DETAIL_POOL_SIZE = 700;

	private const int AREA_POOL_SIZE = 10;

	private const float FOGOFWAR_RADIUS_MULTIPLIER = 3f;

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

	public Transform m_WorldMapParent;

	public GameObject m_WorldMapVignette;

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

	private AK.Wwise.Event m_OpenMapEvent;

	private AK.Wwise.Event m_CloseMapEvent;

	private AK.Wwise.Event m_ChangeMapEvent;

	private AK.Wwise.Event m_VistaCompletedEvent;

	private PanelReference<Panel_Clothing> m_Clothing;

	private PanelReference<Panel_Confirmation> m_Confirmation;

	private PanelReference<Panel_Crafting> m_CraftingPanel;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_Loading> m_Loading;

	private PanelReference<Panel_Log> m_Log;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_MarkerList> m_MarkerList;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	private PanelReference<Panel_SprayPaint> m_SprayPaint;

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

	private readonly Dictionary<string, List<MapElementSaveData>> m_MapElementData;

	private readonly Dictionary<Transform, MapElementSaveData> m_TransformToMapData;

	private readonly Dictionary<string, List<DetailSurveyPosition>> m_DetailSurveyPositions;

	private readonly Dictionary<string, float> m_DetailSurveyLastUpdateTimes;

	private readonly Dictionary<string, FogOfWar> m_FogOfWar;

	private readonly Dictionary<string, List<VistaLocationData>> m_SurveyedVistaLocations;

	private readonly List<VistaLocation> m_ActiveVistaLocations;

	private readonly List<VistaLocation> m_VistaLocationList;

	private readonly List<MapElementRemovalData> m_DelayedMapElementRemovals;

	private readonly Dictionary<string, string> m_ParentZoneSpecificationByChild;

	private readonly Dictionary<WorldMapSpecification, UIWorldMap> m_WorldMaps;

	private bool m_IsZoomed;

	private HoverState m_HoverState;

	private Vector3 m_MapElementsOrigPos;

	private MapIcon m_MapIconBeingHovered;

	private MapIcon m_MapIconToRenameDelete;

	private UIWidget m_CrosshairWidget;

	private readonly List<string> m_UnlockedRegionNames;

	private int m_RegionSelectedIndex;

	private IList<GameObject> m_MarkerInfoAddressables;

	private MissionMapMarkerInfo[] m_MarkerInfoFromResources;

	private uint m_OpenCloseAudioID;

	private bool m_DoMapCondenseInternal;

	private bool m_DoMapIconSpacingInternal;

	private bool m_MergeMissionIconsWithLocationsInternal;

	private readonly List<Transform> m_MergedLocations;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	private MapElementSaveData m_ObjectIconMapData;

	private IconDisplayFilters m_IconDisplayFilters;

	private List<UIWidget> m_FilterOffOnDeselect;

	private bool m_FilterSelecterEnabled;

	private int m_FilterSelectionIndex;

	private readonly List<ClusterCell> m_ClusterCells;

	private MapElementSaveData m_LastMapElementAdded;

	private NotificationFlag m_NotificationFlag;

	private Transform[] m_NotificationFlagChildren;

	private AsyncOperationHandle<IList<ZoneSpecification>> m_ZoneRequests;

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMarkerDataFromResources")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Panel_Map), Member = "CreateObjectPools")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapIcon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "AddRegionMap")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	private void OnZoneSpecificationsLoaded(AsyncOperationHandle<IList<ZoneSpecification>> zoneLoadOperation)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnZoneSpecificationsLoaded")]
	[CallsUnknownMethods(Count = 12)]
	private void AddRegionMap(ZoneSpecification zone)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass157_0), Member = "<AddRegionMap>b__0")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void OnRegionMapInstanceCreated(ZoneSpecification zone, AsyncOperationHandle<GameObject> regionMapOperation)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnZoneSpecificationsLoaded")]
	[CallsUnknownMethods(Count = 13)]
	private void AddMapIcon(ZoneSpecification zone)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnMapIconInstanceCreated(ZoneSpecification zone, AsyncOperationHandle<GameObject> mapIconOperation)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[CallerCount(Count = 0)]
	public void OnControllerScheme(bool isController)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "CheckForHoverState")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateFilterButtons")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshLastUpdateTimeLabel")]
	[Calls(Type = typeof(Panel_Map), Member = "MagnetTowardsHoveredIcon")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(Panel_Map), Member = "MaybeFollowMouseWithCrosshair")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[Calls(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "CheckForExpiredMissionTimers")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 82)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MapSaveData), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 111)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 41)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey_clear")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void ClearData()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RevealOnPolaroidDiscovery(string polaroidGearItemName, bool showOnMap)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[Calls(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(RockCache), Member = "SetupInWorld")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	public void DoDetailSurvey(SurveyType surveyType = SurveyType.Charcoal)
	{
	}

	[CalledBy(Type = typeof(MapDetail), Member = "AddNoteMapMarker")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey")]
	[CallsUnknownMethods(Count = 49)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public void DoNearbyDetailsCheck(float radius, bool forceAddSurveyPosition, bool useOverridePosition, Vector3 overridePostion, bool shouldAllowVistaReveals = false)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(VistaLocation), Member = "HasRequiredGearItem")]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldAddSurveyPosition()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_UnlockAllMaps), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RevealFogForScene(ZoneSpecification zone)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CalledBy(Type = typeof(Action_UnlockMap), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 12)]
	public void RevealFogForScene(string sceneName)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "CanPlaySpecialUIEntrySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshLastUpdateTimeLabel")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(MapDetail), Member = "AddNoteMapMarker")]
	[CalledBy(Type = typeof(CharcoalItem), Member = "DetailSurveyComplete")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplySurvey")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoDetailSurvey")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_survey")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "DisableWorldMaps")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[Calls(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(GameManager), Member = "MaybeForceGC")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableNavigationTabs")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableNavigationTabs")]
	public void Enable(bool enable, bool cameFromDetailSurvey)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DisableWorldMaps()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameAudioManager), Member = "MaybePlayOverrideCloseSound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(InputManager), Member = "MaybeClosePanelDueToHotkey")]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Inventory), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnInventoryNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClothingNav()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFirstAidNav()
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnJournalNav()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OpenRockCache")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableRockCacheStateFromMap")]
	public void OnRockCacheNav(string rockCacheName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCraftingNav()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	public void OnMissionsNav()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetWorldMapForSceneSet")]
	public void ToggleWorldMap()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeFollowMouseWithCrosshair")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateNowhereToHide")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshLastUpdateTimeLabel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	private bool IsWorldMapActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Map), Member = "GetWorldMapForSceneSet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void EnableWorldMapOfCurrentScene()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "EnableWorldMapOfCurrentScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	private WorldMapSpecification GetWorldMapForSceneSet(SceneSet sceneSet)
	{
		return null;
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	public void OnNextRegion()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetSoundEmitter")]
	[Calls(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(Panel_Map), Member = "EnableCartographyFilters")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	public void OnPrevRegion()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "GenerateRockCacheScreenData")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(RockCacheListItem), Member = "SetRegionInfo")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsRegionUnlocked(string regionName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Action_UnlockAllMaps), Member = "OnExecute")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UnlockRegionMap(ZoneSpecification zone)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_UnlockMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_map_unlock_region")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockMapCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UnlockRegionMap(string regionName)
	{
	}

	[CallerCount(Count = 0)]
	public void GetUnlockedRegionNames(ref List<string> unlockRegionNames)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_map_reveal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	public void RevealCurrentScene()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "GatherItems")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ClusterCell FindCluster(int x, int y)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "Enable_Internal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[Calls(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "UnloadMapElements")]
	[CallerCount(Count = 3)]
	public void ForceUpdateRegion()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	public void RefreshIconVisibility()
	{
	}

	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(Type = typeof(FogOfWar), Member = "ProcessList")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapCondense")]
	[Calls(Type = typeof(Panel_Map), Member = "MergeNearbyMissionMapIconsWithLocations")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLegacyUserMarker")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Panel_Map), Member = "DoMapIconSpacing")]
	public void LoadMapElementsForScene(string sceneName)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(RockCacheManager), Member = "UpdateRockCacheName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void RenameMapMarkerFromGuid(string guid, string newName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateCustomName")]
	[CalledBy(Type = typeof(MapDetail), Member = "Unlock")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(RockCache), Member = "SetMapDetailName")]
	public void AddMapDetailToMap(MapDetail mapDetail)
	{
	}

	[CalledBy(Type = typeof(RockCache), Member = "SetMapDetailName")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "BodyHarvestDestroy")]
	[CalledBy(Type = typeof(MapDetail), Member = "ShowOnMap")]
	[CalledBy(Type = typeof(MapDetail), Member = "UpdateCustomName")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LockAll")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsUnknownMethods(Count = 3)]
	public void RemoveMapDetailFromMap(MapDetail mapDetail, float delayHours)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void AddIndoorSpaceTrigger(string triggerID, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	public void AddLoadScene(string sceneName, Vector3 worldPos, bool nameIsKnown)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsUnknownMethods(Count = 1)]
	public void AddDisplayLocationLabel(string locationLocID, Vector3 worldPos)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mapmarker_add")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "OnUpdate")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	public bool AddMapMarkerToMap(string markerID, bool isSurveyed = true)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Map), Member = "RemoveMarkerFromWorldPos")]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_mapmarker_remove")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	public void RemoveMapMarkerFromMap(string markerID)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "OnExecute")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	public void AddMapIconFromFSM(string markerID, bool nameIsKnown)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapMarkerIndex")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[CallsUnknownMethods(Count = 2)]
	public bool AddDecalMapMarker(DecalProjectorInstance decal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void RemoveDecalMapMarker(DecalProjectorInstance decal)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(FogOfWar), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 2)]
	public float GetDetailLevelAlpha()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool NoMapsUnlocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallerCount(Count = 0)]
	public void ShowNoMapsUnlockedMessage()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool CheckRegionForAchievement(string sceneName, int numTopLevelIconsRequired, int numLocationTriggersRequired, ref int numComplete)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNumberOfUnlockedMapElements(string sceneName)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildCartographyRegionList")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "LogAllUnmappedLocations")]
	[CallsUnknownMethods(Count = 8)]
	public List<string> GetLocIdsOfUnlockedMapElements(string sceneName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetSelectedMission()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "OnMapNav")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteOpenMapActionFromObjective")]
	[CallsUnknownMethods(Count = 13)]
	public void CenterOn(string missionId)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealOnPolaroidDiscovery")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(MapDetail), Member = "AddNoteMapMarker")]
	public void CenterOnPoint(Vector3 point)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapDetailToMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
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

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(VistaLocation), Member = "HasRequiredGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[Calls(Type = typeof(VistaLocation), Member = "GetGuid")]
	[Calls(Type = typeof(Panel_Map), Member = "MapPositionToWorldPosition")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
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
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool HasVistaLocationBeenSurveyed(string regionName, VistaLocation vistaLocation)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[CallsUnknownMethods(Count = 1)]
	private static int MapDetailComparer(MapElementSaveData a, MapElementSaveData b)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UnregisterVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveActiveVistaLocation(VistaLocation vistaLocation)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[CalledBy(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool AreAnyUnsurveyedVistasActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[CallsUnknownMethods(Count = 4)]
	public MapIcon GetMapIconFromMapElement(MapElementSaveData mesd)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMarkerRemove")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DoDeleteItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	public void DeleteMarker(MapElementSaveData mesd, MapIcon mapIcon, bool shouldClearHoveredIcon)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ResetNotificationsData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsPartOfCluster(MapElementSaveData me)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	private static bool IsCluster(MapElementSaveData me)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "MapDetailComparer")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_RockCache")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapDetailComparer")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "CanOpen")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	public static bool IsRockCache(MapElementSaveData me)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsLegacyUserMarker(MapElementSaveData me)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool IsSprayPaint(MapElementSaveData me)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "MapDetailComparer")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_SprayMarkings")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "IsSprayPaint")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapDetailComparer")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(MarkerListDisplayItem), Member = "CanDelete")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "CanDeleteAll")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteAllMarkerRemoveConfirm")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "DeleteAllDeleteableItems")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "UpdateGamePad")]
	[CalledBy(Type = typeof(Panel_MarkerList), Member = "OnDeleteItemRequested")]
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

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveDecalMapMarker")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveExpiredMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapDetailFromMap")]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CalledBy(Type = typeof(ShowOnMapItem), Member = "RemoveFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	private void RemoveMapElement(string regionName, string locationLocID, Vector3 worldPos, float delayHours)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElementCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDisplayLocationLabel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	[CalledBy(Type = typeof(ShowOnMapItem), Member = "AddToMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddIndoorSpaceTrigger")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	private MapElementSaveData AddMapElement(string regionName, string locationLocID, string spriteName, bool bigSprite, bool nameIsKnown, Vector3 worldPos, bool isDetail = false, bool isArea = false, bool showDirectional = false, float directionalAngle = float.NaN, Vector2 areaZoneSize = default(Vector2), string customName = "", bool worldPosIsMapPos = false, string optionalGuid = null)
	{
		return null;
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "MissionMapDataIsMatch")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToWorldPos")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CenterOnPoint")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "MapElementExists")]
	private Vector3 WorldPositionToMapPosition(string regionName, Vector3 worldPos)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallsUnknownMethods(Count = 4)]
	private void MapPositionToWorldPosition(string regionName, Vector2 mapPosition, float radius, out Vector3 worldPos, out float worldRadius)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref worldPos) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref worldRadius) = null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(RegionMap), Member = "IsRegionMatch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	private Quaternion WorldRotationToMapRotation(string regionName, Quaternion worldRotation)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	private void CreateObjectPools()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void UnloadMapElements()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddIndoorSpaceTrigger")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddLoadScene")]
	private string GetSpriteNameForLocation(string location)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	public bool MapElementExists(string regionName, string locationNameLocID, Vector3 worldPos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMarkerFromLocation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMarkerToLocation")]
	[CallsUnknownMethods(Count = 2)]
	private bool MapDataIsMatch(MapElementSaveData mapData, string locationNameLocID, Vector3 worldPos, string regionName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool MissionMapDataIsMatch(MapElementSaveData mapData, string missionNameLocID, Vector3 worldPos, string regionName)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ProcessFilterButtons")]
	[CallsUnknownMethods(Count = 6)]
	private void HideFilterButtonLabels()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "HideFilterButtonLabels")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	private void ProcessFilterButtons()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	private void FilterSelectionToggle()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuToolSelectPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Panel_Map), Member = "ProcessFilterButtons")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryAddToSatchelPressed")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuToolSelectPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleRockCacheFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleSprayMarkingsFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleCorpsesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleStructuresFilter")]
	[Calls(Type = typeof(InputManager), Member = "GetEquipPressed")]
	[Calls(Type = typeof(Panel_Map), Member = "OnToggleResourcesFilter")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	private void DoGamepadControls()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "MaybeShowClusterListOnHover")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	private void ShowClusterList(MapElementSaveData mesd, MapIcon mapBeingHovered)
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Panel_Map), Member = "OnRockCacheNav")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(Panel_Map), Member = "OnSprayPaintMarkerRemove")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void DoMouseControls()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheShowOnMapClicked")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	public void ForceZoomIn()
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateCrosshairState")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
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
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleZoom")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceZoomIn")]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MapCrosshair), Member = "SetState")]
	private void UpdateCrosshairState()
	{
	}

	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MapIcon), Member = "HideHoverWidget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[Calls(Type = typeof(MapIcon), Member = "HideHoverWidget")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	private void SetMapIconBeingHovered(MapIcon newMapIcon)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "IsCluster")]
	private void MaybeShowClusterListOnHover()
	{
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[Calls(Type = typeof(Panel_Map), Member = "UpdateObjectiveGroup")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MissionTimer), Member = "get_Time")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetDurationString")]
	private void RefreshHoverIconText(MapIcon hoverIcon)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(TweenAlpha), Member = "get_value")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetMissionInfoFromID")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void UpdateObjectiveGroup(MapElementSaveData mapData)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldRotationToMapRotation")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(MapCrosshair), Member = "ResetToNormal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	private void ResetToNormal(ResetOpts opts)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton")]
	private void MagnetTowardsHoveredIcon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveExpiredMapElements(bool force)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionTimerByName")]
	private void CheckForExpiredMissionTimers()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	private void MaybeFollowMouseWithCrosshair()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ResetToNormal")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Utils), Member = "InferOutdoorSceneName")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	private int GetIndexOfCurrentScene()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	private static bool SceneNameEquals(string a, string b)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Initialize")]
	[CallsUnknownMethods(Count = 4)]
	private void LoadMarkerDataFromResources()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	private int GetMapMarkerIndex(string markerID)
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	private void AddMarkerToWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[Calls(Type = typeof(Panel_Map), Member = "GetSpriteNameForLocation")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	private void AddMarkerToLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Panel_Map), Member = "WorldPositionToMapPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	private void RemoveMarkerFromWorldPos(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(Panel_Map), Member = "MapDataIsMatch")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetLocIDForScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void RemoveMarkerFromLocation(MissionMapMarkerInfo markerInfo, StoryMissionInfo missionInfo)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private void RefreshLastUpdateTimeLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapMarkerFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapIconFromFSM")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapMarkerToMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddMapElement")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockRegionMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UnlockMapCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RevealFogForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[Calls(Type = typeof(Panel_Map), Member = "GetParentZoneSpecificationName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	private bool SceneCanBeMapped(string sceneName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	private void DoMapCondense(Transform mapIconParent)
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	private void DoMapIconSpacing(Transform mapIconParentStatic, Transform mapIconParentMoveable)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(MapIcon), Member = "SetLocationMapIcon")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	private void MergeNearbyMissionMapIconsWithLocations(Transform mapIconMissionParent, Transform mapIconLocationParent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool ShouldAlwaysBeZoomed()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CalledBy(Type = typeof(AchievementManager), Member = "IsRegionCompleteFaithfulCartographer")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetNumberOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetLocIdsOfUnlockedMapElements")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckRegionForAchievement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "CheckRegionForAchievement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	private string GetMapNameOfScene(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SceneCanBeMapped")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private string GetParentZoneSpecificationName(string name)
	{
		return null;
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfScene")]
	[Calls(Type = typeof(Panel_Map), Member = "GetParentZoneSpecificationName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	private string GetMapNameOfCurrentScene()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(MapIcon), Member = "SetState")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(MapIcon), Member = "SetState")]
	[Calls(Type = typeof(MapIcon), Member = "GetLocationMapTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	private void UpdateIconsForOffscreenMissionMarkers()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsUsingSurvivalTabs")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	private void EnableNavigationTabs(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
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
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Structures")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private bool IsStructure(string locNameID)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Resources")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconVisibility_Corpses")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsCorpse(string locNameID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	public void OnToggleResourcesFilter()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsCorpse")]
	[Calls(Type = typeof(Panel_Map), Member = "IsStructure")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	public void UpdateIconVisibility_Resources()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public void OnToggleStructuresFilter()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "IsStructure")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallsUnknownMethods(Count = 13)]
	public void UpdateIconVisibility_Structures()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public void OnToggleCorpsesFilter()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "IsCorpse")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallsUnknownMethods(Count = 13)]
	public void UpdateIconVisibility_Corpses()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	public void OnToggleRockCacheFilter()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallsUnknownMethods(Count = 12)]
	public void UpdateIconVisibility_RockCache()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "FilterSelectionToggle")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	public void OnToggleSprayMarkingsFilter()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ForceUpdateRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshIconVisibility")]
	[CallsUnknownMethods(Count = 13)]
	public void UpdateIconVisibility_SprayMarkings()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoMouseControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowConfirmPanel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	private void OnSprayPaintMarkerRemove(MapElementSaveData mesd)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[CallerCount(Count = 0)]
	private void OnSprayPaintMarkerRemoveCancel(bool wasCancelled)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "DeleteMarker")]
	[CallsUnknownMethods(Count = 1)]
	private void OnMarkerRemove(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_MarkerList), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void LoadMapElementsForSceneDone()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallsUnknownMethods(Count = 3)]
	private void EnableCartographyFilters()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ClusterCell), Member = "UpdateMapElement")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ClusterCell), Member = "UpdateFrom")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[Calls(Type = typeof(Panel_Map), Member = "IsRockCache")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "GetOrCreateClusterCell")]
	private void GatherClustersElementsForScene(List<MapElementSaveData> mapData)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(MapElementSaveData), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GatherClustersElementsForScene")]
	[CallsUnknownMethods(Count = 20)]
	private ClusterCell GetOrCreateClusterCell(Vector2 positionOnMap, float width)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnMapElementsPositionChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Map), Member = "CloseMarkerListIfActive")]
	[CallsUnknownMethods(Count = 1)]
	private void OnMapClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "DoGamepadControls")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMapClicked")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnMapElementsPositionChanged")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "ShowClusterList")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnPrevRegion")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_Map), Member = "ToggleWorldMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Map), Member = "OnNextRegion")]
	private void CloseMarkerListIfActive()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	private bool ShouldCenterOnPlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ToxicFogManager), Member = "GetFogProgressForRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Map), Member = "IsWorldMapActive")]
	private void UpdateNowhereToHide()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CacheComponents()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 81)]
	public Panel_Map()
	{
	}
}
