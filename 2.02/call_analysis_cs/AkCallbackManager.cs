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

		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 8)]
		public static EventCallbackPackage Create(EventCallback in_cb, object in_cookie, ref uint io_Flags)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkCallbackManager), Member = "RemoveEventCallbackCookie")]
		[CallsUnknownMethods(Count = 1)]
		~EventCallbackPackage()
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public EventCallbackPackage()
		{
		}
	}

	public class BankCallbackPackage
	{
		public BankCallback m_Callback;

		public object m_Cookie;

		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareGameSyncs")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareGameSyncs")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareEvent")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "PrepareBank")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "LoadBank")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 14)]
		[CalledBy(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCommonPlatformSettings), Member = "get_CallbackManagerInitializationSettings")]
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
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "CancelEventCallback")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static void RemoveEventCallback(uint in_playingID)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_CancelEventCallbackCookie")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "CancelEventCallbackCookie")]
	[CalledBy(Type = typeof(EventCallbackPackage), Member = "Finalize")]
	[CallsUnknownMethods(Count = 22)]
	public static void RemoveEventCallbackCookie(object in_cookie)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "CancelBankCallbackCookie")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_CancelBankCallbackCookie")]
	public static void RemoveBankCallback(object in_cookie)
	{
	}

	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceOpen")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "PlayDynamicSequence")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	public static void SetLastAddedPlayingID(uint in_playingID)
	{
	}

	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "ResetSoundEngine")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "InitializeSoundEngine")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public static AKRESULT Init(InitializationSettings settings)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
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

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetBGMCallback(BGMCallback in_CB, object in_cookie)
	{
	}

	[Calls(Type = typeof(EventCallback), Member = "Invoke")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_gameObjID")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_message")]
	[Calls(Type = typeof(MonitoringCallback), Member = "Invoke")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CalledBy(Type = typeof(AkInitializer), Member = "LateUpdate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[CalledBy(Type = typeof(AkWwiseInitializationSettings), Member = "TerminateSoundEngine")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_playingID")]
	[CalledBy(Type = typeof(AkSoundEngineController), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_errorLevel")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_pPackage_get")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_eType_get")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_GetData")]
	[Calls(Type = typeof(AkAudioSourceChangeCallbackInfo), Member = "get_bOtherAudioPlaying")]
	[Calls(Type = typeof(AkMonitoringCallbackInfo), Member = "get_errorCode")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkSerializedCallbackHeader_pNext_get")]
	[Calls(Type = typeof(BGMCallback), Member = "Invoke")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_inMemoryBankPtr")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_loadResult")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_memPoolId")]
	[Calls(Type = typeof(BankCallback), Member = "Invoke")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt64")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AkBankCallbackInfo), Member = "get_bankID")]
	public static int PostCallbacks()
	{
		return default(int);
	}
}
