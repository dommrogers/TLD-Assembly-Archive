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

	private sealed class _003COnSavingCoroutine_003Ed__38 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003COnSavingCoroutine_003Ed__38(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(GameManager), Member = "ForceSaveGame")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
		[Calls(Type = typeof(SaveGameData), Member = "IsSaving")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
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

	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(JumpManager), Member = ".ctor")]
	[CalledBy(Type = typeof(JumpLoadThread), Member = "ExecuteSingleThreaded")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	public static string GetDataPath()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static State GetState()
	{
		return default(State);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[Calls(Type = typeof(File), Member = "Copy")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	public static JumpData Import(string path)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JumpManager), Member = "GetDataPath")]
	[CallsUnknownMethods(Count = 1)]
	public static void Instantiate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(EncryptString), Member = "DecompressBytesToString")]
	[Calls(Type = typeof(File), Member = "ReadAllBytes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "JumpTo")]
	[CallerCount(Count = 0)]
	private void OnLoadComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopAll")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsOverlayActiveImmediate")]
	[Calls(Type = typeof(InterfaceManager), Member = "QuitCurrentScreens")]
	[Calls(Type = typeof(GameManager), Member = "InstantiateSandboxManager")]
	[Calls(Type = typeof(SaveGameSystem), Member = "SetCurrentSaveInfo")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "SetGameModeConfig")]
	[Calls(Type = typeof(GameManager), Member = "LoadSaveGameSlot")]
	[CallsUnknownMethods(Count = 3)]
	private void OnLoadSetup()
	{
	}

	[Calls(Type = typeof(JumpData), Member = "Rename")]
	[Calls(Type = typeof(JumpData), Member = "LoadFromFile")]
	[Calls(Type = typeof(JumpManager), Member = "Rename")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(JumpManager), Member = "CreateJumpFilePath")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Copy")]
	private static void CreateFromCurrentSave(string name)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(JumpManager), Member = "CreateFromCurrentSave")]
	[CalledBy(Type = typeof(JumpManager), Member = "Import")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
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

	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private static string GetChallengeModeName(ChallengeConfig mode)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnSavingCoroutine_003Ed__38))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(File), Member = "InternalWriteAllBytes")]
	[Calls(Type = typeof(EncryptString), Member = "CompressStringToBytes")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(File), Member = "Delete")]
	private static SlotData WriteDataForJump(JumpData jump)
	{
		return null;
	}
}
