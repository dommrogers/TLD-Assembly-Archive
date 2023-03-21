using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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
		public _003COnSavingCoroutine_003Ed__37(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
		[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
		[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
		[Calls(Type = typeof(Utils), Member = "IsZero")]
		[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
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
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected JumpManager()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rejump")]
	[CalledBy(Type = typeof(JumpManager), Member = "Reload")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool CanReload()
	{
		return false;
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
		return false;
	}

	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadAllJumpData")]
	[CalledBy(Type = typeof(JumpManager), Member = ".ctor")]
	[CalledBy(Type = typeof(JumpManager), Member = "Instantiate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static JumpData Import(string path)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
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
		return false;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "CancelAsyncLoad")]
	[CalledBy(Type = typeof(Panel_Story), Member = "CanSwitchView")]
	[CalledBy(Type = typeof(Panel_Story), Member = "LoadAllJumpData")]
	[CalledBy(Type = typeof(Panel_Story), Member = "Update")]
	[CalledBy(Type = typeof(JumpManager), Member = "StopJumpLoadAsync")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsAsyncLoading()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Story), Member = "DoFileJump")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool Load(JumpData jump)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "CanReload")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reload()
	{
	}

	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool Rename(string path, string name)
	{
		return false;
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
	[Calls(Type = typeof(JumpManager), Member = "IsAsyncLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void StopJumpLoadAsync()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	private void OnLoadComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(EpisodeManager), Member = "SetActiveEpisode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private void OnLoadSetup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(JumpManager), Member = "Rename")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpData), Member = "Rename")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void CreateFromCurrentSave(string name)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CallerCount(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatUInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static SlotData WriteDataForJump(JumpData jump)
	{
		return null;
	}
}
