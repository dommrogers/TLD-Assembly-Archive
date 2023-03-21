using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using SpecialEvents;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public enum GameplayComponent
	{
		Sprains,
		Wind,
		BodyHarvest
	}

	private class DelayedGameplayComponentInfo
	{
		public readonly GameplayComponent m_Component;

		public readonly int m_Frequency;

		public int m_ValidFrame;

		public float m_DeltaTime;

		public float m_AccumulatedDelta;

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public DelayedGameplayComponentInfo(GameplayComponent component, int frequency)
		{
		}
	}

	private static DelayedGameplayComponentInfo[] s_DelayedGameplayComponentInfos;

	public SandboxConfig m_SandboxConfig;

	public const string MAIN_MENU = "MainMenu";

	public const string BOOT = "Boot";

	public const string EMPTY = "Empty";

	public GameObject m_AiDifficultySettingsPrefab;

	public GameObject m_AiSubsystemsPrefab;

	public GameObject m_BlueprintsPrefab;

	public GameObject m_ConditionSystemsPrefab;

	public GameObject m_ConditionTableSystemsPrefab;

	public GameObject m_EffectPoolManagerPrefab;

	public GameObject m_EngineSystemsPrefab;

	public GameObject m_EnvironmentSystemsPrefab;

	public GameObject m_ExperienceModesPrefab;

	public GameObject m_FirstAidSystemsPrefab;

	public GameObject m_GamePlaySystemsPrefab;

	public GameObject m_PlayerSystemsPrefab;

	public GameObject m_PlayerObjectPrefab;

	public GameObject m_RumbleEffectManagerPrefab;

	public GameObject m_SandboxManagerPrefab;

	public GameObject m_StoryManagerPrefab;

	public DialogueStatesTable m_DialogueStatesTable;

	public MissionObjectiveTable m_MissionObjectiveTable;

	public AfflictionDefinitionTable m_AfflictionDefinitionTable;

	public const int NUM_SANDBOX_SAVE_SLOTS = 5;

	public const int NUM_CHALLENGE_SAVE_SLOTS = 5;

	public const int NUM_STORY_SAVE_SLOTS = 6;

	public SceneMapping m_SceneMapping;

	public static bool s_UseLegacyLoading;

	public static string m_GameVersionString;

	public static int s_ActiveChangelist;

	public static bool m_IsPaused;

	public static bool m_SuppressLocationRevealOnLoadSaveGame;

	public static bool m_UnpauseOneFrame;

	public static bool m_PauseNextFrame;

	public static float m_SceneTransitionFadeOutTime;

	public static float m_SecondsSinceLevelLoad;

	public static SceneTransitionData m_SceneTransitionData;

	public static bool m_ForceForwardRendering;

	public static bool m_ForceDeferredRendering;

	public static bool m_SceneWasRestored;

	public static bool m_CheckPointSaveRequested;

	public static bool m_PendingSave;

	public static float m_PendingSaveSecondsAccumulated;

	public static float m_MaxPendingSaveTimeBeforeError;

	public static bool m_PendingSaveGeneratedError;

	public static bool m_DisableSaveLoad;

	public static bool m_BlockNonMovementInput;

	public static float m_LockControlsTimer;

	public static bool m_BlockMoveInputUntilReleased;

	private const float m_MoveInputMagnitudeReleaseThreshold = 0.1f;

	private static float m_MoveInputDotProdReleaseThreshold;

	private static Vector2 m_MoveInputWhenBlockedVector;

	public static bool m_BlockAbilityToRest;

	public static string m_BlockedRestLocID;

	public static bool m_BlockSceneTransition;

	public static string m_BlockedTransitionLocID;

	public static string m_ActiveScene;

	public static bool m_ActiveSceneIsRegion;

	public static int m_ActiveSceneResolutionOverride;

	public static bool m_Borderless;

	public static bool m_CurrentEpisodeCompleted;

	public static bool m_SuppressWeaponAim;

	public static bool m_PauseAudioWithGame;

	public static bool m_SkipFadeOnNextLoad;

	public static bool m_AllowSaveWithoutGrounding;

	public static string m_MissionJumpToLoadOnStart;

	public static GameRegion m_StartRegion;

	public static bool s_ForcedGC;

	public static bool s_ForcedGCVerbose;

	public static bool s_IsGameplaySuspended;

	public static bool s_IsAISuspended;

	public static bool s_UseSeparateBuilds;

	private static CultureInfo _003Cs_CurrentCulture_003Ek__BackingField;

	private static bool s_CurrentCultureSet;

	private static float s_ForcedGCDelay;

	private static float s_ForcedGCInterval;

	public static bool s_VerboseAllowedToSave;

	private static float s_SaveGameDelayTime;

	private static Camera m_MainCamera;

	private static Camera m_WeaponCamera;

	private static Camera m_ImageEffectCamera;

	private static Camera m_InspectModeCamera;

	private static Camera m_GlobalCamera;

	private static CameraGlobalRT m_CameraGlobalRT;

	private static Light m_InspectModeLight;

	private static vp_FPSCamera m_vpFPSCamera;

	private static vp_FPSPlayer m_vpFPSPlayer;

	private static CameraEffects m_CameraEffects;

	private static CameraStatusEffects m_CameraStatusEffects;

	private static GameObject m_PlayerObject;

	private static PlayerCameraAnim m_NewPlayerCameraAnim;

	private static PlayerAnimation m_NewPlayerAnimation;

	private static PlayerAnimationContainer m_playerAnimationContainer;

	private static DialogueStatesTable m_GlobalDialogueStatesTable;

	private static MissionObjectiveTable m_GlobalMissionObjectiveTable;

	private static AfflictionDefinitionTable m_GlobalAfflictionDefinitionTable;

	private static GameObject m_WeaponViewObject;

	private static bool m_ForceTrialMode;

	private static bool m_PausedWhenFocusLost;

	public static float m_GlobalTimeScale;

	public static Vector3 m_DefaultSpawnPos;

	public static Quaternion m_DefaultSpawnRot;

	public static string m_OverridenCauseOfDeath;

	private static TimeSpan m_ServerTimeOffset;

	public static Dictionary<string, bool> m_AsyncSceneLoadsInProgress;

	public static ThreadPriority m_LoadPriority;

	private static AuroraManager m_AuroraManager;

	private static AchievementManager m_AchievementManager;

	private static AiDifficultySettings m_AiDifficultySettings;

	private static BodyCarry m_BodyCarry;

	private static Burns m_Burns;

	private static BurnsElectric m_BurnsElectric;

	private static BloodLoss m_BloodLoss;

	private static BodyHarvestManager m_BodyHarvestManager;

	private static Breath m_Breath;

	private static BrokenRib m_BrokenRib;

	private static CabinFever m_CabinFever;

	private static Condition m_Condition;

	private static ConditionTableManager m_ConditionTableManager;

	private static DownsampleAurora m_DownsampleAurora;

	private static DynamicDecalsManager m_DynamicDecalsManager;

	private static Dysentery m_Dysentery;

	private static EffectPoolManager m_EffectPoolManager;

	private static EmergencyStim m_EmergencyStim;

	private static Encumber m_Encumber;

	private static EnergyBoost m_EnergyBoost;

	private static ExperienceModeManager m_ExperienceModeManager;

	private static Fatigue m_Fatigue;

	private static FireManager m_FireManager;

	private static FoodPoisoning m_FoodPoisoning;

	private static FootStepSounds m_FootStepSounds;

	private static Freezing m_Freezing;

	private static Frostbite m_Frostbite;

	private static Suffocating m_Suffocating;

	private static GameAudioManager m_GameAudioManager;

	private static HeatSourceManager m_HeatSourceManager;

	private static Headache m_Headache;

	private static Hunger m_Hunger;

	private static Hypothermia m_Hypothermia;

	private static Infection m_Infection;

	private static InfectionRisk m_InfectionRisk;

	private static IntestinalParasites m_IntestinalParasites;

	private static FallDamage m_FallDamage;

	private static FeatsManager m_FeatsManager;

	private static FeatNotify m_FeatNotify;

	private static FlyOver m_FlyOver;

	private static FootstepTrailManager m_FootstepTrailManager;

	private static GlobalParameters m_GlobalParameters;

	private static IceCrackingManager m_IceCrackingManager;

	private static InteractiveClothManager m_InteractiveClothManager;

	private static Inventory m_Inventory;

	private static Log m_Log;

	private static MissionServicesManager m_MissionServicesManager;

	private static MapDetailManager m_MapDetailManager;

	private static MusicEventManager m_MusicEventManager;

	private static PassTime m_PassTime;

	private static PlayerClimbRope m_PlayerClimbRope;

	private static PlayerGameStats m_PlayerGameStats;

	private static PlayerInVehicle m_PlayerInVehicle;

	private static PlayerInConstrainedCamera m_PlayerInConstrainedCamera;

	private static PlayerKnowledge m_PlayerKnowledge;

	private static PlayerManager m_PlayerManager;

	private static PlayerMovement m_PlayerMovement;

	private static PlayerSkills m_PlayerSkills;

	private static PlayerStruggle m_PlayerStruggle;

	private static PlayerStunned m_PlayerStunned;

	private static PlayerSwing m_PlayerSwing;

	private static PlayerVoice m_PlayerVoice;

	private static QualitySettingsManager m_QualitySettingsManager;

	private static RadialSpawnManager m_RadialSpawnManager;

	private static RenderTextureCameraManager m_RenderTextureCameraManager;

	private static Rest m_Rest;

	private static RumbleEffectManager m_RumbleEffectManager;

	private static ScentRanges m_ScentRanges;

	private static SkillNotify m_SkillNotify;

	private static SkillsManager m_SkillsManager;

	private static SnowPatchManager m_SnowPatchManager;

	private static SnowShelterManager m_SnowShelterManager;

	private static LeanToManager m_LeanToManager;

	private static RockCacheManager m_RockCacheManager;

	private static SpawnRegionManager m_SpawnRegionManager;

	private static SprainedAnkle m_SprainedAnkle;

	private static SprainedWrist m_SprainedWrist;

	private static SprainPain m_SprainPain;

	private static Sprains m_Sprains;

	private static Anxiety m_Anxiety;

	private static Fear m_Fear;

	private static ToxicFog m_ToxicFog;

	private static StartSettings m_StartSettings;

	private static StatsManager m_StatsManager;

	private static SandboxManager m_SandboxManager;

	private static StoryManager m_StoryManager;

	private static TerrainGrassModifier m_TerrainGrassModifier;

	private static TerrainRenderingManager m_TerrainRenderingManager;

	private static Thirst m_Thirst;

	private static TLD_TimelineDirector m_TimelineDirector;

	private static TimeOfDay m_TimeOfDay;

	private static TrustManager m_TrustManager;

	private static Weather m_Weather;

	private static WeatherTransition m_WeatherTransition;

	private static WellFed m_WellFed;

	private static Willpower m_Willpower;

	private static Wind m_Wind;

	private static WindZone m_WindZone;

	private static PackManager m_PackManager;

	private static AreaMarkupManager m_AreaMarkupManager;

	private static FastClothManager m_FastClothManager;

	private static DebugViewModeManager m_DebugViewModeManager;

	private static InvisibleEntityManager m_InvisibleEntityManager;

	private static ToxicFogManager m_ToxicFogManager;

	private static SprainProtection m_Sprainprotection;

	private static SteamPipeEffectManager m_SteamPipeEffectManager;

	private static SteamPipeValveManager m_SteamPipeValveManager;

	private static SteamPipeManager m_SteamPipeManager;

	private static PlayerCough m_PlayerCough;

	private static HighResolutionTimerManager m_HighResTimerManager;

	private static FontManager m_FontManager;

	private static NotificationFlagManager m_NotificationFlagManager;

	private static DamageProtection m_DamageProtection;

	private static GameObject m_Blueprints;

	private static GameObject m_InputSystems;

	private static GameObject m_Console;

	private GameObject m_ConditionSystems;

	private GameObject m_ConditionTableSystems;

	private GameObject m_EngineSystems;

	private GameObject m_EnvironmentSystems;

	private GameObject m_ExperienceModes;

	private GameObject m_FirstAidSystems;

	private GameObject m_GamePlaySystems;

	private GameObject m_PlayerSystems;

	private bool m_DoBurntHouseCheckNextFrame;

	private bool m_SetQualitySettingsForLoadedScene;

	private bool m_SetAudioModeForLoadedScene;

	private float m_HeatmapTimer;

	private static GameObject m_SteamSystems;

	private static GameObject m_EOSSystems;

	private static GameObject m_EffectPoolManagerObject;

	private static GameObject m_RumbleEffectManagerObject;

	private static bool m_FirstRun;

	private static bool m_HaveDefaultOptionsBeenSet;

	private static GameManager m_Instance;

	private static int m_SaveFrameDelay;

	private static bool m_InitialEditorSceneCheckComplete;

	private static bool s_AllowPhysicsSimulationControl;

	private static bool m_TempResolutionChangeRequested;

	private static SaveSlotInfo m_QuickLoadSlot;

	private static EpisodeTransferData m_EpisodeTransferData;

	private static bool s_PausedWhenFocusLost;

	public static CultureInfo s_CurrentCulture
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Sprains), Member = "Update")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetDelayedGameplayComponentInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsFrameValidToUpdate(GameplayComponent component)
	{
		return false;
	}

	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static float GetDeltaTime(GameplayComponent component)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static void RegisterDelayedComponent(GameplayComponent component, int frequency)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void RegisterDelayedComponents()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static void InitDelayedComponents()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static DelayedGameplayComponentInfo GetDelayedGameplayComponentInfo(GameplayComponent component)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void UpdateDelayedComponentsDeltaTime()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(SandboxConfig), Member = "GetRandomStartingRegion")]
	[Calls(Type = typeof(SandboxConfig), Member = "GetIndoorSpawn")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(StatsManager), Member = "Reset")]
	[Calls(Type = typeof(Panel_Log), Member = "Reset")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(Utils), Member = "SendGameStartAnalyticsEvent")]
	[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 37)]
	public void LaunchSandbox()
	{
	}

	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorBack")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnClickBack")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RegionLockedBySelectedMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public int GetNumFeatsForXPMode(ExperienceModeType xpMode)
	{
		return 0;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetFOVFromOptions")]
	[CalledBy(Type = typeof(Weather), Member = "IsMainMenu")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CallerCount(Count = 18)]
	public static bool IsMainMenuActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hunted2_endgame")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(Condition_StreamPipeMonitorStatus), Member = "OnInit")]
	[CalledBy(Type = typeof(Condition_InScene), Member = "OnCheck")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool IsActiveScene(string SceneName)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAiManager), Member = "InstantiateSubsystems")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void InstantiateSystems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void InstantiateInterfaceSystem()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void InstantiateInputSystem()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Initialize")]
	[Calls(Type = typeof(PlayerRichPresenceManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void InstantiateOnlineSystems()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public static void InstantiateStoryManager()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetGameState()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadScene")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void DestroyStoryManager()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static void InstantiateSandboxManager()
	{
	}

	[CalledBy(Type = typeof(PlayerLoopScript), Member = "EarlyUpdate_Internal")]
	[CalledBy(TypeFullName = "PlayerLoopScript.<>c", Member = "<Init>b__7_0")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EarlyUpdateAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void EarlyUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadScene")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static void DestroySandboxManager()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	[Calls(Type = typeof(GameManager), Member = "OutputSystemInfo")]
	[Calls(Type = typeof(PersistentDataPath), Member = "Init")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "Init")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(EpisodeManager), Member = "Init")]
	[Calls(Type = typeof(Utils), Member = "InitAssetBundles")]
	[Calls(Type = typeof(HDRManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(RegionManager), Member = "SceneIsRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "RefreshCache")]
	[Calls(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(GameManager), Member = "CacheComponents")]
	[Calls(Type = typeof(GameManager), Member = "CachePlayerComponents")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateEffectPoolManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateRumbleEffectManager")]
	[Calls(Type = typeof(ConsoleManager), Member = "Initialize")]
	[Calls(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 26)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAiManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(GearManager), Member = "Reset")]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Reset")]
	[Calls(Type = typeof(AuroraManager), Member = "Reset")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Init")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Reset")]
	[Calls(Type = typeof(HashSet<>), Member = "Clear")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Reset")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[Calls(Type = typeof(PlayableBehaviourFadeLight), Member = "Reset")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "Reset")]
	[Calls(Type = typeof(PlaceableManager), Member = "Reset")]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 72)]
	[CallsUnknownMethods(Count = 63)]
	private static void ResetLists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetDefaultOptionsAtStartup")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadProfile")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[Calls(Type = typeof(GameManager), Member = "UpdateTerrainSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[Calls(Type = typeof(GameManager), Member = "SetAudioModeForLoadedScene")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[Calls(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[Calls(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(GameManager), Member = "UpdatePaused")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "UpdateQueue")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "ShowSyncMessage")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "HideSyncMessage")]
	[Calls(Type = typeof(AssetBundleManager), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNotificationsInQueue")]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 21)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPC), Member = "FindAll")]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static void AllScenesLoaded()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[Calls(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[Calls(Type = typeof(BaseAiManager), Member = "DiposeBatchGroundRaycastHit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(EpisodeManager), Member = "Shutdown")]
	[Calls(Type = typeof(BaseAiManager), Member = "DiposeBatchGroundRaycastHit")]
	[Calls(Type = typeof(SplineManager), Member = "Dispose")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	private bool CanMigrateEnteringEpisode(Episode episode)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ForceGC()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MaybeForceGC()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestTempResolutionChange()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ReInitDefaultOptions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public void OnApplicationQuit()
	{
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool SaveGameCanBeLoaded(string slotName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetBootData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotTypeFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveIsCompatible")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool SaveGameCanBeLoaded(string slotName, out string saveErrorMessage)
	{
		saveErrorMessage = null;
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private static bool SaveShouldBePending()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void SaveGameAndDisplayHUDMessage()
	{
	}

	[CallerCount(Count = 21)]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SaveProfileAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SaveSettings")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateCacheAchievementInProfile")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SaveProfileSettingsAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAutosave")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(SaveGameSystem), Member = "ResetAutosaveTimer")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetOldestAutosaveName")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static void TriggerAutosaveAndDisplayHUDMessage()
	{
	}

	[CalledBy(TypeFullName = "Panel_SaveStory.<OnQuicksaveCoroutine>d__58", Member = "MoveNext")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteQuickSaveAction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	public static void TriggerQuicksaveAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteSaveNamed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void TriggerManualSaveAndDisplayHUDMessage(string saveName, string displayName)
	{
	}

	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CalledBy(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CalledBy(Type = typeof(Burns), Member = "BurnsStart")]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	[CalledBy(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[CalledBy(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[CalledBy(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CalledBy(Type = typeof(Infection), Member = "InfectionStart")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerExit")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void TriggerSurvivalSaveAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool ShouldPauseMoviePlayer()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Condition_CanSave), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetTrackedMission")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveExists")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DoAnyFSMsHaveInvalidTags")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 38)]
	public static bool AllowedToSave(SaveState state)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	public static bool AllowedToLoadActiveGame()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void DelaySaving(float delay)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void SaveGame()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(TypeFullName = "JumpManager.<OnSavingCoroutine>d__37", Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void ForceSaveGame()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStorySaveSlot")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CallerCount(Count = 4)]
	public static bool LoadSaveGameSlot(SaveSlotInfo ssi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetBootData")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotTypeFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveIsCompatible")]
	[Calls(Type = typeof(SaveGameSystem), Member = "ResetAutosaveTimer")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static bool LoadSaveGameSlot(string slotName, int saveChangelistVersion)
	{
		return false;
	}

	[CalledBy(Type = typeof(InputManager), Member = "ExecuteQuickLoadAction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetNewestSaveSlotForActiveGame")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 18)]
	public static void LoadActiveSaveGame()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ReloadSlot")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[Calls(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool LoadGame(SaveSlotInfo ssi)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "OnClickContinueToNextEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "SetupTransferData")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetPanel")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryDestroyPanel")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void ContinueToNextEpisode()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void SetupTransferData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void ApplyTransferData()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	private static void OnLoadGameCallback()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private static void OnLoadStoryFromEmptyCallback()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void FadeOutSceneAudio()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(LoadingZone), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	public static void LoadScene(string sceneName, string sceneSaveFilenameCurrent)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void LoadSceneWithLoadingScreen(string sceneName)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(GameManager), Member = "ChooseConditionalLoadMode")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 25)]
	public static void LoadSceneAsynchronously(string sceneName)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ChooseConditionalLoadMode(string rootScene, bool isStory, List<AsyncOperation> asyncOps)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentChildEntryNoCase")]
	[Calls(Type = typeof(SceneMapping), Member = "ChildExperienceModeMatches")]
	[Calls(Type = typeof(SceneManager), Member = "ContainsLayer")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	public static void MaybeLateLoadMissionLayers()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ChooseConditionalLoadMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentChildEntryNoCase")]
	[Calls(Type = typeof(SceneMapping), Member = "ChildExperienceModeMatches")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameManager), Member = "ShouldLoadConditionalScene")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 40)]
	public static void LoadModeConditionalScenesMapped(string rootScene, bool isStory, List<AsyncOperation> asyncOps)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "ContainsLayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ShouldLoadConditionalScene(SceneMapping.ChildSceneEntry entry)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "ChooseConditionalLoadMode")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(GameManager), Member = "SceneNotCompatibleWithMode")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 29)]
	public static void LoadModeConditionalScenes(string sceneName, bool isStory, List<AsyncOperation> asyncOps)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetVersionString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool SaveIsBlockedDueToRestoreGame()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SceneUnloaded")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public static void AddAsyncLoadRequest(string sceneName, List<AsyncOperation> asyncOps, bool additive)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private static bool AddAsyncSceneLoadWithPattern(string baseSceneName, string pattern, List<AsyncOperation> asyncOps, bool suppressError = false)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadMainMenu()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LoadBoot()
	{
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static void OnGameQuit()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadBoot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public static void LoadScene(string sceneName)
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(LoadingZone), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string StripOptFromSceneName(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool AreControlsLockedForIntro()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AllowInteractionWithObjects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInElevator")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static bool ControlsLocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool IsMovementLockedBecauseOfLantern()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsMoveInputUnblocked()
	{
		return false;
	}

	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MaybeBlockMoveInputUntilReleased(MonoBehaviour context)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GameManager Instance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Camera GetGlobalCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Camera GetMainCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Camera GetWeaponCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Camera GetImageEffectCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Camera GetInspectModeCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Light GetInspectModeLight()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static vp_FPSCamera GetVpFPSCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static vp_FPSPlayer GetVpFPSPlayer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static CameraEffects GetCameraEffects()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static CameraStatusEffects GetCameraStatusEffects()
	{
		return null;
	}

	[CallerCount(Count = 176)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject GetPlayerObject()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerCameraAnim GetNewPlayerCameraAnim()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GameObject GetWeaponView()
	{
		return null;
	}

	[CallerCount(Count = 215)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Transform GetPlayerTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GameObject GetTopLevelCharacterFpsPlayer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GameObject GetBlueprints()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AiDifficultySettings GetAiDifficultySettings()
	{
		return null;
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static UniStormWeatherSystem GetUniStorm()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AuroraManager GetAuroraManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AchievementManager GetAchievementManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BodyCarry GetBodyCarryComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Burns GetBurnsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BurnsElectric GetBurnsElectricComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BloodLoss GetBloodLossComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BodyHarvestManager GetBodyHarvestManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Breath GetBreathComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static BrokenRib GetBrokenRibComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static CabinFever GetCabinFeverComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Condition GetConditionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ConditionTableManager GetConditionTableManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DialogueStatesTable GetDialogueStatesTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static MissionObjectiveTable GetMissionObjectiveTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AfflictionDefinitionTable GetAfflictionDefinitionTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DownsampleAurora GetDownsampleAurora()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DynamicDecalsManager GetDynamicDecalsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Dysentery GetDysenteryComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static EffectPoolManager GetEffectPoolManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static EmergencyStim GetEmergencyStimComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Encumber GetEncumberComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static EnergyBoost GetEnergyBoostComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ExperienceModeManager GetExperienceModeManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Fatigue GetFatigueComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FireManager GetFireManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FoodPoisoning GetFoodPoisoningComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FootStepSounds GetFootStepSoundsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Freezing GetFreezingComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Frostbite GetFrostbiteComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Suffocating GetSuffocatingComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GameAudioManager GetGameAudioManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static HeatSourceManager GetHeatSourceManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Headache GetHeadacheComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Hunger GetHungerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Hypothermia GetHypothermiaComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Infection GetInfectionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static InfectionRisk GetInfectionRiskComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static IntestinalParasites GetIntestinalParasitesComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FallDamage GetFallDamageComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_BookSmarts GetFeatBookSmarts()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_ColdFusion GetFeatColdFusion()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_EfficientMachine GetFeatEfficientMachine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_FireMaster GetFeatFireMaster()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_FreeRunner GetFeatFreeRunner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_SnowWalker GetFeatSnowWalker()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_ExpertTrapper GetFeatExpertTrapper()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_StraightToHeart GetFeatStraightToHeart()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_BlizzardWalker GetFeatBlizzardWalker()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Feat_NightWalker GetFeatNightWalker()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FeatsManager GetFeatsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FeatNotify GetFeatNotify()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FlyOver GetFlyOverComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FootstepTrailManager GetFootstepTrailManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GlobalParameters GetGlobalParameters()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static IceCrackingManager GetIceCrackingManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static InteractiveClothManager GetInteractiveClothManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Inventory GetInventoryComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Log GetLogComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static MissionServicesManager GetMissionServicesManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PassTime GetPassTime()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static MapDetailManager GetMapDetailManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static MusicEventManager GetMusicEventManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerClimbRope GetPlayerClimbRopeComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerGameStats GetPlayerGameStatsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerInVehicle GetPlayerInVehicle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerInConstrainedCamera GetPlayerInConstrainedCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerKnowledge GetPlayerKnowledgeComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerAnimation GetPlayerAnimationComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerAnimationContainer GetPlayerAnimationContainer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerManager GetPlayerManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerMovement GetPlayerMovementComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerSkills GetPlayerSkillsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerStruggle GetPlayerStruggleComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerStunned GetPlayerStunnedComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerSwing GetPlayerSwingComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerVoice GetPlayerVoiceComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static QualitySettingsManager GetQualitySettingsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static RadialSpawnManager GetRadialSpawnManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static RenderTextureCameraManager GetRenderTextureCameraManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Rest GetRestComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static RumbleEffectManager GetRumbleEffectManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ScentRanges GetSceneRanges()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SandboxManager GetSandboxManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static StoryManager GetStoryManager()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Archery GetSkillArchery()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "IsCarcassTooFrozenToQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_CarcassHarvesting GetSkillCarcassHarvesting()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_ClothingRepair GetSkillClothingRepair()
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Cooking GetSkillCooking()
	{
		return null;
	}

	[CalledBy(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CalledBy(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshBaseSkillLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshTinderLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "CalclateFireStartSuccess")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerCalculateFireStartTime")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Firestarting GetSkillFireStarting()
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RollForLineBreak")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_IceFishing GetSkillIceFishing()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Rifle GetSkillRifle()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilPitch")]
	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilYaw")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnRevolverShotPercent")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Revolver GetSkillRevolver()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "DetermineConditionImprovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Gunsmithing GetSkillGunsmithing()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SkillNotify GetSkillNotify()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SkillsManager GetSkillsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SnowPatchManager GetSnowPatchManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SnowShelterManager GetSnowShelterManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static LeanToManager GetLeanToManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static RockCacheManager GetRockCacheManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SpawnRegionManager GetSpawnRegionManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SprainedAnkle GetSprainedAnkleComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SprainedWrist GetSprainedWristComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SprainPain GetSprainPainComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Sprains GetSprainsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Anxiety GetAnxietyComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Fear GetFearComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ToxicFog GetToxicFogComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static StartSettings GetStartSettingsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static StatsManager GetStatsManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TerrainGrassModifier GetTerrainGrassModifier()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TerrainRenderingManager GetTerrainRenderingManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Thirst GetThirstComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TLD_TimelineDirector GetPlayerTimelineDirector()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TimeOfDay GetTimeOfDayComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TrustManager GetTrustManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Weather GetWeatherComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static WeatherTransition GetWeatherTransitionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static WellFed GetWellFedComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Willpower GetWillpowerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Wind GetWindComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static WindZone GetWindZone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PackManager GetPackManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AreaMarkupManager GetAreaMarkupManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FastClothManager GetFastClothManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DebugViewModeManager GetDebugViewModeManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static InvisibleEntityManager GetInvisibleEntityManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static ToxicFogManager GetToxicFogManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SprainProtection GetSprainProtectionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SteamPipeEffectManager GetSteamPipeEffectManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SteamPipeValveManager GetSteamPipeValveManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SteamPipeManager GetSteamPipeManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static PlayerCough GetPlayerCough()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static HighResolutionTimerManager GetHighResolutionTimerManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static FontManager GetFontManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static NotificationFlagManager GetNotificationFlagManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static DamageProtection GetDamageProtection()
	{
		return null;
	}

	[CallerCount(Count = 139)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsStoryMode()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static CameraGlobalRT GetCameraGlobalRT()
	{
		return null;
	}

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Camera GetCurrentCamera()
	{
		return null;
	}

	[CallerCount(Count = 207)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static CustomExperienceMode GetCustomMode()
	{
		return null;
	}

	[CallerCount(Count = 59)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool InCustomMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(TypeFullName = "InternalUserReport.<>c__DisplayClass7_0", Member = "<Send>b__1")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsPlayingCustomXPGame()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[Calls(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[Calls(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "ProcessTimeGatedUnlocks")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdatePaused()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "MaybeSwitchRenderingPath")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "HasFadedInOnStart")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPaused")]
	[Calls(Type = typeof(GameManager), Member = "ShouldPauseMoviePlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "FadeInAudioOnSceneStart")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[Calls(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[Calls(Type = typeof(InputManager), Member = "ProcessTimeGatedUnlocks")]
	[Calls(Type = typeof(CameraFade), Member = "UpdateFade")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(GearManager), Member = "DestroyMarkedObjects")]
	[Calls(Type = typeof(GearManager), Member = "UpdateItems")]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[Calls(Type = typeof(BreakDown), Member = "UpdateAll")]
	[Calls(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Harvestable), Member = "UpdateHarvesting")]
	[Calls(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[Calls(Type = typeof(VehicleDoor), Member = "UpdateDoorInProgress")]
	[Calls(Type = typeof(TodMaterial), Member = "UpdateAll")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[Calls(Type = typeof(BaseAiManager), Member = "Update")]
	[Calls(Type = typeof(NPC), Member = "UpdateAll")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 35)]
	private void UpdateNotPaused()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 173)]
	private void CacheComponents()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void CachePlayerComponents()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameManager), Member = "DestroyInventoryItems")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 39)]
	private void InstantiatePlayerObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static void RestorePlayerTransformParent()
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "MaybeClearCache")]
	[CalledBy(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsOutDoorsScene(string sceneName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetMapNameOfScene(string sceneName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int GetResolutionOverrideForScene(string sceneName)
	{
		return 0;
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static void MaybeSwitchRenderingPath()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Terrain), Member = "set_collectDetailPatches")]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private static void UpdateTerrainSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private static void InstantiateSwitchKeyboard()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Light), Member = "get_shadows")]
	[Calls(Type = typeof(Light), Member = "set_shadows")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void AdjustShadowSettings()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void CancelPendingSave()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsTrialMode()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void PauseForLoading()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool ToggleTrialMode()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public static void OnBuyNow()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string TrialModeTimeRemaining()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsStorySaveActive()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void DoExitToMainMenu()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	[CalledBy(Type = typeof(GearItem), Member = "RollGearCondition")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static int GetRandomSeed(int seed)
	{
		return 0;
	}

	[CalledBy(Type = typeof(GearItem), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CalledBy(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(WaterSource), Member = "Update")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	public static bool RollSpawnChance(GameObject go, float spawnChance)
	{
		return false;
	}

	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool HasPlayerObject()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private GameObject InstantiateSystem(GameObject prefab, Vector3 pos, Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(BaseAiManager), Member = "InstantiateSubsystems")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void InstantiateAiSystems(Vector3 pos, Transform parent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void InstantiateConsole()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void InstantiateUniStorm()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void InstantiateEffectPoolManager()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "LoadEffects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void InstantiateRumbleEffectManager()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void DestroyInventoryItems(GameObject parent)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void SetGameVersionString(string versionString)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public int ExtractChangelistFromVersion(string versionString)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	private void LookupGameVersionString()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private string ReadVersionFile()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 123)]
	private void OutputSystemInfo()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool SceneNotCompatibleWithMode(bool isStory, string sceneName)
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 24)]
	private void LoadSlotOnStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MigrateSlotOnStart()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetAudioModeForLoadedScene()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void PostMigrationDestoryLitFlareOrTorch()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleCheckpointSaveRequest()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static DateTime ValidateTime()
	{
		return default(DateTime);
	}

	[CalledBy(Type = typeof(Notifications), Member = "ParseJson")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.DateTimeParse", Member = "TryParse")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetServerTime(string dateTimeAsIso8601)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ValidateTime")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetTransitionToDay")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static DateTime GetServerTime()
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsServerTimeValid()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestSaveCheckpoint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetAllowPhysicsSimulationControl()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetAllowPhysicsSimulationControl(bool allow)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetPhysicsAutoSimulationEnabled(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CalledBy(Type = typeof(NPCCondition), Member = "HandleDeath")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(Action_FailMission), Member = "OnExecute")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ClearRequests")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	[Calls(Type = typeof(InterfaceManager), Member = "LoadPanel")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 36)]
	public static void HandlePlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_CurrentCulture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static void InitializeCulture()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void DestroyPlayerObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DebugNotAllowedToLoad(string message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DebugNotAllowedToSave(string message)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "OnNameStoryConfirmed")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CallerCount(Count = 2)]
	public static void RelaunchBuildForNewGame(string saveName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RelaunchBuildForMainMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void RelaunchBuildToLoadSave(string savefile)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void PauseWhenFocusLost(bool focusLost)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GameManager()
	{
	}
}
