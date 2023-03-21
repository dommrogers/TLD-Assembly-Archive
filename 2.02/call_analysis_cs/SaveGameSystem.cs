using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using SpecialEvents;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGameSystem
{
	public delegate void SaveCompletedDelegate();

	private sealed class _003CSaveScreenshotDataCoroutine_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private WaitForEndOfFrame _003CendOfFrame_003E5__2;

		private RenderTexture _003CsmallTarget_003E5__3;

		private Texture2D _003Ct_003E5__4;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CSaveScreenshotDataCoroutine_003Ed__57(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String")]
		[Calls(Type = typeof(Utils), Member = "SerializeObject")]
		[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
		[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
		[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Graphics), Member = "Blit")]
		[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
		[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
		[Calls(Type = typeof(Utils), Member = "IsZero")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 28)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CSaveGameCoroutine_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string name;

		private Stopwatch _003Cwatch_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CSaveGameCoroutine_003Ed__95(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
		[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static bool s_AsyncEnabled;

	private static Queue<SlotData> s_AsyncSlotDataQueue;

	private static Mutex s_AsyncSlotDataMutex;

	private static bool s_CheckIsGameDataSaving;

	private static Thread s_SavingThread;

	private static EventWaitHandle s_WaitHandle;

	private static bool s_HasSlotQueueData;

	private static bool s_SavingThreadActive;

	private static Queue<string> s_ForcedSyncSlotQueue;

	private static Mutex s_ForcedSyncMutex;

	private static bool s_HasForcedSyncQueueData;

	private static float m_LastAutosave;

	private static bool s_DebugVerbose;

	private static string PROFILE_DISPLAYNAME;

	private static SaveSlotType m_ScreenshotGameMode;

	private static string m_ScreenshotSaveName;

	private static IEnumerator s_ScreenshotCoroutine;

	public static string m_SlotToLoadOnStart;

	public static string m_MigrateSlotOnStart;

	public static bool m_CanMigrateSave;

	public static bool m_SceneRestoreInProgress;

	public static bool m_DidSceneRestore;

	public static int m_BootSaveGameFormatVersion;

	public static int m_LowestCompatibleBootSurvivalSaveGameFormatVersion;

	public static int m_LowestCompatibleBootStorySaveGameFormatVersion;

	public static int m_GlobalSaveGameFormatVersion;

	public static int m_SceneSaveGameFormatVersion;

	public static Episode m_CurrentEpisode;

	public static SaveSlotType m_CurrentGameMode;

	public static uint m_CurrentGameId;

	public static string m_CurrentSaveName;

	public static bool m_EnableSaveLoad;

	public static SaveCompletedDelegate m_OnSaveCompletedEvent;

	public static bool s_Initialized;

	private static BootSaveGameFormat m_BootSaveGameFormat;

	private static GlobalSaveGameFormat m_GlobalSaveGameFormat;

	private static SceneSaveGameFormat m_SceneSaveGameFormat;

	private static ScreenshotSaveGameFormat m_ScreenshotSaveGameFormat;

	private static InfoSaveGameFormat m_InfoSaveGameFormat;

	public const string DEFAULT_PROFILE_FILENAME = "user001";

	public const string DEFAULT_SETTINGS_FILENAME = "user001.cfg";

	public const string STANDALONE_SETTINGS_FILENAME = "usercfg";

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsAsyncEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAsyncSaveRunning()
	{
		return false;
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationQuit")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetAsyncEnabled")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ShutdownAsync")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void WaitForAsyncSave()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetAsyncEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShutdownAsync()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void EnqueueAsyncSave(string slotName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_Name")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 41)]
	private static void InitAsync()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private static void LogIsAsyncEnabled()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private static void ExecuteAsyncSaving()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "ExecuteAsyncSaving")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	private static bool HandleNextAsyncSlot(out string slotName)
	{
		slotName = null;
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSavePending")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(CameraFade), Member = "UpdateFade")]
	[Calls(Type = typeof(SaveGameSystem), Member = "TickScreenshotCoroutine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void WaitAsyncSaveComplete(string slotName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Queue<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static bool IsAsyncSavePending(string slotName)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGameCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static void UpdateAsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void OnGameManagerShutdown()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetAutosaveTimer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static float SecondsUntilNextAutosave()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateAutosave()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static BootSaveGameFormat GetBootData(string slotName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool SaveIsCompatible(BootSaveGameFormat boot, SaveSlotType gameMode)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void SaveBootData(SaveSlotType gameMode, string name)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool RestoreBootData(string name)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsDebugVerbose()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogVerbose(string msg)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void WarningInRelease(string msg)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "EnqueueAsyncSave")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "InitAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ExecuteAsyncSaving")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(_003CSaveGameCoroutine_003Ed__95), Member = "MoveNext")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogInRelease(string msg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ToggleDebugVerbose()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetGlobalSaveGameFormatVersion()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "Serialize")]
	[Calls(Type = typeof(Wind), Member = "Serialize")]
	[Calls(Type = typeof(Weather), Member = "Serialize")]
	[Calls(Type = typeof(WeatherTransition), Member = "Serialize")]
	[Calls(Type = typeof(Condition), Member = "Serialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Serialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Serialize")]
	[Calls(Type = typeof(Inventory), Member = "Serialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Serialize")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "Serialize")]
	[Calls(Type = typeof(Frostbite), Member = "Serialize")]
	[Calls(Type = typeof(SprainPain), Member = "Serialize")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Serialize")]
	[Calls(Type = typeof(SprainedWrist), Member = "Serialize")]
	[Calls(Type = typeof(Burns), Member = "Serialize")]
	[Calls(Type = typeof(BloodLoss), Member = "Serialize")]
	[Calls(Type = typeof(BrokenRib), Member = "Serialize")]
	[Calls(Type = typeof(Infection), Member = "Serialize")]
	[Calls(Type = typeof(InfectionRisk), Member = "Serialize")]
	[Calls(Type = typeof(Log), Member = "Serialize")]
	[Calls(Type = typeof(Rest), Member = "Serialize")]
	[Calls(Type = typeof(AchievementManager), Member = "Serialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[Calls(Type = typeof(AuroraManager), Member = "Serialize")]
	[Calls(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[Calls(Type = typeof(CabinFever), Member = "Serialize")]
	[Calls(Type = typeof(SnowfallManager), Member = "Serialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Serialize")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Serialize")]
	[Calls(Type = typeof(TrustManager), Member = "Serialize")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Serialize")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Serialize")]
	[Calls(Type = typeof(BodyCarry), Member = "Serialize")]
	[Calls(Type = typeof(NPC), Member = "SerializeGlobal")]
	[Calls(Type = typeof(PackManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(RockCacheManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Serialize")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(SceneManager), Member = "Serialize")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Serialize")]
	[Calls(Type = typeof(Panel_Map), Member = "Serialize")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "Serialize")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallsUnknownMethods(Count = 332)]
	private static void SaveGlobalData(SaveSlotType gameMode, string name)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SceneManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "Deserialize")]
	[Calls(Type = typeof(HUDManager), Member = "Deserialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(Stopwatch), Member = "Restart")]
	[Calls(Type = typeof(Wind), Member = "Deserialize")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Encumber), Member = "Start")]
	[Calls(Type = typeof(Hunger), Member = "Start")]
	[Calls(Type = typeof(Thirst), Member = "Start")]
	[Calls(Type = typeof(Fatigue), Member = "Start")]
	[Calls(Type = typeof(Freezing), Member = "Start")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Deserialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "PutPlayerOnRopeAfterDeserialize")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Frostbite), Member = "Deserialize")]
	[Calls(Type = typeof(SprainPain), Member = "Deserialize")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Deserialize")]
	[Calls(Type = typeof(SprainedWrist), Member = "Deserialize")]
	[Calls(Type = typeof(BloodLoss), Member = "Deserialize")]
	[Calls(Type = typeof(BrokenRib), Member = "Deserialize")]
	[Calls(Type = typeof(Infection), Member = "Deserialize")]
	[Calls(Type = typeof(InfectionRisk), Member = "Deserialize")]
	[Calls(Type = typeof(CabinFever), Member = "Deserialize")]
	[Calls(Type = typeof(Log), Member = "Deserialize")]
	[Calls(Type = typeof(Rest), Member = "Deserialize")]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[Calls(Type = typeof(AchievementManager), Member = "Deserialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[Calls(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Start")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[Calls(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[Calls(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Deserialize")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Deserialize")]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[Calls(Type = typeof(BodyCarry), Member = "Deserialize")]
	[Calls(Type = typeof(RockCacheManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_Map), Member = "Deserialize")]
	[Calls(Type = typeof(BlueprintItem), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "Deserialize")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetGlobalSaveGameFormatVersion")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AfterGlobalDeserialize")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallsUnknownMethods(Count = 260)]
	private static bool RestoreGlobalData(string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Deserialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(Log), Member = "Deserialize")]
	[Calls(Type = typeof(AchievementManager), Member = "Deserialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[Calls(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[Calls(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(BlueprintItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	private static bool RestoreGlobalDataForEspisodeMigration(string name)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[Calls(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void RestoreGlobalDataPostSceneRestore()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetActiveStoryMissionInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	private static void SaveInfoData(SaveSlotType gameMode, string name)
	{
	}

	[CalledBy(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_unlock_all")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "EatingComplete")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetNightWalkerProgress), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_SavePlayerProfile), Member = "OnExecute")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SaveProfile(ProfileSerializationOptions serializationOptions)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void LoadProfile(ProfileSerializationOptions deserializeFlags)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static int GetSceneSaveGameFormatVersion()
	{
		return 0;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContainerManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(GearManager), Member = "Serialize")]
	[Calls(Type = typeof(ArrowManager), Member = "Serialize")]
	[Calls(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[Calls(Type = typeof(FireManager), Member = "Serialize")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "SerializeAll")]
	[Calls(Type = typeof(LoadScene), Member = "SerializeAll")]
	[Calls(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "SerializeAll")]
	[Calls(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[Calls(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[Calls(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[Calls(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(ReplaceMaterialsManager), Member = "SerializeAll")]
	[Calls(Type = typeof(OpenCloseManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SwitchBoxManager), Member = "SerializeAll")]
	[Calls(Type = typeof(BreakDown), Member = "SerializeAll")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[Calls(Type = typeof(StickToGround), Member = "SerializeAll")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SerializeAll")]
	[Calls(Type = typeof(Chimney), Member = "SerializeAll")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Serialize")]
	[Calls(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[Calls(Type = typeof(LeanToManager), Member = "SerializeAll")]
	[Calls(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[Calls(Type = typeof(BaseAiManager), Member = "Serialize")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SerializeAll")]
	[Calls(Type = typeof(Keypad), Member = "SerializeAll")]
	[Calls(Type = typeof(InteractionOverride), Member = "SerializeAll")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[Calls(Type = typeof(BreakableIce), Member = "SerializeAll")]
	[Calls(Type = typeof(MapDetailManager), Member = "Serialize")]
	[Calls(Type = typeof(BearEncounter), Member = "SerializeAll")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "Serialize")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "Serialize")]
	[Calls(Type = typeof(ScriptLight), Member = "SerializeAll")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[Calls(Type = typeof(PackManager), Member = "Serialize")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SerializeAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SerializeAll")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "SerializeAll")]
	[Calls(Type = typeof(NPC), Member = "SerializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(Bed), Member = "SerializeAll")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "SerializeAll")]
	[Calls(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[Calls(Type = typeof(EntityWard), Member = "SerializeAll")]
	[Calls(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[Calls(Type = typeof(Elevator), Member = "SerializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SerializeAll")]
	[Calls(Type = typeof(WolfDen), Member = "SerializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 93)]
	private static void SaveSceneData(SaveSlotType gameMode, string name, string sceneSaveName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(FireManager), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(ContainerManager), Member = "DisableAll")]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "DeserializeAll")]
	[Calls(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[Calls(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[Calls(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[Calls(Type = typeof(ArrowManager), Member = "Deserialize")]
	[Calls(Type = typeof(FlareGunRoundManager), Member = "Deserialize")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[Calls(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[Calls(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(SwitchBoxManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(BreakDown), Member = "DeserializeAll")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(StickToGround), Member = "DeserializeAll")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[Calls(Type = typeof(Chimney), Member = "DeserializeAll")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[Calls(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(LeanToManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[Calls(Type = typeof(Keypad), Member = "DeserializeAll")]
	[Calls(Type = typeof(InteractionOverride), Member = "DeserializeAll")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[Calls(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[Calls(Type = typeof(MapDetailManager), Member = "Deserialize")]
	[Calls(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "Deserialize")]
	[Calls(Type = typeof(ScriptLight), Member = "DeserializeAll")]
	[Calls(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[Calls(Type = typeof(PackManager), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "DeserializeAll")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "DeserializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(Bed), Member = "DeserializeAll")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DeserializeAll")]
	[Calls(Type = typeof(NPC), Member = "DeserializeAll")]
	[Calls(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[Calls(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(Elevator), Member = "DeserializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	[Calls(Type = typeof(WolfDen), Member = "DeserializeAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Bed), Member = "PostDeserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 91)]
	private static bool LoadSceneData(string name, string sceneSaveName)
	{
		return false;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(BreakDown), Member = "DeserializeAllAdditive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void LoadSceneDataAdditive(string name, string sceneSaveName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static void SaveScreenshotData(SaveSlotType gameMode, string savename)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void TickScreenshotCoroutine()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static IEnumerator SaveScreenshotDataCoroutine()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static Texture2D CreateTextureData(string savename)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateSelectedJump")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static Texture2D CreateTextureData(ScreenshotSaveGameFormat screenshotData)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CalledBy(TypeFullName = "JumpManager.<OnSavingCoroutine>d__37", Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "OnGameManagerShutdown")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "AbortScreenshot")]
	[CalledBy(Type = typeof(_003CSaveGameCoroutine_003Ed__95), Member = "MoveNext")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsWaitingForScreenshot()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AbortScreenshot()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "Init")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(SaveGameSystem), Member = "InitAsync")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Init()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "UpdateAutosave")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetUserProfileFilename()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetSettingsFilename()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsChallengeActive")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetExtraInstancesOfFilename")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteFileFromSlot")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGameCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "EnqueueAsyncSave")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Break")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 38)]
	public static void SaveGame(string name, string sceneSaveName, bool saveFeatData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void PrepareSaveData(SaveSlotType gameMode, string name, string sceneSaveName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void PrepareSaveData_Verbose(SaveSlotType gameMode, string name, string sceneSaveName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static IEnumerator SaveGameCoroutine(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "MaybeSwitchToUninstancedFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetExtraInstancesOfFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	public static void RestoreGame(string name)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "MigrateSlotOnStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static void RestoreGameForEpisodeMigration(string name)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ResetForSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ConfigureRestoreFromSlot(string slotName)
	{
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "IsSceneRestoreInProgress")]
	[CalledBy(Type = typeof(Condition_IsStartingNewGame), Member = "OnCheck")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsRestoreInProgress()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsSceneRestoreInProgress()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(NowhereToHide), Member = "PostEventDeleteSaveSlot")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DeleteSaveFiles(string name)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteAllSlotsForGameId")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void DeleteSaveFilesForGameId(uint gameId)
	{
	}

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCurrentSaveInfo(Episode episode, SaveSlotType gameMode, uint saveId, string savename)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "BuildSlotName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GenerateNewSaveName()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetCurrentSaveName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlotsFourDaysOfNight")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static SaveSlotInfo GetNewestSaveSlotForActiveGame()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static void GetActiveMissionLocId(GlobalSaveGameFormat globalData, ref SaveSlotInfo saveSlotInfo)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private static void MaybeSetUserDefinedName(ref SaveSlotInfo saveSlotInfo)
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSetUserDefinedName")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetUserDefinedSlotName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static string SetDefaultUserDefinedSlotName(string slotname)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private static void MaybeSwitchToUninstancedFilename(string slot, string filename)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void SaveCompletedInternal(bool success)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SaveGameSystem()
	{
	}
}
