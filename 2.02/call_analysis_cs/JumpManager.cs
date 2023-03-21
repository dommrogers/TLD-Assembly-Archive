using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

public class JumpManager
{
	public enum State
	{
		Idle,
		Loading,
		Saving
	}

	private enum SaveStage
	{
		Prepare,
		Start,
		Write,
		Complete
	}

	private sealed class _003COnSavingCoroutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003COnSavingCoroutine_003Ed__37(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 10)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
		[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
		[Calls(Type = typeof(Utils), Member = "IsZero")]
		[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
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

	public static readonly uint SAVE_SLOT;

	private static JumpManager s_Instance;

	private static string s_DataPath;

	private bool m_AllowCreation;

	private string m_LastJumpFile;

	private State m_State;

	private JumpLoadThread m_JumpLoadThread;

	private SlotData m_LoadSlotData;

	private SaveSlotInfo m_LoadSlotInfo;

	private SaveStage m_SaveStage;

	private string m_SaveName;

	private bool m_RestoreAsyncSave;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	protected JumpManager()
	{
	}

	[CalledBy(Type = typeof(JumpManager), Member = "Reload")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rejump")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rejump")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool CanReload()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ClearLoadThread()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool Create(string name = null)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(JumpManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "Instantiate")]
	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadAllJumpData")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	public static string GetDataPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static State GetState()
	{
		return default(State);
	}

	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[CallsUnknownMethods(Count = 1)]
	public static JumpData Import(string path)
	{
		return null;
	}

	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void Instantiate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static JumpManager Instance()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsCreationAllowed()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(JumpManager), Member = "StopJumpLoadAsync")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadAllJumpData")]
	[CalledBy(Type = typeof(Panel_Story), Member = "CanSwitchView")]
	[CalledBy(Type = typeof(Panel_Story), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Story), Member = "CancelAsyncLoad")]
	public static bool IsAsyncLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Story), Member = "DoFileJump")]
	public static bool Load(JumpData jump)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "CanReload")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reload()
	{
	}

	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static bool Rename(string path, string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCreationAllowed(bool allow)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StartJumpLoadAsync(JumpLoadCompleteDelegate onComplete)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	public static void StopJumpLoadAsync()
	{
	}

	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsUnknownMethods(Count = 20)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnLoadComplete()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	private void OnLoadSetup()
	{
	}

	[Calls(Type = typeof(JumpManager), Member = "Rename")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(JumpData), Member = "Rename")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void CreateFromCurrentSave(string name)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	private static string CreateJumpFilePath(SaveSlotType mode, ExperienceModeType xpmode, Episode episode = Episode.One)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetEpisodeName(Episode episode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetExperienceModeName(ExperienceModeType mode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	private static IEnumerator OnSavingCoroutine()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpData), Member = "Rename")]
	[CallsUnknownMethods(Count = 1)]
	private static void Validate(string path)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private static SlotData WriteDataForJump(JumpData jump)
	{
		return null;
	}
}
