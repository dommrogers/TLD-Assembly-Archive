using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class AkCallbackManager
{
	public delegate void EventCallback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);

	public delegate void MonitoringCallback(AkMonitorErrorCode in_errorCode, AkMonitorErrorLevel in_errorLevel, uint in_playingID, ulong in_gameObjID, string in_msg);

	public delegate void BankCallback(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, uint in_memPoolId, object in_Cookie);

	public class EventCallbackPackage
	{
		public bool m_bNotifyEndOfEvent;

		public EventCallback m_Callback;

		public object m_Cookie;

		public uint m_playingID;

		[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		public static EventCallbackPackage Create(EventCallback in_cb, object in_cookie, ref uint io_Flags)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkCallbackManager), Member = "RemoveEventCallbackCookie")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		~EventCallbackPackage()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public EventCallbackPackage()
		{
		}
	}

	public class BankCallbackPackage
	{
		public BankCallback m_Callback;

		public object m_Cookie;

		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareGameSyncs")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareGameSyncs")]
		[CallerCount(Count = 14)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public BankCallbackPackage(BankCallback in_cb, object in_cookie)
		{
		}
	}

	public delegate AKRESULT BGMCallback(bool in_bOtherAudioPlaying, object in_Cookie);

	public class BGMCallbackPackage
	{
		public BGMCallback m_Callback;

		public object m_Cookie;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public BGMCallbackPackage()
		{
		}
	}

	public class InitializationSettings
	{
		public static int DefaultBufferSize;

		public static bool DefaultIsLoggingEnabled;

		public int BufferSize;

		public bool IsLoggingEnabled;

		[CalledBy(Type = typeof(AkBasePlatformSettings), Member = "get_CallbackManagerInitializationSettings")]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_CallbackManagerInitializationSettings")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public InitializationSettings()
		{
		}
	}

	private static bool _003CIsLoggingEnabled_003Ek__BackingField;

	private static readonly AkEventCallbackInfo AkEventCallbackInfo;

	private static readonly AkDynamicSequenceItemCallbackInfo AkDynamicSequenceItemCallbackInfo;

	private static readonly AkMIDIEventCallbackInfo AkMIDIEventCallbackInfo;

	private static readonly AkMarkerCallbackInfo AkMarkerCallbackInfo;

	private static readonly AkDurationCallbackInfo AkDurationCallbackInfo;

	private static readonly AkMusicSyncCallbackInfo AkMusicSyncCallbackInfo;

	private static readonly AkMusicPlaylistCallbackInfo AkMusicPlaylistCallbackInfo;

	private static readonly AkAudioSourceChangeCallbackInfo AkAudioSourceChangeCallbackInfo;

	private static readonly AkMonitoringCallbackInfo AkMonitoringCallbackInfo;

	private static readonly AkBankCallbackInfo AkBankCallbackInfo;

	private static readonly Dictionary<int, EventCallbackPackage> m_mapEventCallbacks;

	private static readonly Dictionary<int, BankCallbackPackage> m_mapBankCallbacks;

	private static EventCallbackPackage m_LastAddedEventPackage;

	private static IntPtr m_pNotifMem;

	private static MonitoringCallback m_MonitoringCB;

	private static BGMCallbackPackage ms_sourceChangeCallbackPkg;

	private static bool IsLoggingEnabled
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "CancelEventCallback")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 23)]
	public static void RemoveEventCallback(uint in_playingID)
	{
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "CancelEventCallbackCookie")]
	[CalledBy(Type = typeof(EventCallbackPackage), Member = "Finalize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_CancelEventCallbackCookie")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public static void RemoveEventCallbackCookie(object in_cookie)
	{
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "CancelBankCallbackCookie")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_CancelBankCallbackCookie")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public static void RemoveBankCallback(object in_cookie)
	{
	}

	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetLastAddedPlayingID(uint in_playingID)
	{
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static AKRESULT Init(InitializationSettings settings)
	{
		return default(AKRESULT);
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void Term()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetMonitoringCallback(AkMonitorErrorLevel in_Level, MonitoringCallback in_CB)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie)
	{
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "LateUpdate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_pPackage_get")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_eType_get")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_GetData")]
	[Calls(Type = typeof(AkAudioSourceChangeCallbackInfo), Member = "get_bOtherAudioPlaying")]
	[Calls(Type = typeof(BGMCallback), Member = "Invoke")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_pNext_get")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_bankID")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_inMemoryBankPtr")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_loadResult")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_memPoolId")]
	[Calls(Type = typeof(BankCallback), Member = "Invoke")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt64")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_errorCode")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_errorLevel")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_gameObjID")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_message")]
	[Calls(Type = typeof(MonitoringCallback), Member = "Invoke")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EventCallback), Member = "Invoke")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 40)]
	public static int PostCallbacks()
	{
		return 0;
	}
}
