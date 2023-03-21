using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(Sprains), Member = "Update")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetDelayedGameplayComponentInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetDelayedGameplayComponentInfo")]
	public static bool IsFrameValidToUpdate(GameplayComponent component)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	public static float GetDeltaTime(GameplayComponent component)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	private static void RegisterDelayedComponent(GameplayComponent component, int frequency)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void RegisterDelayedComponents()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enum), Member = "GetNames")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 11)]
	private static void InitDelayedComponents()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	private static DelayedGameplayComponentInfo GetDelayedGameplayComponentInfo(GameplayComponent component)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private static void UpdateDelayedComponentsDeltaTime()
	{
	}

	[Calls(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[Calls(Type = typeof(Utils), Member = "SendGameStartAnalyticsEvent")]
	[Calls(Type = typeof(GameManager), Member = "IsPlayingCustomXPGame")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[Calls(Type = typeof(SandboxConfig), Member = "GetIndoorSpawn")]
	[Calls(Type = typeof(Panel_Log), Member = "Reset")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(SandboxConfig), Member = "GetRandomStartingRegion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpecialEvent), Member = "MatchesExperienceMode")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(StatsManager), Member = "Reset")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	public void LaunchSandbox()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorBack")]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnClickBack")]
	[CallsUnknownMethods(Count = 1)]
	public static bool RegionLockedBySelectedMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatActionButton")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnToggleFeatActive")]
	public int GetNumFeatsForXPMode(ExperienceModeType xpMode)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	[CalledBy(Type = typeof(StartGear), Member = "AddAllToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsActive")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "RefreshHudDisplayMode")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateLastLocations")]
	[CalledBy(Type = typeof(Weather), Member = "IsMainMenu")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetFOVFromOptions")]
	[CallerCount(Count = 18)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	public static bool IsMainMenuActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_InScene), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_StreamPipeMonitorStatus), Member = "OnInit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hunted2_endgame")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	public static bool IsActiveScene(string SceneName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(BaseAiManager), Member = "InstantiateSubsystems")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	private void InstantiateSystems()
	{
	}

	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void InstantiateInterfaceSystem()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CallsUnknownMethods(Count = 1)]
	public static void InstantiateInputSystem()
	{
	}

	[Calls(Type = typeof(PlayerRichPresenceManager), Member = "Initialize")]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(AchievementPlatformManager), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void InstantiateOnlineSystems()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Story), Member = "DeserializeStoryManagerCallback")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	public static void InstantiateStoryManager()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ResetGameState()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DestroyStoryManager()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	public static void InstantiateSandboxManager()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PlayerLoopScript._003C_003Ec), Member = "<Init>b__7_0")]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "EarlyUpdate_Internal")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EarlyUpdateAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void EarlyUpdate()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public static void DestroySandboxManager()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(GameManager), Member = "CacheComponents")]
	[Calls(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateEffectPoolManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateRumbleEffectManager")]
	[Calls(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "RefreshCache")]
	[Calls(Type = typeof(ConsoleManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "CachePlayerComponents")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(RegionManager), Member = "SceneIsRegion")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	[Calls(Type = typeof(GameManager), Member = "OutputSystemInfo")]
	[Calls(Type = typeof(PersistentDataPath), Member = "Init")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "Init")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(EpisodeManager), Member = "Init")]
	[Calls(Type = typeof(Utils), Member = "InitAssetBundles")]
	[Calls(Type = typeof(Animator), Member = "StringToHash")]
	[Calls(Type = typeof(HDRManager), Member = "Initialize")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(LoadSceneParent), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Init")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlayableBehaviourFadeLight), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "Reset")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlaceableManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 75)]
	[Calls(Type = typeof(BaseAiManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearManager), Member = "Reset")]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AuroraManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private static void ResetLists()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadProfile")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(CameraFade), Member = "BashFadeAlpha")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadProfile")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "SetDefaultOptionsAtStartup")]
	[Calls(Type = typeof(GameManager), Member = "UpdateTerrainSettings")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	public void Start()
	{
	}

	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "UpdateQueue")]
	[Calls(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(GameManager), Member = "UpdatePaused")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "MaybeShowNotificationsInQueue")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "HideSyncMessage")]
	[Calls(Type = typeof(AssetBundleManager), Member = "Update")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "ShowSyncMessage")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(SceneManager), Member = "IsLoading")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[Calls(Type = typeof(GameManager), Member = "SetAudioModeForLoadedScene")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[Calls(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NPC), Member = "FindAll")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	public static void AllScenesLoaded()
	{
	}

	[Calls(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(BaseAiManager), Member = "DiposeBatchGroundRaycastHit")]
	[Calls(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(EpisodeManager), Member = "Shutdown")]
	[Calls(Type = typeof(BaseAiManager), Member = "DiposeBatchGroundRaycastHit")]
	[Calls(Type = typeof(SplineManager), Member = "Dispose")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	private bool CanMigrateEnteringEpisode(Episode episode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GC), Member = "Collect")]
	public static void ForceGC()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public static void MaybeForceGC()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RequestTempResolutionChange()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 8)]
	public static string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ReInitDefaultOptions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CallsUnknownMethods(Count = 6)]
	public void OnApplicationQuit()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStoryForMigration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStory")]
	public static bool SaveGameCanBeLoaded(string slotName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotTypeFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetBootData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveIsCompatible")]
	public static bool SaveGameCanBeLoaded(string slotName, out string saveErrorMessage)
	{
		saveErrorMessage = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionsActiveActionCount")]
	private static bool SaveShouldBePending()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	private static void SaveGameAndDisplayHUDMessage()
	{
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[CallsUnknownMethods(Count = 1)]
	public static void SaveProfileAndDisplayHUDMessage()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AchievementManager), Member = "UpdateCacheAchievementInProfile")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "SaveSettings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	public static void SaveProfileSettingsAndDisplayHUDMessage()
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "GetOldestAutosaveName")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAutosave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(SaveGameSystem), Member = "ResetAutosaveTimer")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	public static void TriggerAutosaveAndDisplayHUDMessage()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteQuickSaveAction")]
	[CalledBy(Type = typeof(Panel_SaveStory._003COnQuicksaveCoroutine_003Ed__58), Member = "MoveNext")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	public static void TriggerQuicksaveAndDisplayHUDMessage()
	{
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteSaveNamed")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetUserDefinedSlotName")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	public static void TriggerManualSaveAndDisplayHUDMessage(string saveName, string displayName)
	{
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	public static void TriggerSurvivalSaveAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePause")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "CheckForPause")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MoviePlayer), Member = "Update")]
	public static bool ShouldPauseMoviePlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "DoAnyFSMsHaveInvalidTags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Condition_CanSave), Member = "OnCheck")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveExists")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveExists")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetTrackedMission")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	public static bool AllowedToSave(SaveState state)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	public static bool AllowedToLoadActiveGame()
	{
		return default(bool);
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

	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetBaseNameForSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static void ForceSaveGame()
	{
	}

	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CallerCount(Count = 4)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadStorySaveSlot")]
	public static bool LoadSaveGameSlot(SaveSlotInfo ssi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveIsCompatible")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotTypeFromName")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetBootData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "ResetAutosaveTimer")]
	public static bool LoadSaveGameSlot(string slotName, int saveChangelistVersion)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteQuickLoadAction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetNewestSaveSlotForActiveGame")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	public static void LoadActiveSaveGame()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ReloadSlot")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	public static bool LoadGame(SaveSlotInfo ssi)
	{
		return default(bool);
	}

	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "OnClickContinueToNextEpisode")]
	[CalledBy(Type = typeof(Panel_EpisodeContinue), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(Panel_EpisodeSelection), Member = "GetEpisodeMenuItem")]
	[Calls(Type = typeof(GameManager), Member = "SetupTransferData")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetNextEpisode")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	public static void ContinueToNextEpisode()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private static void SetupTransferData()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	private static void ApplyTransferData()
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private static void OnLoadGameCallback()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	private static void OnLoadStoryFromEmptyCallback()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	public static void FadeOutSceneAudio()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(LoadingZone), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	public static void LoadScene(string sceneName, string sceneSaveFilenameCurrent)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	[Calls(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	public static void LoadSceneWithLoadingScreen(string sceneName)
	{
	}

	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(GameManager), Member = "ChooseConditionalLoadMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CallerCount(Count = 2)]
	public static void LoadSceneAsynchronously(string sceneName)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[Calls(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static void ChooseConditionalLoadMode(string rootScene, bool isStory, List<AsyncOperation> asyncOps)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(SceneMapping), Member = "ChildExperienceModeMatches")]
	[Calls(Type = typeof(SceneManager), Member = "ContainsLayer")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentChildEntryNoCase")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	public static void MaybeLateLoadMissionLayers()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CalledBy(Type = typeof(GameManager), Member = "ChooseConditionalLoadMode")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "ShouldLoadConditionalScene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentChildEntryNoCase")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(SceneMapping), Member = "ChildExperienceModeMatches")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentChildEntryNoCase")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SceneMapping), Member = "ChildExperienceModeMatches")]
	public static void LoadModeConditionalScenesMapped(string rootScene, bool isStory, List<AsyncOperation> asyncOps)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "ContainsLayer")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool ShouldLoadConditionalScene(SceneMapping.ChildSceneEntry entry)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(GameManager), Member = "ChooseConditionalLoadMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetCurrentSaveSlotInfo")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(GameManager), Member = "SceneNotCompatibleWithMode")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
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
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLighting")]
	[CalledBy(Type = typeof(GameManager), Member = "AddAsyncSceneLoadWithPattern")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenesMapped")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(BatchLightingCapture), Member = "CaptureLightingStory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MissionServicesManager), Member = "SceneUnloaded")]
	public static void AddAsyncLoadRequest(string sceneName, List<AsyncOperation> asyncOps, bool additive)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	private static bool AddAsyncSceneLoadWithPattern(string baseSceneName, string pattern, List<AsyncOperation> asyncOps, bool suppressError = false)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnloadActiveEpisode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	public static void LoadMainMenu()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void LoadBoot()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	public static void OnGameQuit()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadBoot")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public static void LoadScene(string sceneName)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CalledBy(Type = typeof(LoadingZone), Member = "LoadLevelWhenFadeOutComplete")]
	[CalledBy(Type = typeof(LoadScene), Member = "LoadLevelWhenFadeOutComplete")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public static string StripOptFromSceneName(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsMainMenuActive")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static bool AreControlsLockedForIntro()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AllowInteractionWithObjects")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInElevator")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public static bool ControlsLocked()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool IsMovementLockedBecauseOfLantern()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsMoveInputUnblocked()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static GameObject GetWeaponView()
	{
		return null;
	}

	[CallerCount(Count = 215)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static FeatsManager GetFeatsManager()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static PlayerGameStats GetPlayerGameStatsComponent()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetBleedOutMinutes")]
	public static Skill_Archery GetSkillArchery()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassTooFrozenToQuarterMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "IsCarcassTooFrozenToQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	public static Skill_CarcassHarvesting GetSkillCarcassHarvesting()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	public static Skill_ClothingRepair GetSkillClothingRepair()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	public static Skill_Cooking GetSkillCooking()
	{
		return null;
	}

	[CalledBy(Type = typeof(FireManager), Member = "CalclateFireStartSuccess")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerCalculateFireStartTime")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshTinderLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshList")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshBaseSkillLabel")]
	[CalledBy(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	public static Skill_Firestarting GetSkillFireStarting()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RollForLineBreak")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	public static Skill_IceFishing GetSkillIceFishing()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	public static Skill_Rifle GetSkillRifle()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnRevolverShotPercent")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "GetFleeChanceOnHitPercent")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilYaw")]
	[CalledBy(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilPitch")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	public static Skill_Revolver GetSkillRevolver()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "DetermineConditionImprovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallsUnknownMethods(Count = 1)]
	public static Skill_Gunsmithing GetSkillGunsmithing()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static TimeOfDay GetTimeOfDayComponent()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static DamageProtection GetDamageProtection()
	{
		return null;
	}

	[CallerCount(Count = 139)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static bool IsStoryMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static CameraGlobalRT GetCameraGlobalRT()
	{
		return null;
	}

	[CallerCount(Count = 35)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public static Camera GetCurrentCamera()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallerCount(Count = 207)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static CustomExperienceMode GetCustomMode()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 59)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static bool InCustomMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(StatsManager), Member = "MaybeUpdateAllTimeBestStat")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(InternalUserReport._003C_003Ec__DisplayClass7_0), Member = "<Send>b__1")]
	[CalledBy(Type = typeof(Feat), Member = "ShouldBlockIncrement")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	public static bool IsPlayingCustomXPGame()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "ProcessTimeGatedUnlocks")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[CallerCount(Count = 1)]
	private void UpdatePaused()
	{
	}

	[Calls(Type = typeof(BreakDown), Member = "UpdateAll")]
	[Calls(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Harvestable), Member = "UpdateHarvesting")]
	[Calls(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[Calls(Type = typeof(VehicleDoor), Member = "UpdateDoorInProgress")]
	[Calls(Type = typeof(TodMaterial), Member = "UpdateAll")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(BearHuntRedux), Member = "UpdateMission")]
	[Calls(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[Calls(Type = typeof(BaseAiManager), Member = "Update")]
	[Calls(Type = typeof(NPC), Member = "UpdateAll")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(GearManager), Member = "DestroyMarkedObjects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GameManager), Member = "MaybeSwitchRenderingPath")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GearManager), Member = "UpdateItems")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPaused")]
	[Calls(Type = typeof(GameManager), Member = "ShouldPauseMoviePlayer")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[Calls(Type = typeof(GameAudioManager), Member = "FadeInAudioOnSceneStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "HasFadedInOnStart")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[Calls(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[Calls(Type = typeof(InputManager), Member = "ProcessTimeGatedUnlocks")]
	[Calls(Type = typeof(CameraFade), Member = "UpdateFade")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	private void UpdateNotPaused()
	{
	}

	[CallsUnknownMethods(Count = 173)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 108)]
	private void CacheComponents()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	private void CachePlayerComponents()
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(GameManager), Member = "DestroyInventoryItems")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InstantiatePlayerObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 5)]
	public static void RestorePlayerTransformParent()
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "MaybeClearCache")]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static bool IsOutDoorsScene(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SceneMapping), Member = "GetParentSceneEntry")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public static string GetMapNameOfScene(string sceneName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static int GetResolutionOverrideForScene(string sceneName)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 6)]
	private static void MaybeSwitchRenderingPath()
	{
	}

	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Terrain), Member = "set_collectDetailPatches")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
	private static void UpdateTerrainSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private static void InstantiateSwitchKeyboard()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Light), Member = "set_shadows")]
	[Calls(Type = typeof(Light), Member = "get_shadows")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void AdjustShadowSettings()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	public static void CancelPendingSave()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	public static bool IsTrialMode()
	{
		return default(bool);
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
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void OnBuyNow()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static string TrialModeTimeRemaining()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsStorySaveActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DoExitToMainMenu()
	{
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[CalledBy(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	[CalledBy(Type = typeof(GearItem), Member = "RollGearCondition")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(RandomSpawnObject), Member = "ActivateRandomObject")]
	[CalledBy(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetRandomSeed(int seed)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(WaterSource), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "RollSpawnChance")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	public static bool RollSpawnChance(GameObject go, float spawnChance)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	public static bool HasPlayerObject()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private GameObject InstantiateSystem(GameObject prefab, Vector3 pos, Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(BaseAiManager), Member = "InstantiateSubsystems")]
	[CallsUnknownMethods(Count = 1)]
	private void InstantiateAiSystems(Vector3 pos, Transform parent)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void InstantiateConsole()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void InstantiateUniStorm()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void InstantiateEffectPoolManager()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "LoadEffects")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 6)]
	private void InstantiateRumbleEffectManager()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void DestroyInventoryItems(GameObject parent)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[CallsUnknownMethods(Count = 7)]
	private void SetGameVersionString(string versionString)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	public int ExtractChangelistFromVersion(string versionString)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	private void LookupGameVersionString()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private string ReadVersionFile()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 123)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void OutputSystemInfo()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadModeConditionalScenes")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static bool SceneNotCompatibleWithMode(bool isStory, string sceneName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void LoadSlotOnStart()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	private void MigrateSlotOnStart()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	private void SetAudioModeForLoadedScene()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	private void PostMigrationDestoryLitFlareOrTorch()
	{
	}

	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void HandleCheckpointSaveRequest()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "DoSaftyChecksOnCurrentState")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	[Calls(Type = typeof(DateTime), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetServerTime")]
	public static DateTime ValidateTime()
	{
		return default(DateTime);
	}

	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Notifications), Member = "ParseJson")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.DateTimeParse), Member = "TryParse")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local")]
	public static void SetServerTime(string dateTimeAsIso8601)
	{
	}

	[CalledBy(Type = typeof(SpecialEvent), Member = "IsActive")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "GetCurrentDayNumber")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(GameManager), Member = "ValidateTime")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetTransitionToDay")]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow")]
	[CalledBy(Type = typeof(GameManager), Member = "ValidateTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	public static DateTime GetServerTime()
	{
		return default(DateTime);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsServerTimeValid()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void RequestSaveCheckpoint()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetAllowPhysicsSimulationControl()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetAllowPhysicsSimulationControl(bool allow)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	public static void SetPhysicsAutoSimulationEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(Action_FailMission), Member = "OnExecute")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(NPCCondition), Member = "HandleDeath")]
	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(GameManager), Member = "CancelPendingSave")]
	[Calls(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathString")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(Panel_TutorialPopup), Member = "ClearRequests")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Log), Member = "EnableDeathView")]
	public static void HandlePlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(Thread), Member = "set_CurrentCulture")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	public static void InitializeCulture()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "ContinueToNextEpisode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	public static void DestroyPlayerObject()
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DebugNotAllowedToLoad(string message)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void DebugNotAllowedToSave(string message)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CalledBy(Type = typeof(Panel_ChooseEpisodeExperience), Member = "OnNameStoryConfirmed")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static void RelaunchBuildForNewGame(string saveName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[CallsUnknownMethods(Count = 1)]
	public static void RelaunchBuildForMainMenu()
	{
	}

	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(Utils), Member = "QuitAndRunApplication")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void RelaunchBuildToLoadSave(string savefile)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
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
