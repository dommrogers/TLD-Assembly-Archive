using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CSaveScreenshotDataCoroutine_003Ed__57(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 28)]
		[Calls(Type = typeof(Utils), Member = "IsZero")]
		[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
		[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
		[Calls(Type = typeof(Graphics), Member = "Blit")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
		[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary")]
		[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
		[Calls(Type = typeof(Utils), Member = "SerializeObject")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
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
		public _003CSaveGameCoroutine_003Ed__95(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
		[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
		private bool MoveNext()
		{
			return default(bool);
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
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSaving")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAsyncSaveRunning()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ShutdownAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetAsyncEnabled")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationQuit")]
	public static void WaitForAsyncSave()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	public static void SetAsyncEnabled(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	public static void ShutdownAsync()
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private static void EnqueueAsyncSave(string slotName)
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "Start")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "set_Name")]
	[Calls(Type = typeof(Thread), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	private static void InitAsync()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private static void LogIsAsyncEnabled()
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	private static void ExecuteAsyncSaving()
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ExecuteAsyncSaving")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	private static bool HandleNextAsyncSlot(out string slotName)
	{
		slotName = null;
		return default(bool);
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "TickScreenshotCoroutine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSavePending")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraFade), Member = "UpdateFade")]
	public static void WaitAsyncSaveComplete(string slotName)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallsUnknownMethods(Count = 7)]
	private static bool IsAsyncSavePending(string slotName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGameCoroutine")]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	private static void UpdateAsync()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	public static void OnGameManagerShutdown()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void ResetAutosaveTimer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static float SecondsUntilNextAutosave()
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateAutosave()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static BootSaveGameFormat GetBootData(string slotName)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveGameCanBeLoaded")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CallsUnknownMethods(Count = 3)]
	public static bool SaveIsCompatible(BootSaveGameFormat boot, SaveSlotType gameMode)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "StripOptFromSceneName")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 3)]
	private static void SaveBootData(SaveSlotType gameMode, string name)
	{
	}

	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static bool RestoreBootData(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsDebugVerbose()
	{
		return default(bool);
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogVerbose(string msg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void WarningInRelease(string msg)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CalledBy(Type = typeof(_003CSaveGameCoroutine_003Ed__95), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ExecuteAsyncSaving")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ExecuteAsyncSaving")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "InitAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "EnqueueAsyncSave")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	public static void LogInRelease(string msg)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ToggleDebugVerbose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	public static int GetGlobalSaveGameFormatVersion()
	{
		return default(int);
	}

	[Calls(Type = typeof(BearHuntRedux), Member = "Serialize")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(RockCacheManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(PackManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(NPC), Member = "SerializeGlobal")]
	[Calls(Type = typeof(BodyCarry), Member = "Serialize")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SkillsManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SnowfallManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(CabinFever), Member = "Serialize")]
	[Calls(Type = typeof(TrustManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 332)]
	[Calls(Type = typeof(NotificationFlagManager), Member = "Serialize")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "Serialize")]
	[Calls(Type = typeof(SceneManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Panel_Map), Member = "Serialize")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Serialize")]
	[Calls(Type = typeof(SceneManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "Serialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Serialize")]
	[Calls(Type = typeof(Inventory), Member = "Serialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Serialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Condition), Member = "Serialize")]
	[Calls(Type = typeof(WeatherTransition), Member = "Serialize")]
	[Calls(Type = typeof(Weather), Member = "Serialize")]
	[Calls(Type = typeof(Wind), Member = "Serialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 35)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(AuroraManager), Member = "Serialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentCustomModeString")]
	[Calls(Type = typeof(AchievementManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Rest), Member = "Serialize")]
	[Calls(Type = typeof(Log), Member = "Serialize")]
	[Calls(Type = typeof(InfectionRisk), Member = "Serialize")]
	[Calls(Type = typeof(Infection), Member = "Serialize")]
	[Calls(Type = typeof(BrokenRib), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BloodLoss), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SprainPain), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SprainedWrist), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Burns), Member = "Serialize")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Serialize")]
	[Calls(Type = typeof(Frostbite), Member = "Serialize")]
	private static void SaveGlobalData(SaveSlotType gameMode, string name)
	{
	}

	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Deserialize")]
	[Calls(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[Calls(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[Calls(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	[Calls(Type = typeof(AuroraManager), Member = "Deserialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[Calls(Type = typeof(BodyCarry), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Start")]
	[Calls(Type = typeof(RockCacheManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetGlobalSaveGameFormatVersion")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[Calls(Type = typeof(AchievementManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 260)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AfterGlobalDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GetGlobalSaveGameFormatVersion")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "Deserialize")]
	[Calls(Type = typeof(BlueprintItem), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_Map), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_WorldMap), Member = "Deserialize")]
	[Calls(Type = typeof(StatContainer), Member = "SetValue")]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[Calls(Type = typeof(BloodLoss), Member = "Deserialize")]
	[Calls(Type = typeof(Log), Member = "Deserialize")]
	[Calls(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(Wind), Member = "Deserialize")]
	[Calls(Type = typeof(Stopwatch), Member = "Restart")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(HUDManager), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "Deserialize")]
	[Calls(Type = typeof(SceneManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 74)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Rest), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Encumber), Member = "Start")]
	[Calls(Type = typeof(BrokenRib), Member = "Deserialize")]
	[Calls(Type = typeof(Thirst), Member = "Start")]
	[Calls(Type = typeof(InfectionRisk), Member = "Deserialize")]
	[Calls(Type = typeof(Infection), Member = "Deserialize")]
	[Calls(Type = typeof(Hunger), Member = "Start")]
	[Calls(Type = typeof(SprainedWrist), Member = "Deserialize")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Deserialize")]
	[Calls(Type = typeof(SprainPain), Member = "Deserialize")]
	[Calls(Type = typeof(Frostbite), Member = "Deserialize")]
	[Calls(Type = typeof(CabinFever), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "PutPlayerOnRopeAfterDeserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Deserialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Deserialize")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Freezing), Member = "Start")]
	[Calls(Type = typeof(Fatigue), Member = "Start")]
	private static bool RestoreGlobalData(string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(BlueprintItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[Calls(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(Log), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Deserialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Deserialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AchievementManager), Member = "Deserialize")]
	private static bool RestoreGlobalDataForEspisodeMigration(string name)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	private static void RestoreGlobalDataPostSceneRestore()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetActiveStoryMissionInfo")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[Calls(Type = typeof(StatsManager), Member = "GetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsCurrentEpisodeExperienceMode")]
	private static void SaveInfoData(SaveSlotType gameMode, string name)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SavePlayerProfile), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SetNightWalkerProgress), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_SetEpisodeState), Member = "OnExecute")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "UpdateDaysSurvived")]
	[CalledBy(Type = typeof(WintersEmbrace), Member = "EatingComplete")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "SaveProfileSettingsAndDisplayHUDMessage")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "Serialize")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[CalledBy(Type = typeof(Feat), Member = "HandleOnFeatUnlocked")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_challenge_complete_all")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_feat_unlock_all")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	public static void SaveProfile(ProfileSerializationOptions serializationOptions)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	public static void LoadProfile(ProfileSerializationOptions deserializeFlags)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static int GetSceneSaveGameFormatVersion()
	{
		return default(int);
	}

	[Calls(Type = typeof(Bed), Member = "SerializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(NPC), Member = "SerializeAll")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "SerializeAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SerializeAll")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SerializeAll")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "SerializeAll")]
	[Calls(Type = typeof(MapDetailManager), Member = "Serialize")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[Calls(Type = typeof(ScriptLight), Member = "SerializeAll")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "Serialize")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "Serialize")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[Calls(Type = typeof(BearEncounter), Member = "SerializeAll")]
	[Calls(Type = typeof(PackManager), Member = "Serialize")]
	[Calls(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 93)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(EntityWard), Member = "SerializeAll")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WolfDen), Member = "SerializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SerializeAll")]
	[Calls(Type = typeof(Elevator), Member = "SerializeAll")]
	[Calls(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(InteractionOverride), Member = "SerializeAll")]
	[Calls(Type = typeof(BreakableIce), Member = "SerializeAll")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SerializeAll")]
	[Calls(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[Calls(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "SerializeAll")]
	[Calls(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[Calls(Type = typeof(LoadScene), Member = "SerializeAll")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "SerializeAll")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[Calls(Type = typeof(FireManager), Member = "Serialize")]
	[Calls(Type = typeof(ArrowManager), Member = "Serialize")]
	[Calls(Type = typeof(GearManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(ContainerManager), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Keypad), Member = "SerializeAll")]
	[Calls(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[Calls(Type = typeof(BaseAiManager), Member = "Serialize")]
	[Calls(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[Calls(Type = typeof(LeanToManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[Calls(Type = typeof(Chimney), Member = "SerializeAll")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SerializeAll")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Serialize")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[Calls(Type = typeof(BreakDown), Member = "SerializeAll")]
	[Calls(Type = typeof(SwitchBoxManager), Member = "SerializeAll")]
	[Calls(Type = typeof(OpenCloseManager), Member = "SerializeAll")]
	[Calls(Type = typeof(ReplaceMaterialsManager), Member = "SerializeAll")]
	[Calls(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(StickToGround), Member = "SerializeAll")]
	private static void SaveSceneData(SaveSlotType gameMode, string name, string sceneSaveName)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "Deserialize")]
	[Calls(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[Calls(Type = typeof(ScriptLight), Member = "DeserializeAll")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 91)]
	[Calls(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[Calls(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[Calls(Type = typeof(MapDetailManager), Member = "Deserialize")]
	[Calls(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[Calls(Type = typeof(InteractionOverride), Member = "DeserializeAll")]
	[Calls(Type = typeof(Keypad), Member = "DeserializeAll")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(LeanToManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Bed), Member = "PostDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WolfDen), Member = "DeserializeAll")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "DeserializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[Calls(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[Calls(Type = typeof(NPC), Member = "DeserializeAll")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DeserializeAll")]
	[Calls(Type = typeof(Bed), Member = "DeserializeAll")]
	[Calls(Type = typeof(Elevator), Member = "DeserializeAll")]
	[Calls(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[Calls(Type = typeof(Chimney), Member = "DeserializeAll")]
	[Calls(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(ContainerManager), Member = "DisableAll")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "DeserializeAll")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(FireManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BodyHarvestManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[Calls(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[Calls(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(BreakDown), Member = "DeserializeAll")]
	[Calls(Type = typeof(SwitchBoxManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(StickToGround), Member = "DeserializeAll")]
	[Calls(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[Calls(Type = typeof(FlareGunRoundManager), Member = "Deserialize")]
	[Calls(Type = typeof(ArrowManager), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[Calls(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	private static bool LoadSceneData(string name, string sceneSaveName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(BreakDown), Member = "DeserializeAllAdditive")]
	[Calls(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(SaveGameSlots), Member = "LoadDataFromSlot")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	private static void LoadSceneDataAdditive(string name, string sceneSaveName)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 3)]
	public static void SaveScreenshotData(SaveSlotType gameMode, string savename)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallsUnknownMethods(Count = 2)]
	public static void TickScreenshotCoroutine()
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
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

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
	[CalledBy(Type = typeof(Panel_Story), Member = "UpdateSelectedJump")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	public static Texture2D CreateTextureData(ScreenshotSaveGameFormat screenshotData)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CSaveGameCoroutine_003Ed__95), Member = "MoveNext")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "AbortScreenshot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "OnGameManagerShutdown")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CalledBy(Type = typeof(JumpManager._003COnSavingCoroutine_003Ed__37), Member = "MoveNext")]
	[CalledBy(Type = typeof(GameManager), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	public static bool IsWaitingForScreenshot()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
	public static void AbortScreenshot()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "InitAsync")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(SaveGameSlots), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void Init()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "UpdateAutosave")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	[Calls(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	public static void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGameCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "EnqueueAsyncSave")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Break")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsChallengeActive")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(string), Member = "Concat")]
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
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	public static void SaveGame(string name, string sceneSaveName, bool saveFeatData)
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	private static void PrepareSaveData(SaveSlotType gameMode, string name, string sceneSaveName)
	{
	}

	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	private static void PrepareSaveData_Verbose(SaveSlotType gameMode, string name, string sceneSaveName)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static IEnumerator SaveGameCoroutine(string name)
	{
		return null;
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "MaybeSwitchToUninstancedFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetExtraInstancesOfFilename")]
	public static void RestoreGame(string name)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "MigrateSlotOnStart")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
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

	[CalledBy(Type = typeof(Condition_IsStartingNewGame), Member = "OnCheck")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "IsSceneRestoreInProgress")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CallerCount(Count = 4)]
	public static bool IsRestoreInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
	public static bool IsSceneRestoreInProgress()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[CalledBy(Type = typeof(NowhereToHide), Member = "PostEventDeleteSaveSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	public static void DeleteSaveFiles(string name)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteAllSlotsForGameId")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	public static void DeleteSaveFilesForGameId(uint gameId)
	{
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	public static void SetCurrentSaveInfo(Episode episode, SaveSlotType gameMode, uint saveId, string savename)
	{
	}

	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "BuildSlotName")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSaveSlotsFourDaysOfNight")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshChallengeSaveSlots")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "RefreshSandboxSaveSlots")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "NameSandboxGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadActiveSaveGame")]
	[CallsUnknownMethods(Count = 3)]
	public static SaveSlotInfo GetNewestSaveSlotForActiveGame()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static void GetActiveMissionLocId(GlobalSaveGameFormat globalData, ref SaveSlotInfo saveSlotInfo)
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void MaybeSetUserDefinedName(ref SaveSlotInfo saveSlotInfo)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSetUserDefinedName")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetUserDefinedSlotName")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static string SetDefaultUserDefinedSlotName(string slotname)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[CallsUnknownMethods(Count = 9)]
	private static void MaybeSwitchToUninstancedFilename(string slot, string filename)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void SaveCompletedInternal(bool success)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public SaveGameSystem()
	{
	}
}
