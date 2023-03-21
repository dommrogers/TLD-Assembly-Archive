using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Encryption;
using TLD.Gameplay;
using TLD.Logging;
using TLD.Serialization;
using UnityEngine;

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

	private sealed class _003COnSavingCoroutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003COnSavingCoroutine_003Ed__38(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
		[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
		[Calls(Type = typeof(SaveGameSystem), Member = "IsWaitingForScreenshot")]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static readonly LogFilter s_JumpLogFilter;

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
	protected JumpManager()
	{
	}

	[CallerCount(Count = 0)]
	public static bool CanReload()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void ClearLoadThread()
	{
	}

	[CallerCount(Count = 0)]
	public static bool Create(string name = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "Instantiate")]
	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(JumpManager), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	public static string GetDataPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static State GetState()
	{
		return default(State);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[CallsUnknownMethods(Count = 1)]
	public static JumpData Import(string path)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
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
	public static bool IsCreationAllowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsAsyncLoading()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool Load(JumpData jump)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void Reload()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static bool Rename(string path, string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static void SetCreationAllowed(bool allow)
	{
	}

	[CallerCount(Count = 0)]
	public static void StartJumpLoadAsync(JumpLoadCompleteDelegate onComplete)
	{
	}

	[CallerCount(Count = 0)]
	public static void StopJumpLoadAsync()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnLoadComplete()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	private void OnLoadSetup()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(JumpManager), Member = "Rename")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpData), Member = "Rename")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	private static void CreateFromCurrentSave(string name)
	{
	}

	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	private static string CreateJumpFilePath(SaveSlotType mode, GameModeConfig xpmode, Episode episode = Episode.One)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private static string GetEpisodeName(Episode episode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	private static string GetChallengeModeName(ChallengeConfig mode)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[IteratorStateMachine(typeof(_003COnSavingCoroutine_003Ed__38))]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	private static SlotData WriteDataForJump(JumpData jump)
	{
		return null;
	}
}
