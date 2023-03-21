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
using TLD.Gameplay.Condition;
using TLD.Gear;
using TLD.Logging;
using TLD.OptionalContent;
using TLD.SaveState;
using TLD.Serialization;
using TLD.Stats;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGameSystem
{
	public delegate void SaveCompletedDelegate();

	private enum UserInitializationStage
	{
		LoadingProfile,
		ValidatingProfile,
		LoadingSettings,
		Done
	}

	private sealed class _003CSaveGameCoroutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string name;

		private Stopwatch _003Cwatch_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CSaveGameCoroutine_003Ed__53(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Stopwatch), Member = "Stop")]
		[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
		[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CSaveScreenshotDataCoroutine_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CSaveScreenshotDataCoroutine_003Ed__115(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(RenderTexture), Member = "GetTemporaryImpl")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
		[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
		[Calls(Type = typeof(Graphics), Member = "Blit")]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
		[CallsDeduplicatedMethods(Count = 7)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
		[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
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

	private static BootSaveGameFormat m_BootSaveGameFormat;

	public static LogFilter s_LogFilter;

	public static string m_SlotToLoadOnStart;

	public static string m_MigrateSlotOnStart;

	public static bool m_CanMigrateSave;

	public static bool m_SceneRestoreInProgress;

	public static bool m_DidSceneRestore;

	public static int m_GlobalSaveGameFormatVersion;

	public static int m_SceneSaveGameFormatVersion;

	public static Episode m_CurrentEpisode;

	public static SaveSlotType m_CurrentGameMode;

	public static uint m_CurrentGameId;

	public static string m_CurrentSaveName;

	public static bool m_EnableSaveLoad;

	public static SaveCompletedDelegate m_OnSaveCompletedEvent;

	public static bool s_Initialized;

	private static bool s_DebugVerbose;

	private static GlobalSaveGameFormat m_GlobalSaveGameFormat;

	private static InfoSaveGameFormat m_InfoSaveGameFormat;

	private const string PROFILE_DISPLAYNAME = "Profile (Survival)";

	public const string DEFAULT_PROFILE_FILENAME = "profile_survival";

	public const string LEGACY_PROFILE_FILENAME = "user001";

	private const int SPLIT_PROFILE_VERSION = 100;

	public static string s_ProfileFilename;

	public static string s_LegacyProfileFileName;

	private static bool _003CIsLoadingUserProfile_003Ek__BackingField;

	private static SceneSaveGameFormat m_SceneSaveGameFormat;

	private static SlotData m_ScreenshotSlot;

	private static IEnumerator s_ScreenshotCoroutine;

	private static ScreenshotSaveGameFormat m_ScreenshotSaveGameFormat;

	private const string SETTINGS_DISPLAYNAME = "Settings (Survival)";

	public const string DEFAULT_SETTINGS_FILENAME = "settings_survival";

	public static string s_SettingsFilename;

	private static bool _003CIsLoadingUserSettings_003Ek__BackingField;

	private static UserInitializationStage m_InitializationStage;

	private static bool IsLoadingUserProfile
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	private static bool IsLoadingUserSettings
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public static bool IsInitializingUser
	{
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	public static bool IsAsyncEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "SaveShouldBePending")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	public static bool IsAsyncSaveRunning()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetAsyncEnabled")]
	[CalledBy(Type = typeof(GameManager), Member = "OnGameQuit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ShutdownAsync")]
	[CalledBy(Type = typeof(GameManager), Member = "OnApplicationQuit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	public static void WaitForAsyncSave()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	public static void SetAsyncEnabled(bool enabled)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitForAsyncSave")]
	[CallsUnknownMethods(Count = 1)]
	public static void ShutdownAsync()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	private static void EnqueueAsyncSave(string slotName)
	{
	}

	[Calls(Type = typeof(Thread), Member = "Start")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Init")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor")]
	[Calls(Type = typeof(Thread), Member = "SetStartHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	private static void InitAsync()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void LogIsAsyncEnabled()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleNextAsyncSlot")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "Memcpy")]
	private static void ExecuteAsyncSaving()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ExecuteAsyncSaving")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static bool HandleNextAsyncSlot(out string slotName)
	{
		slotName = null;
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSavePending")]
	[Calls(Type = typeof(CameraFade), Member = "UpdateFade")]
	[Calls(Type = typeof(SaveGameSystem), Member = "TickScreenshotCoroutine")]
	[Calls(Type = typeof(SaveGameSystem), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	public static void WaitAsyncSaveComplete(string slotName)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private static bool IsAsyncSavePending(string slotName)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsAsyncSaveRunning")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGameCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private static void UpdateAsync()
	{
	}

	[CallerCount(Count = 0)]
	public static void OnGameManagerShutdown()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	public static void ResetAutosaveTimer()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static float SecondsUntilNextAutosave()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateAutosave()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	private static void SaveBootData(SlotData slot)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(SaveGameSystem), Member = "InitAsync")]
	[Calls(Type = typeof(SaveGameDataPC), Member = "InitializeUserProfile")]
	[Calls(Type = typeof(SaveGameData), Member = "AddLoadingPriorityPattern")]
	[Calls(Type = typeof(SaveGameData), Member = "AddLoadingPriorityPattern")]
	[Calls(Type = typeof(SaveGameData), Member = "AddLoadingPriorityPattern")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlot")]
	public static void Init()
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "UpdateUserInitialization")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveGameDataProcess")]
	public static void Update()
	{
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGameCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "Break")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerAutosaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "TriggerQuicksaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveProfile")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "IsChallengeActive")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetExtraInstancesOfFilename")]
	[Calls(Type = typeof(SaveGameSlots), Member = "FindOrCreateSlotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGeneralData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveCompletedInternal")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFailedSaveNotification")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	public static void SaveGame(string name, string sceneSaveName)
	{
	}

	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGeneralData")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	private static void PrepareSaveData(SlotData slot, string sceneSaveName)
	{
	}

	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveInfoData")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveScreenshotData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveBootData")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SaveGeneralData")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	private static void PrepareSaveData_Verbose(SlotData slot, string sceneSaveName)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(OptionalContentManager), Member = "get_Instance")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(OptionalContentManager), Member = "TryFindConfig")]
	private static void SaveGeneralData(SlotData slot)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateAsync")]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(_003CSaveGameCoroutine_003Ed__53))]
	[CallerCount(Count = 2)]
	private static IEnumerator SaveGameCoroutine(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSlotOnStart")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[Calls(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataPostSceneRestore")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LogInRelease")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetExtraInstancesOfFilename")]
	public static void RestoreGame(string name)
	{
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "ShowSaveGameFaileLoadNotification")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "MigrateSlotOnStart")]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "DoExitToMainMenu")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(SaveGameSystem), Member = "RestoreGlobalDataForEspisodeMigration")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static void RestoreGameForEpisodeMigration(string name)
	{
	}

	[CallerCount(Count = 0)]
	public static void ResetForSceneLoad()
	{
	}

	[CallerCount(Count = 0)]
	public static void ConfigureRestoreFromSlot(string slotName)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(HUDManager._003CWaitToShowLocationReveal_003Ed__27), Member = "MoveNext")]
	[CalledBy(Type = typeof(Condition_IsStartingNewGame), Member = "OnCheck")]
	public static bool IsRestoreInProgress()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsSceneRestoreInProgress()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NowhereToHide), Member = "PostEventDeleteSaveSlot")]
	[CalledBy(Type = typeof(PostSpecialEvent), Member = "ManageSaveData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(SaveGameSlotHelper), Member = "DeleteSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "ClearAutoSave")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "DeleteSelectedSave")]
	public static void DeleteSaveFiles(string name)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(SaveGameSlots), Member = "DeleteSlot")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void DeleteSaveFilesForGameId(uint gameId)
	{
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CalledBy(Type = typeof(JumpManager), Member = "OnLoadSetup")]
	[CalledBy(Type = typeof(GameManager), Member = "OnLoadGameCallback")]
	[CalledBy(Type = typeof(GameManager), Member = "ForceSaveGame")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_story")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sandbox")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_xpmode")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnNewSandbox")]
	[CalledBy(Type = typeof(Panel_Sandbox), Member = "OnClickNew")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "OverwriteSelectedSave")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnOverwriteSaveNamed")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnNewChallenge")]
	[CalledBy(Type = typeof(Panel_Challenges), Member = "OnClickNew")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSaveName")]
	[CallerCount(Count = 17)]
	public static void SetCurrentSaveInfo(Episode episode, SaveSlotType gameMode, uint saveId, string savename)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SaveGameSlots), Member = "BuildSlotName")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSaveNamed")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	public static void GenerateNewSaveName()
	{
	}

	[CallerCount(Count = 0)]
	public static string GetCurrentSaveName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	public static List<SaveSlotInfo> GetSortedSaveSlotsForEpisodes(SaveSlotType slotType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlots")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	public static List<SaveSlotInfo> GetSortedSaveSlots(Episode episode, SaveSlotType slotType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSortedSaveSlotsForEpisodes")]
	[CallsUnknownMethods(Count = 4)]
	public static SaveSlotInfo GetNewestSaveSlotForActiveGame()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "LoadData")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "ShowProfileLoadError")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsSettingsFilename")]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "CreateSlotFromData")]
	public static SaveGameOperationReturnValue TryLoadDataString(string dataAsString, string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	private static void GetActiveMissionLocId(GlobalSaveGameFormat globalData, ref SaveSlotInfo saveSlotInfo)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetDefaultUserDefinedSlotName")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetUserDefinedSlotName")]
	[CallerCount(Count = 0)]
	private static void MaybeSetUserDefinedName(ref SaveSlotInfo saveSlotInfo)
	{
	}

	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "MaybeSetUserDefinedName")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CreateSaveSlotInfo")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SetUserDefinedSlotName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string SetDefaultUserDefinedSlotName(string slotname)
	{
		return null;
	}

	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains")]
	private static void MaybeSwitchToUninstancedFilename(string slot, string filename)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	private static void SaveCompletedInternal(bool success)
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsDebugVerbose()
	{
		return default(bool);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void LogVerbose(string msg)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void WarningInRelease(string msg)
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 20)]
	public static void LogInRelease(string msg)
	{
	}

	[CallerCount(Count = 0)]
	public static void ToggleDebugVerbose()
	{
	}

	[Calls(Type = typeof(RockCacheManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(NPC), Member = "HasActive")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(TrustManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SkillsManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SnowfallManager), Member = "Serialize")]
	[Calls(Type = typeof(Headache), Member = "Serialize")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(InsomniaManager), Member = "Serialize")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SceneManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 90)]
	[Calls(Type = typeof(Panel_Map), Member = "Serialize")]
	[Calls(Type = typeof(SceneManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FireManager), Member = "SerializeChimneyData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(PlayerClimbRope), Member = "Serialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Serialize")]
	[Calls(Type = typeof(Inventory), Member = "Serialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Serialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(WeatherTransition), Member = "Serialize")]
	[Calls(Type = typeof(Weather), Member = "Serialize")]
	[Calls(Type = typeof(Wind), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(GameManager), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(TimeOfDay), Member = "Serialize")]
	[Calls(Type = typeof(Frostbite), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Serialize")]
	[Calls(Type = typeof(AchievementManager), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Rest), Member = "Serialize")]
	[Calls(Type = typeof(Log), Member = "Serialize")]
	[Calls(Type = typeof(InfectionRisk), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BrokenRib), Member = "Serialize")]
	[Calls(Type = typeof(Infection), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(SprainPain), Member = "Serialize")]
	[Calls(Type = typeof(SprainedWrist), Member = "Serialize")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(BloodLoss), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	private static void SaveGlobalData(SlotData slot)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Start")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateElectrolizerState")]
	[Calls(Type = typeof(Headache), Member = "Deserialize")]
	[Calls(Type = typeof(vp_FPSPlayer), Member = "SnapToCrouch")]
	[Calls(Type = typeof(PlayerMovement), Member = "Start")]
	[Calls(Type = typeof(AuroraManager), Member = "UpdateAuroraValue")]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraManager), Member = "GetForceDisableForNewGame")]
	[Calls(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(AuroraScreenManager), Member = "Deserialize")]
	[Calls(Type = typeof(InsomniaManager), Member = "Deserialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 77)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(MissionServicesManager), Member = "AfterGlobalDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BearHuntRedux), Member = "Reset")]
	[Calls(Type = typeof(NotificationFlagManager), Member = "Deserialize")]
	[Calls(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[Calls(Type = typeof(Panel_Map), Member = "Deserialize")]
	[Calls(Type = typeof(ToxicFogManager), Member = "Deserialize")]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(RockCacheManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(BodyCarry), Member = "Deserialize")]
	[Calls(Type = typeof(PhoneManager), Member = "Reset")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "Deserialize")]
	[Calls(Type = typeof(AchievementManager), Member = "Deserialize")]
	[Calls(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(Log), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(WeatherTransition), Member = "Deserialize")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "SetWeatherStage")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(Encumber), Member = "Deserialize")]
	[Calls(Type = typeof(Wind), Member = "Deserialize")]
	[Calls(Type = typeof(HUDManager), Member = "SetHUDDisplayMode")]
	[Calls(Type = typeof(GameManager), Member = "Deserialize")]
	[Calls(Type = typeof(SceneManager), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "ResetFlyoverTimer")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(Hunger), Member = "Start")]
	[Calls(Type = typeof(Condition), Member = "Start")]
	[Calls(Type = typeof(Fatigue), Member = "Deserialize")]
	[Calls(Type = typeof(CabinFever), Member = "Deserialize")]
	[Calls(Type = typeof(InfectionRisk), Member = "Deserialize")]
	[Calls(Type = typeof(Infection), Member = "Deserialize")]
	[Calls(Type = typeof(BrokenRib), Member = "Deserialize")]
	[Calls(Type = typeof(BloodLoss), Member = "Deserialize")]
	[Calls(Type = typeof(Thirst), Member = "Deserialize")]
	[Calls(Type = typeof(SprainedAnkle), Member = "Deserialize")]
	[Calls(Type = typeof(SprainPain), Member = "Deserialize")]
	[Calls(Type = typeof(SprainedWrist), Member = "Deserialize")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Deserialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Deserialize")]
	[Calls(Type = typeof(Freezing), Member = "Deserialize")]
	[Calls(Type = typeof(Frostbite), Member = "Deserialize")]
	private static bool RestoreGlobalData(string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGameForEpisodeMigration")]
	[Calls(Type = typeof(BlueprintManager), Member = "Deserialize")]
	[Calls(Type = typeof(TrustManager), Member = "Deserialize")]
	[Calls(Type = typeof(FeatEnabledTracker), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerSkills), Member = "Deserialize")]
	[Calls(Type = typeof(StatsManager), Member = "DeserializeCurrentSession")]
	[Calls(Type = typeof(AchievementManager), Member = "Deserialize")]
	[Calls(Type = typeof(SkillsManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayerManager), Member = "Deserialize")]
	[Calls(Type = typeof(Inventory), Member = "Deserialize")]
	[Calls(Type = typeof(CollectionManager), Member = "Deserialize")]
	[Calls(Type = typeof(KnowledgeManager), Member = "Deserialize")]
	[Calls(Type = typeof(TimeOfDay), Member = "Deserialize")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Log), Member = "Deserialize")]
	private static bool RestoreGlobalDataForEspisodeMigration(string name)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(LeanToManager), Member = "ForceIntoLeanToSilent")]
	[Calls(Type = typeof(SnowShelterManager), Member = "ForceIntoSnowShelterSilent")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FireManager), Member = "DeserializeChimneyData")]
	private static void RestoreGlobalDataPostSceneRestore(string name)
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetActiveStoryMissionInfo")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(StatContainer), Member = "GetValue")]
	private static void SaveInfoData(SlotData slot)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
	private static void LoadUserProfile()
	{
	}

	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static void HandleCheckIfProfileExists(bool dataExists, string name)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnProfileLoaded")]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowProfileLoadError()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static void OnLoadErrorConfirm()
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "ShowProfileLoadError")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[Calls(Type = typeof(ProfileState), Member = ".ctor")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleCheckIfProfileExists")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "ShowProfileLoadError")]
	public static void HandleOnProfileLoaded(string profileData)
	{
	}

	[Calls(Type = typeof(ProfileState), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static ProfileState GenerateNewProfile()
	{
		return null;
	}

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[CallsUnknownMethods(Count = 1)]
	public static void SaveProfile()
	{
	}

	[CalledBy(Type = typeof(SaveGameDataPC), Member = "DataExists")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "CloudFileRequiresSync")]
	[CalledBy(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SaveGameSystem), Member = "IsLegacyProfileFilename")]
	public static bool IsProfileFilename(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "IsProfileFilename")]
	public static bool IsLegacyProfileFilename(string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(TintMaterials), Member = "SerializeAll")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "SerializeAll")]
	[Calls(Type = typeof(Bed), Member = "SerializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(NPC), Member = "SerializeAll")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "SerializeAll")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SerializeAll")]
	[Calls(Type = typeof(PackManager), Member = "Serialize")]
	[Calls(Type = typeof(ScriptLight), Member = "SerializeAll")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "Serialize")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "SerializeAll")]
	[Calls(Type = typeof(EntityWard), Member = "SerializeAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "SerializeAll")]
	[Calls(Type = typeof(SteamPipeManager), Member = "SerializeAll")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[Calls(Type = typeof(Elevator), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[Calls(Type = typeof(BearEncounter), Member = "SerializeAll")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(SteamPipeValveManager), Member = "SerializeAll")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpawnGearVariant), Member = "Serialize")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "SerializeAll")]
	[Calls(Type = typeof(WolfDen), Member = "SerializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "SerializeAll")]
	[Calls(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(MapDetailManager), Member = "Serialize")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "Serialize")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Serialize")]
	[Calls(Type = typeof(WaterSourceManager), Member = "Serialize")]
	[Calls(Type = typeof(RandomSpawnObjectManager), Member = "Serialize")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "SerializeAll")]
	[Calls(Type = typeof(LoadSceneParent), Member = "SerializeAll")]
	[Calls(Type = typeof(LoadScene), Member = "SerializeAll")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "Serialize")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "SerializeAll")]
	[Calls(Type = typeof(FlareGunRoundManager), Member = "Serialize")]
	[Calls(Type = typeof(ArrowManager), Member = "Serialize")]
	[Calls(Type = typeof(GearManager), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ContainerManager), Member = "Serialize")]
	[Calls(Type = typeof(BreakableIce), Member = "SerializeAll")]
	[Calls(Type = typeof(FireManager), Member = "Serialize")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "Serialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HarvestableManager), Member = "SerializeAll")]
	[Calls(Type = typeof(IceFishingHole), Member = "SerializeAll")]
	[Calls(Type = typeof(BaseAiManager), Member = "Serialize")]
	[Calls(Type = typeof(RockCacheManager), Member = "SerializeAll")]
	[Calls(Type = typeof(LeanToManager), Member = "SerializeAll")]
	[Calls(Type = typeof(SnowShelterManager), Member = "SerializeAll")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Serialize")]
	[Calls(Type = typeof(Chimney), Member = "SerializeAll")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SerializeAll")]
	[Calls(Type = typeof(StickToGround), Member = "SerializeAll")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "SerializeAll")]
	[Calls(Type = typeof(BreakDown), Member = "SerializeAll")]
	[Calls(Type = typeof(SwitchBoxManager), Member = "SerializeAll")]
	[Calls(Type = typeof(OpenCloseManager), Member = "SerializeAll")]
	[Calls(Type = typeof(ReplaceMaterialsManager), Member = "SerializeAll")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "SerializeAll")]
	private static void SaveSceneData(SlotData slot, string sceneSaveName)
	{
	}

	[Calls(Type = typeof(AuroraElectrolizerController), Member = "DeserializeAll")]
	[Calls(Type = typeof(PackManager), Member = "Deserialize")]
	[Calls(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[Calls(Type = typeof(ScriptLight), Member = "DeserializeAll")]
	[Calls(Type = typeof(CarcassSite.Manager), Member = "Deserialize")]
	[Calls(Type = typeof(AuroraFieldsSceneManager), Member = "Deserialize")]
	[Calls(Type = typeof(MapDetailManager), Member = "Deserialize")]
	[Calls(Type = typeof(BearEncounter), Member = "DeserializeAll")]
	[Calls(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[Calls(Type = typeof(ActiveSwitch), Member = "DeserializeAll")]
	[Calls(Type = typeof(PrefabSpawn), Member = "DeserializeAll")]
	[Calls(Type = typeof(LeanToManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "DeserializeAll")]
	[Calls(Type = typeof(SpawnWildlife_Trigger), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(Bed), Member = "DeserializeAll")]
	[Calls(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(Bed), Member = "PostDeserialize")]
	[Calls(Type = typeof(SpawnGearVariant), Member = "Deserialize")]
	[Calls(Type = typeof(GearItemInteractabilityControl), Member = "DeserializeAll")]
	[Calls(Type = typeof(WolfDen), Member = "DeserializeAll")]
	[Calls(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Elevator), Member = "DeserializeAll")]
	[Calls(Type = typeof(SteamPipeValveManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(EntityWard), Member = "DeserializeAll")]
	[Calls(Type = typeof(TintMaterials), Member = "DeserializeAll")]
	[Calls(Type = typeof(NPC), Member = "DeserializeAll")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "DeserializeAll")]
	[Calls(Type = typeof(InteractiveLightsource), Member = "DeserializeAll")]
	[Calls(Type = typeof(FootstepTrailManager), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(RopeAnchorPoint), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(SaveGameSlots), Member = "HasFilenameInSlot")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[Calls(Type = typeof(FireManager), Member = "Deserialize")]
	[Calls(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(GearManager), Member = "DeleteAllActive")]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	[Calls(Type = typeof(RockCacheManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(ContainerManager), Member = "DisableAll")]
	[Calls(Type = typeof(ContainerManager), Member = "Deserialize")]
	[Calls(Type = typeof(WaterSourceManager), Member = "Deserialize")]
	[Calls(Type = typeof(PlayAudioTrigger), Member = "DeserializeAll")]
	[Calls(Type = typeof(Chimney), Member = "DeserializeAll")]
	[Calls(Type = typeof(LoadSceneParent), Member = "DeserializeAll")]
	[Calls(Type = typeof(LoadScene), Member = "DeserializeAll")]
	[Calls(Type = typeof(DisplayLocationLabel), Member = "DeserializeAll")]
	[Calls(Type = typeof(StickToGround), Member = "DeserializeAll")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(BreakDown), Member = "DeserializeAll")]
	[Calls(Type = typeof(SwitchBoxManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(RandomSpawnObjectManager), Member = "Deserialize")]
	[Calls(Type = typeof(ReplaceMaterialsManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(OpenCloseManager), Member = "DeserializeAll")]
	[Calls(Type = typeof(IceFishingHole), Member = "DeserializeAll")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "Deserialize")]
	[Calls(Type = typeof(FlareGunRoundManager), Member = "Deserialize")]
	[Calls(Type = typeof(ArrowManager), Member = "Deserialize")]
	[Calls(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[Calls(Type = typeof(SpawnRegionManager), Member = "Deserialize")]
	[Calls(Type = typeof(HarvestableManager), Member = "DeserializeAll")]
	private static bool LoadSceneData(string name, string sceneSaveName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGame")]
	[Calls(Type = typeof(BreakDown), Member = "DeserializeAll")]
	[Calls(Type = typeof(ContainerManager), Member = "DeserializeAdditive")]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearManager), Member = "Deserialize")]
	private static void LoadSceneDataAdditive(string name, string sceneSaveName)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGame")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "PrepareSaveData_Verbose")]
	[CallsUnknownMethods(Count = 2)]
	public static void SaveScreenshotData(SlotData slot)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "WaitAsyncSaveComplete")]
	public static void TickScreenshotCoroutine()
	{
	}

	[IteratorStateMachine(typeof(_003CSaveScreenshotDataCoroutine_003Ed__115))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static IEnumerator SaveScreenshotDataCoroutine()
	{
		return null;
	}

	[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SaveGameSlots), Member = "GetSaveSlotFromName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "FromBase64CharPtr")]
	public static Texture2D CreateTextureData(string savename)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "FromBase64CharPtr")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsUnknownMethods(Count = 6)]
	public static Texture2D CreateTextureData(ScreenshotSaveGameFormat screenshotData)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static bool IsWaitingForScreenshot()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void AbortScreenshot()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "LoadData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "UpdateUserInitialization")]
	public static void LoadUserSettings()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSettings")]
	[Calls(Type = typeof(SaveGameSystem), Member = "GenerateNewSettings")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	public static void HandleOnSettingsLoaded(string settingsData)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(SettingsState), Member = ".ctor")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CallsUnknownMethods(Count = 2)]
	private static SettingsState GenerateNewSettings()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SaveGameData), Member = "SaveData")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SaveSettings()
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase")]
	[CalledBy(Type = typeof(SaveGameData), Member = "MaybeDisplayErrorNotification")]
	[CalledBy(Type = typeof(SaveGameDataPC), Member = "GetFullPath")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "TryLoadDataString")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager), Member = "CloudFileRequiresSync")]
	public static bool IsSettingsFilename(string name)
	{
		return default(bool);
	}

	[Calls(Type = typeof(SaveGameData), Member = "DataExists")]
	[CallerCount(Count = 0)]
	public static void InitializeUser()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SaveGameDataPC), Member = "ValidateUserProfile")]
	[Calls(Type = typeof(SaveGameSystem), Member = "LoadUserSettings")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "Update")]
	private static void UpdateUserInitialization()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SaveGameSystem()
	{
	}
}
