using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using TLD.Audio;
using TLD.Electrostatic;
using TLD.Gameplay;
using TLD.Gameplay.Condition;
using TLD.Gear;
using TLD.OptionalContent;
using TLD.Platform;
using TLD.Scenes;
using TLD.Serialization;
using TLD.Stats;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<AsyncOperationHandle<RegionSpecification>> _003C_003E9__294_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(RegionSpecification), Member = "MaybeUnlock")]
		[CallerCount(Count = 0)]
		internal void _003CLoadSceneAsynchronously_003Eb__294_0(AsyncOperationHandle<RegionSpecification> op)
		{
		}
	}

	public GameObject m_AiDifficultySettingsPrefab;

	public GameObject m_AiSubsystemsPrefab;

	public GameObject m_ConditionSystemsPrefab;

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

	public ConditionTable m_ConditionTable;

	public DialogueStatesTable m_DialogueStatesTable;

	public MissionObjectiveTable m_MissionObjectiveTable;

	public AfflictionDefinitionTable m_AfflictionDefinitionTable;

	public const int NUM_SANDBOX_SAVE_SLOTS = 5;

	public const int NUM_CHALLENGE_SAVE_SLOTS = 5;

	public const int NUM_STORY_SAVE_SLOTS = 6;

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

	public static int m_ActiveSceneResolutionOverride;

	public static bool m_Borderless;

	public static bool m_CurrentEpisodeCompleted;

	public static bool m_SuppressWeaponAim;

	public static bool m_PauseAudioWithGame;

	public static bool m_SkipFadeOnNextLoad;

	public static bool m_AllowSaveWithoutGrounding;

	public static string m_MissionJumpToLoadOnStart;

	public static SceneSet m_ActiveSceneSet;

	public static SceneSet m_LastOutdoorSceneSet;

	public static RegionSpecification m_StartRegion;

	public static string m_FallbackRegion;

	public static bool s_ForcedGC;

	public static bool s_ForcedGCVerbose;

	public static bool s_IsGameplaySuspended;

	public static bool s_IsAISuspended;

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

	private static InsomniaManager m_InsomniaManager;

	private static GameObject m_InputSystems;

	private static GameObject m_Console;

	private GameObject m_ConditionSystems;

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

	private static bool m_HasCalledInitializeUser;

	private static GameManager m_Instance;

	private static int m_SaveFrameDelay;

	private static bool m_InitialEditorSceneCheckComplete;

	private static bool s_AllowPhysicsSimulationControl;

	private static bool m_TempResolutionChangeRequested;

	private static SaveSlotInfo m_QuickLoadSlot;

	private static EpisodeTransferData m_EpisodeTransferData;

	private static bool s_PausedWhenFocusLost;

	private static DelayedGameplayComponentInfo[] s_DelayedGameplayComponentInfos;

	public const string BOOT = "Boot";

	public const string EMPTY = "Empty";

	public const string MAIN_MENU = "MainMenu";

	private static bool s_ActiveIsBoot;

	private static bool s_ActiveIsEmpty;

	private static bool s_ActiveIsMainMenu;

	private const StringComparison NAME_COMPARISON = StringComparison.OrdinalIgnoreCase;

	private const string DATA_SET_NAME = "MainMenuDataSet";

	public static CultureInfo s_CurrentCulture
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(BaseAiManager), Member = "InstantiateSubsystems")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateOnlineSystems")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateInputSystem")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	private void InstantiateSystems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "CreateInterfaceManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "InstantiateInterfaceObjects")]
	public static void InstantiateInterfaceSystem()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(BootUpdate), Member = "Start")]
	[Calls(Type = typeof(Addressables), Member = "InstantiateAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	public static void InstantiateInputSystem()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(PlatformManager), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(Addressables), Member = "InstantiateAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void InstantiateOnlineSystems()
	{
	}

	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public static void InstantiateStoryManager()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "DestroySandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public static void ResetGameState()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetGameState")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public static void DestroyStoryManager()
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(EmptyScene), Member = "OnLoadComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadStoryFromEmptyCallback")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(BaseAiManager), Member = "RegisterAnyAIGuid")]
	[Calls(Type = typeof(MissionServicesManager), Member = "RegisterAnyMissionObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "DestroyStoryManager")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	public static void InstantiateSandboxManager()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerLoopScript), Member = "EarlyUpdate_Internal")]
	[CalledBy(Type = typeof(PlayerLoopScript._003C_003Ec), Member = "<Init>b__7_0")]
	[Calls(Type = typeof(PlayerCameraAnim), Member = "RestoreMainCameraPos")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "EarlyUpdateAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void EarlyUpdate()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "ResetGameState")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopAllMissions")]
	[Calls(Type = typeof(MissionServicesManager), Member = "UnregisterAllMissionObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public static void DestroySandboxManager()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "CachePlayerComponents")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(GameManager), Member = "CacheComponents")]
	[Calls(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateRumbleEffectManager")]
	[Calls(Type = typeof(ConsoleManager), Member = "Initialize")]
	[Calls(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "add_OnOptionalContentLoaded")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(GameManager), Member = "PauseWhenFocusLost")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(AfflictionDefinitionTable), Member = "RefreshCache")]
	[Calls(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateEffectPoolManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	[Calls(Type = typeof(GameManager), Member = "GetDLCVersionInfo")]
	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	[Calls(Type = typeof(GameManager), Member = "OutputSystemInfo")]
	[Calls(Type = typeof(PersistentDataPath), Member = "Init")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(EpisodeManager), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "SetActiveScene")]
	[Calls(Type = typeof(ThreeDaysOfNight), Member = "Init")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	[Calls(Type = typeof(GameManager), Member = "GetDLCVersionInfo")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnOptionalContentLoaded(IResourceLocator obj)
	{
	}

	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlayableBehaviourFadeLight), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GearManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAiManager), Member = "Reset")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AuroraManager), Member = "Reset")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Init")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private static void ResetLists()
	{
	}

	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(GameManager), Member = "UpdateTerrainSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFiles")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplySoundVolume")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(FeatsManager), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMasterVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyMusicVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyVoiceVolume")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyPanningRule")]
	[Calls(Type = typeof(InputManager), Member = "LoadRemapping")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyBrightness")]
	public void Start()
	{
	}

	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "UpdateQueue")]
	[Calls(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(GameManager), Member = "UpdatePaused")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(GameManager), Member = "PostMigrationDestoryLitFlareOrTorch")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "HideSyncMessage")]
	[Calls(Type = typeof(AssetBundleManager), Member = "Update")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GearMessage), Member = "AddJournalQueueMessage")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "ShowSyncMessage")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(PlatformManager), Member = "Update")]
	[Calls(Type = typeof(SceneManager), Member = "GetInstance")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "GetMovementInput")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StatsManager), Member = "CheckBurntHousesInCoastal")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MainCameraFrustrum), Member = "RecalculateFrustumPlanes")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "ApplyCurrentQualitySettings")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	[Calls(Type = typeof(InaccessibleGearContainer), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "FindAll")]
	public static void AllScenesLoaded()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAiManager), Member = "DiposeBatchGroundRaycastHit")]
	[Calls(Type = typeof(BaseAiManager), Member = "DoLateUpdate")]
	[Calls(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[Calls(Type = typeof(ElectrostaticForce), Member = "UpdateValueAndStrength")]
	[Calls(Type = typeof(MatchTransform), Member = "LateUpdateAll")]
	[Calls(Type = typeof(BaseAiManager), Member = "BatchGroundRaycast")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAiManager), Member = "DiposeBatchGroundRaycastHit")]
	[Calls(Type = typeof(EpisodeManager), Member = "Shutdown")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SplineManager), Member = "Dispose")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	private bool CanMigrateEnteringEpisode(Episode episode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GC), Member = "Collect")]
	public static void ForceGC()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "Enable")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(GC), Member = "Collect")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallsUnknownMethods(Count = 1)]
	public static void MaybeForceGC()
	{
	}

	[CallerCount(Count = 0)]
	public static void RequestTempResolutionChange()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	public static string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 8)]
	public static void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	public static void ReInitDefaultOptions()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	public void OnApplicationQuit()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	public static bool SaveGameCanBeLoaded(string slotName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool SaveGameCanBeLoaded(string slotName, out string saveErrorMessage)
	{
		saveErrorMessage = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	private static void SaveGameAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "OnResetAllTimeStatsConfirmed")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(_003C_003Ec), Member = "<LoadSceneAsynchronously>b__294_0")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_tod_slider")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_show_fps")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AchievementManager), Member = "Update")]
	[CalledBy(Type = typeof(AchievementManager), Member = "MaybeSaveProfile")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallySaveJournal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandboxConfirmed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnDeleteSandbox")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShowTODSlider")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "DoStop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRenameSandboxConfirmed")]
	public static void SaveProfileAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.AuthenticateOperation), Member = "SaveToken")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SaveToken")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmSettings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ResetBindings")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "MaybeShowResetBindingsConfirmation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	public static void SaveProfileSettingsAndDisplayHUDMessage()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAutosave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetOldestAutosaveName")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSystem), Member = "ResetAutosaveTimer")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	public static void TriggerAutosaveAndDisplayHUDMessage()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SaveStory._003COnQuicksaveCoroutine_003Ed__58), Member = "MoveNext")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetBaseNameForSave")]
	[Calls(Type = typeof(Panel_SaveIcon), Member = "StartSaveIconAnimation")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[Calls(Type = typeof(StatsManager), Member = "SetValue")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void TriggerQuicksaveAndDisplayHUDMessage()
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteSaveNamed")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetSlotDisplayName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetUserDefinedSlotName")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToSave")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	public static void TriggerManualSaveAndDisplayHUDMessage(string saveName, string displayName)
	{
	}

	[CalledBy(Type = typeof(Frostbite), Member = "FrostbiteStart")]
	[CalledBy(Type = typeof(DamageTrigger), Member = "OnTriggerExit")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "IntestinalParasitesStart")]
	[CalledBy(Type = typeof(IntestinalParasites), Member = "AddRiskPercent")]
	[CalledBy(Type = typeof(Infection), Member = "InfectionStart")]
	[CalledBy(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CalledBy(Type = typeof(FoodPoisoning), Member = "FoodPoisoningStart")]
	[CalledBy(Type = typeof(Dysentery), Member = "DysenteryStart")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Burns), Member = "BurnsStart")]
	[CalledBy(Type = typeof(BrokenRib), Member = "BrokenRibStart")]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateWhenSleeping")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(CabinFever), Member = "CabinFeverStart")]
	public static void TriggerSurvivalSaveAndDisplayHUDMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	public static bool ShouldPauseMoviePlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[Calls(Type = typeof(CharacterController), Member = "get_isGrounded")]
	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerManualSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Condition_CanSave), Member = "OnCheck")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveExists")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetTrackedMission")]
	[Calls(Type = typeof(EpisodeManager), Member = "GetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveExists")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool AllowedToSave(SaveState state)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "CanInvokePauseMenu")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public static bool AllowedToLoadActiveGame()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverwriteSelectedSave")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__38), Member = "MoveNext")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	public static void ForceSaveGame()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	public static bool LoadSaveGameSlot(SaveSlotInfo ssi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(SaveGameSystem), Member = "ResetAutosaveTimer")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	public static bool LoadSaveGameSlot(string slotName, int saveChangelistVersion)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnSlotClicked")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ReloadSlot")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(GameManager), Member = "AllowedToLoadActiveGame")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "LoadSelectedSave")]
	[Calls(Type = typeof(InterfaceManager), Member = "ClearUISaveData")]
	[CallsUnknownMethods(Count = 2)]
	public static bool LoadGame(SaveSlotInfo ssi)
	{
		return default(bool);
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public static void ContinueToNextEpisode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	private static void SetupTransferData()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	private static void ApplyTransferData()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "ResetGameState")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	private static void OnLoadGameCallback()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	private static void OnLoadStoryFromEmptyCallback()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnLoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadGame")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallsUnknownMethods(Count = 2)]
	public static void FadeOutSceneAudio()
	{
	}

	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(LoadScene), Member = "PerformSceneLoad")]
	public static void LoadScene(string sceneName, string sceneSaveFilenameCurrent)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_scene")]
	[Calls(Type = typeof(GameManager), Member = "SetPhysicsAutoSimulationEnabled")]
	[CalledBy(Type = typeof(Action_LoadScene), Member = "OnExecute")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[Calls(Type = typeof(GameManager), Member = "ResetLists")]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "CloseOverlaysDueToSceneLoad")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadScene")]
	[CallerCount(Count = 4)]
	public static void LoadSceneWithLoadingScreen(string sceneName)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(SceneSet), Member = "LoadAsync")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(GameManager), Member = "AddAsyncLoadRequest")]
	[CalledBy(Type = typeof(GameManager), Member = "AsyncLoadMainMenu")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "GetSaveSlotInfo")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void LoadSceneAsynchronously(string sceneName)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(MissionServicesManager), Member = "SceneUnloaded")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneByName")]
	public static void AddAsyncLoadRequest(string sceneName, List<AsyncOperationHandle<SceneInstance>> asyncOps)
	{
	}

	[CallerCount(Count = 0)]
	public static string GetVersionString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static bool SaveIsBlockedDueToRestoreGame()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ShowCredits), Member = "SimpleQuit")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[CalledBy(Type = typeof(LoadScene), Member = "ExitToMainMenu")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "ReallyQuitToMainMenu")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnMainMenu")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "ResetGameState")]
	[Calls(Type = typeof(SoundbankLoader), Member = "UnloadAllEpisodeBanks")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnQuitToMainMenu")]
	public static void LoadMainMenu()
	{
	}

	[Calls(Type = typeof(CameraFade), Member = "BlackOutScreen")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "DoQuitGame")]
	[CalledBy(Type = typeof(LoadScene), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnCreditsEnd")]
	[CalledBy(Type = typeof(Action_PlayCredits), Member = "OnActionComplete")]
	[CalledBy(Type = typeof(Action_ShowCredits), Member = "SimpleQuit")]
	[CalledBy(Type = typeof(LoadScene), Member = "ExitToMainMenu")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(PopupBase), Member = "Quit")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "QuitGame")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	public static void OnGameQuit()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string StripOptFromSceneName(string sceneName)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsActiveScene")]
	public static bool AreControlsLockedForIntro()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SteamPipeValveSocket), Member = "ShowHoverButtonPrompts")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AllowInteractionWithObjects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoWeaponSwaying")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateForces")]
	public static bool ControlsLocked()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "MaybeFadeoutHipShoulder")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DoBob")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool IsMovementLockedBecauseOfLantern()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsMoveInputUnblocked()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseItem")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UseEmergencyStim")]
	[CalledBy(Type = typeof(RadialMenuArm), Member = "DoAltClickAction")]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetPlayerMovement")]
	public static void MaybeBlockMoveInputUntilReleased(MonoBehaviour context)
	{
	}

	[CallerCount(Count = 0)]
	public static GameManager Instance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Camera GetGlobalCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Camera GetMainCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Camera GetWeaponCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Camera GetImageEffectCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Camera GetInspectModeCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Light GetInspectModeLight()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static vp_FPSCamera GetVpFPSCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static vp_FPSPlayer GetVpFPSPlayer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static CameraEffects GetCameraEffects()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static CameraStatusEffects GetCameraStatusEffects()
	{
		return null;
	}

	[CallerCount(Count = 202)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject GetPlayerObject()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerCameraAnim GetNewPlayerCameraAnim()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static GameObject GetWeaponView()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 214)]
	public static Transform GetPlayerTransform()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static GameObject GetTopLevelCharacterFpsPlayer()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static AiDifficultySettings GetAiDifficultySettings()
	{
		return null;
	}

	[CallerCount(Count = 178)]
	[CallsUnknownMethods(Count = 1)]
	public static UniStormWeatherSystem GetUniStorm()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static AuroraManager GetAuroraManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static AchievementManager GetAchievementManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static BodyCarry GetBodyCarryComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Burns GetBurnsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static BurnsElectric GetBurnsElectricComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static BloodLoss GetBloodLossComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static BodyHarvestManager GetBodyHarvestManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Breath GetBreathComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static BrokenRib GetBrokenRibComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static CabinFever GetCabinFeverComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Condition GetConditionComponent()
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(GearItem), Member = "get_DisplayNameWithCondition")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(GearItemData), Member = "GetDisplayNameWithCondition")]
	[CalledBy(Type = typeof(GearItemInventoryIconConditionData), Member = "GetInventoryIcon")]
	[CallsUnknownMethods(Count = 1)]
	public static ConditionTable GetConditionTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static DialogueStatesTable GetDialogueStatesTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static MissionObjectiveTable GetMissionObjectiveTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static AfflictionDefinitionTable GetAfflictionDefinitionTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static DownsampleAurora GetDownsampleAurora()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static DynamicDecalsManager GetDynamicDecalsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Dysentery GetDysenteryComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static EffectPoolManager GetEffectPoolManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static EmergencyStim GetEmergencyStimComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Encumber GetEncumberComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static EnergyBoost GetEnergyBoostComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static ExperienceModeManager GetExperienceModeManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Fatigue GetFatigueComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FireManager GetFireManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FoodPoisoning GetFoodPoisoningComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FootStepSounds GetFootStepSoundsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Freezing GetFreezingComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Frostbite GetFrostbiteComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Suffocating GetSuffocatingComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static HeatSourceManager GetHeatSourceManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Headache GetHeadacheComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Hunger GetHungerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Hypothermia GetHypothermiaComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Infection GetInfectionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static InfectionRisk GetInfectionRiskComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static IntestinalParasites GetIntestinalParasitesComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FallDamage GetFallDamageComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_BookSmarts GetFeatBookSmarts()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_ColdFusion GetFeatColdFusion()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_EfficientMachine GetFeatEfficientMachine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_FireMaster GetFeatFireMaster()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_FreeRunner GetFeatFreeRunner()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_SnowWalker GetFeatSnowWalker()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_ExpertTrapper GetFeatExpertTrapper()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_StraightToHeart GetFeatStraightToHeart()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_BlizzardWalker GetFeatBlizzardWalker()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Feat_NightWalker GetFeatNightWalker()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FeatsManager GetFeatsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FeatNotify GetFeatNotify()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FlyOver GetFlyOverComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FootstepTrailManager GetFootstepTrailManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static GlobalParameters GetGlobalParameters()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static IceCrackingManager GetIceCrackingManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static InteractiveClothManager GetInteractiveClothManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Inventory GetInventoryComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Log GetLogComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static MissionServicesManager GetMissionServicesManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PassTime GetPassTime()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static MapDetailManager GetMapDetailManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static MusicEventManager GetMusicEventManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerClimbRope GetPlayerClimbRopeComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerGameStats GetPlayerGameStatsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerInVehicle GetPlayerInVehicle()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerInConstrainedCamera GetPlayerInConstrainedCamera()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerKnowledge GetPlayerKnowledgeComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerAnimation GetPlayerAnimationComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerManager GetPlayerManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerMovement GetPlayerMovementComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerSkills GetPlayerSkillsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerStruggle GetPlayerStruggleComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerStunned GetPlayerStunnedComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerSwing GetPlayerSwingComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerVoice GetPlayerVoiceComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static QualitySettingsManager GetQualitySettingsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static RadialSpawnManager GetRadialSpawnManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static RenderTextureCameraManager GetRenderTextureCameraManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Rest GetRestComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static RumbleEffectManager GetRumbleEffectManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static ScentRanges GetSceneRanges()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SandboxManager GetSandboxManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static StoryManager GetStoryManager()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionEndInternal")]
	[CalledBy(Type = typeof(BowItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouchImmediate")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "EnableCrouch")]
	[CallerCount(Count = 8)]
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
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "DisplayCarcassToFrozenMessage")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CarcassTooFrozenToHarvestBareHands")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "OnQuarter")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "GetHarvestDurationMinutes")]
	public static Skill_CarcassHarvesting GetSkillCarcassHarvesting()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetConditionIncreaseFromRepair")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GearItemIsConsideredClothing")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCurrentSkillName")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetModifiedActionDuration")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DegradeToolUsedForAction")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetChanceSuccessfullRepair")]
	public static Skill_ClothingRepair GetSkillClothingRepair()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnSmashComplete")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "SetCookedGearProperties")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CallerCount(Count = 5)]
	public static Skill_Cooking GetSkillCooking()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerHasMaterialsToStartFire")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerGetTinderChoice")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerCalculateFireStartTime")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "GetMissingMaterialsString")]
	[CalledBy(Type = typeof(FireManager), Member = "CalculateFireStartSuccess")]
	[CalledBy(Type = typeof(FireManager), Member = "PlayerStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "OnStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "CanStartFire")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshTinderLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshBaseSkillLabel")]
	[CalledBy(Type = typeof(FuelSourceItem), Member = "GetModifiedBurnDurationHours")]
	[CalledBy(Type = typeof(Feat_FireMaster), Member = "MaybeUpdateFireStartingSkillLevel")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	public static Skill_Firestarting GetSkillFireStarting()
	{
		return null;
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "SetNextCatchTime")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "MaybeCatchFish")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RollForLineBreak")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(IceFishingHole), Member = "RevealFishInInspectMode")]
	public static Skill_IceFishing GetSkillIceFishing()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "GetCleanConditionIncreaseAndDuration")]
	[CalledBy(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 8)]
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
	[CalledBy(Type = typeof(BodyDamage), Member = "GetDamageScale")]
	[CalledBy(Type = typeof(BodyDamage), Member = "GetChanceKill")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "Start")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(GunItem), Member = "GetRecoilPitch")]
	public static Skill_Revolver GetSkillRevolver()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RollForRepairSuccess")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "DetermineConditionImprovement")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "ApplyCondition")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "CheckForHarvestSuccess")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "BeginRepair")]
	public static Skill_Gunsmithing GetSkillGunsmithing()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SkillNotify GetSkillNotify()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SkillsManager GetSkillsManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SnowPatchManager GetSnowPatchManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SnowShelterManager GetSnowShelterManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static LeanToManager GetLeanToManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static RockCacheManager GetRockCacheManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SpawnRegionManager GetSpawnRegionManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SprainedAnkle GetSprainedAnkleComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SprainedWrist GetSprainedWristComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SprainPain GetSprainPainComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Sprains GetSprainsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Anxiety GetAnxietyComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Fear GetFearComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static ToxicFog GetToxicFogComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static StartSettings GetStartSettingsComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static StatsManager GetStatsManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static TerrainGrassModifier GetTerrainGrassModifier()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static TerrainRenderingManager GetTerrainRenderingManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Thirst GetThirstComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static TLD_TimelineDirector GetPlayerTimelineDirector()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static TimeOfDay GetTimeOfDayComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static TrustManager GetTrustManagerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Weather GetWeatherComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static WeatherTransition GetWeatherTransitionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static WellFed GetWellFedComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Willpower GetWillpowerComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Wind GetWindComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static WindZone GetWindZone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PackManager GetPackManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static AreaMarkupManager GetAreaMarkupManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FastClothManager GetFastClothManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static DebugViewModeManager GetDebugViewModeManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static InvisibleEntityManager GetInvisibleEntityManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static ToxicFogManager GetToxicFogManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SprainProtection GetSprainProtectionComponent()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SteamPipeEffectManager GetSteamPipeEffectManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SteamPipeValveManager GetSteamPipeValveManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static SteamPipeManager GetSteamPipeManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static PlayerCough GetPlayerCough()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static HighResolutionTimerManager GetHighResolutionTimerManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static FontManager GetFontManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static NotificationFlagManager GetNotificationFlagManager()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static DamageProtection GetDamageProtection()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static InsomniaManager GetInsomniaComponent()
	{
		return null;
	}

	[CallerCount(Count = 101)]
	public static bool IsStoryMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static CameraGlobalRT GetCameraGlobalRT()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Camera GetCurrentCamera()
	{
		return null;
	}

	[CallerCount(Count = 105)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	public static CustomExperienceMode GetCustomMode()
	{
		return null;
	}

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "InCustomMode")]
	[CallsUnknownMethods(Count = 1)]
	public static bool InCustomMode()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallerCount(Count = 0)]
	public static bool IsPlayingCustomXPGame()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[Calls(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[Calls(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "ProcessTimeGatedUnlocks")]
	[Calls(Type = typeof(InputManager), Member = "ShowCursor")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePaused()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "UpdateCarryingBuff")]
	[Calls(Type = typeof(TodMaterial), Member = "UpdateAll")]
	[Calls(Type = typeof(BreakDown), Member = "UpdateAll")]
	[Calls(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(PlayerManager), Member = "GetClimbingBuffClothing")]
	[Calls(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "UpdateAll")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BearHuntRedux), Member = "End")]
	[Calls(Type = typeof(BaseAiManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[Calls(Type = typeof(SplineManager), Member = "EarlyUpdate")]
	[Calls(Type = typeof(InputManager), Member = "ProcessScreenshotInput")]
	[Calls(Type = typeof(GearManager), Member = "UpdateItems")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "HasFadedInOnStart")]
	[Calls(Type = typeof(InputManager), Member = "IsShowingControllerDisconnectedPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "UnPauseAudio")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsShowingQuote")]
	[Calls(Type = typeof(InputManager), Member = "ProcessInput")]
	[Calls(Type = typeof(InputManager), Member = "MaybeTakeScreenshot")]
	[Calls(Type = typeof(InputManager), Member = "ProcessTimeGatedUnlocks")]
	[Calls(Type = typeof(CameraFade), Member = "UpdateFade")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(GearManager), Member = "DestroyMarkedObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "UpdateAll")]
	private void UpdateNotPaused()
	{
	}

	[CallsUnknownMethods(Count = 67)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 106)]
	private void CacheComponents()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	private void CachePlayerComponents()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsUnknownMethods(Count = 32)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "DestroyPlayerObject")]
	[CallsDeduplicatedMethods(Count = 29)]
	private void InstantiatePlayerObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 3)]
	public static void RestorePlayerTransformParent()
	{
	}

	[CalledBy(Type = typeof(LoadScene), Member = "Activate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SceneSetManager), Member = "FindSceneSetForSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "MaybeClearCache")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsOutDoorsScene(string sceneName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private static int GetResolutionOverrideForScene(SceneSet scene)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private static void MaybeSwitchRenderingPath()
	{
	}

	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TerrainData), Member = "get_alphamapTextures")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
	[Calls(Type = typeof(Terrain), Member = "set_collectDetailPatches")]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Terrain), Member = "get_terrainData")]
	private static void UpdateTerrainSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void InstantiateSwitchKeyboard()
	{
	}

	[CallerCount(Count = 0)]
	public static void CancelPendingSave()
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Initialize")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	public static bool IsTrialMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void PauseForLoading()
	{
	}

	[CallerCount(Count = 0)]
	public static bool ToggleTrialMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "OnBuyNow")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnBuyNow")]
	public static void OnBuyNow()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeSpan), Member = "Interval")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public static string TrialModeTimeRemaining()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static bool IsStorySaveActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "Cleanup")]
	[Calls(Type = typeof(CameraFade), Member = "ClearPendingCallbacks")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(GameManager), Member = "LoadMainMenu")]
	public static void DoExitToMainMenu()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithRandomGear")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeRollRandomWeightAndCalories")]
	[CalledBy(Type = typeof(AuroraScreenPrefabPool), Member = "InstantiateRandomPrefabForScreen")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GearItem), Member = "RollGearCondition")]
	public static int GetRandomSeed(int seed)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(WaterSource), Member = "Update")]
	[CalledBy(Type = typeof(Harvestable), Member = "RollSpawnChance")]
	[CalledBy(Type = typeof(GearItem), Member = "ManualStart")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CalledBy(Type = typeof(GearItem), Member = "RollSpawnChance")]
	[Calls(Type = typeof(GameManager), Member = "GetRandomSeed")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	public static bool RollSpawnChance(GameObject go, float spawnChance)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Weather), Member = "LateUpdate")]
	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	public static bool HasPlayerObject()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudioImmediate")]
	[CallerCount(Count = 0)]
	private void OnApplicationFocus(bool focusStatus)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateAiSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateSystems")]
	private GameObject InstantiateSystem(GameObject prefab, Vector3 pos, Transform parent)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSystem")]
	[Calls(Type = typeof(BaseAiManager), Member = "InstantiateSubsystems")]
	[CallsUnknownMethods(Count = 1)]
	private void InstantiateAiSystems(Vector3 pos, Transform parent)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void InstantiateConsole()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TimeOfDay), Member = "InstantiateUniStorm")]
	[CallsUnknownMethods(Count = 1)]
	private void InstantiateUniStorm()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	private void InstantiateEffectPoolManager()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "LoadEffects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void InstantiateRumbleEffectManager()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 4)]
	private void DestroyInventoryItems(GameObject parent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[CalledBy(Type = typeof(GameManager), Member = "OnOptionalContentLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void SetGameVersionString(string versionString, string dlcVersionString)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsUnknownMethods(Count = 2)]
	public int ExtractChangelistFromVersion(string versionString)
	{
		return default(int);
	}

	[Calls(Type = typeof(GameManager), Member = "SetGameVersionString")]
	[Calls(Type = typeof(GameManager), Member = "GetDLCVersionInfo")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ReadVersionFile")]
	private void LookupGameVersionString()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[CalledBy(Type = typeof(GameManager), Member = "OnOptionalContentLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(OptionalContentManager), Member = "TryFindConfig")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private string GetDLCVersionInfo()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CalledBy(Type = typeof(GameManager), Member = "LookupGameVersionString")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CalledBy(Type = typeof(GameManager), Member = "OnOptionalContentLoaded")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	private string ReadVersionFile()
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void OutputSystemInfo()
	{
	}

	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Contains")]
	private static bool SceneNotCompatibleWithMode(bool isStory, string sceneName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PlayerManager), Member = "UpdateBonusValuesFromWornClothing")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	private void LoadSlotOnStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	private void MigrateSlotOnStart()
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetState")]
	[CallerCount(Count = 0)]
	private void SetAudioModeForLoadedScene()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHandsSkipAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void PostMigrationDestoryLitFlareOrTorch()
	{
	}

	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 0)]
	private void HandleCheckpointSaveRequest()
	{
	}

	[CallerCount(Count = 0)]
	public static void RequestSaveCheckpoint()
	{
	}

	[CallerCount(Count = 0)]
	public static bool GetAllowPhysicsSimulationControl()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void SetAllowPhysicsSimulationControl(bool allow)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetPhysicsAutoSimulationEnabled(bool enabled)
	{
	}

	[Calls(Type = typeof(Panel_Log), Member = "EnableStatsView")]
	[Calls(Type = typeof(Panel_Log), Member = "BeginFadeIn")]
	[Calls(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyHudType")]
	[Calls(Type = typeof(SaveGameSystem), Member = "DeleteSaveFilesForGameId")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NPCCondition), Member = "AddHealth")]
	[CalledBy(Type = typeof(NPCCondition), Member = "HandleDeath")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CalledBy(Type = typeof(Action_FailMission), Member = "OnExecute")]
	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[Calls(Type = typeof(Panel_Log), Member = "CreateSandboxRecord")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipImmediate")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Condition), Member = "GetCauseOfDeathStringUntranslated")]
	[Calls(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Log), Member = "LockInTodaysValues")]
	public static void HandlePlayerDeath(string overrideCauseOfDeath = null)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "InitializeSystems")]
	[Calls(Type = typeof(Thread), Member = "set_CurrentCulture")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread")]
	public static void InitializeCulture()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetGameState")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiatePlayerObject")]
	[CallsUnknownMethods(Count = 2)]
	public static void DestroyPlayerObject()
	{
	}

	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	private static void DebugNotAllowedToLoad(string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private static void DebugNotAllowedToSave(string message)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PauseAudio")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	public static void PauseWhenFocusLost(bool focusLost)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetDelayedGameplayComponentInfo")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetDelayedGameplayComponentInfo")]
	public static bool IsFrameValidToUpdate(GameplayComponent component)
	{
		return default(bool);
	}

	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "Update")]
	[CalledBy(Type = typeof(Sprains), Member = "RollForSprainWhenMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CalledBy(Type = typeof(Sprains), Member = "UpdateSprainRiskWarning")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Wind), Member = "Update")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CalledBy(Type = typeof(Wind), Member = "UpdateNoise")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	public static float GetDeltaTime(GameplayComponent component)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "InitDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(GameManager), Member = "RegisterDelayedComponents")]
	private static void RegisterDelayedComponent(GameplayComponent component, int frequency)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	private static void RegisterDelayedComponents()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "RegisterDelayedComponent")]
	private static void InitDelayedComponents()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	[CalledBy(Type = typeof(GameManager), Member = "IsFrameValidToUpdate")]
	private static DelayedGameplayComponentInfo GetDelayedGameplayComponentInfo(GameplayComponent component)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private static void UpdateDelayedComponentsDeltaTime()
	{
	}

	[Calls(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSlotNameContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnRenameNewSandboxComplete")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "OnTryAgain")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[Calls(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(Utils), Member = "SendGameStartAnalyticsEvent")]
	[Calls(Type = typeof(GameManager), Member = "FadeOutSceneAudio")]
	[Calls(Type = typeof(Panel_HUD), Member = "CleanupDamageEventTable")]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(StatContainer), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Log), Member = "Reset")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(SaveGameSlotHelper), Member = "ClearSaveSlotsLists")]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "GetRandomRegionFromAllAvailable")]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "ValidateStartingRegion")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "GetSpawnSceneSet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[Calls(Type = typeof(Panel_Inventory), Member = "RefreshFilterIconColors")]
	public void LaunchSandbox()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnWorldMapClicked")]
	[CalledBy(Type = typeof(Panel_SelectSurvivor), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "OnExperienceClicked")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnContinue")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnSelectSurvivorBack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnChallengeClicked")]
	public static bool RegionLockedBySelectedMode()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "SetActiveScene")]
	[CalledBy(Type = typeof(GameManager), Member = "SetActiveScene")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "AsyncLoadsComplete")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CalledBy(Type = typeof(Condition_InScene), Member = "OnCheck")]
	[CalledBy(Type = typeof(GameManager), Member = "IsWellKnownScene")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "IsIndoorWardLocationForCurrentScene")]
	[CalledBy(Type = typeof(GameManager), Member = "IsWellKnownScene")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "HasFinishedLoading")]
	[CalledBy(Type = typeof(GameManager), Member = "IsActiveScene")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallerCount(Count = 13)]
	public static bool CompareSceneNames(string lhs, string rhs)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_IsStartingNewGame), Member = "OnCheck")]
	[CalledBy(Type = typeof(SceneNameMapping), Member = "GetLocIDForScene")]
	[CalledBy(Type = typeof(SceneManager), Member = "OnSceneLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "SetActiveScene")]
	[CalledBy(Type = typeof(GameManager), Member = "IsWellKnownScene")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	public static bool MatchesMainMenuSceneName(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	public static void AsyncLoadMainMenu()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetTargetMainMenuSceneName")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallerCount(Count = 0)]
	public static AsyncOperationHandle<SceneInstance> AsyncDirectLoadMainMenu()
	{
		return default(AsyncOperationHandle<SceneInstance>);
	}

	[CallerCount(Count = 0)]
	public static bool IsBootSceneActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsEmptySceneActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsMainMenuActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_StreamPipeMonitorStatus), Member = "OnInit")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_hunted2_endgame")]
	[CalledBy(Type = typeof(GameManager), Member = "AllowedToSave")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneWithLoadingScreen")]
	[CalledBy(Type = typeof(GameManager), Member = "AreControlsLockedForIntro")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	public static bool IsActiveScene(string sceneName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "AsyncLoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CalledBy(Type = typeof(GameManager), Member = "AsyncDirectLoadMainMenu")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OptionalContentManager), Member = "CanUseContent")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BootUpdate), Member = "LoadMainMenu")]
	private static string GetTargetMainMenuSceneName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	private static bool IsWellKnownScene(string sceneName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsWellKnownSceenActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[Calls(Type = typeof(GameManager), Member = "CompareSceneNames")]
	[CallerCount(Count = 1)]
	private static void SetActiveScene(string sceneName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameManager()
	{
	}
}
