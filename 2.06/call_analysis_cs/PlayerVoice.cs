using System;
using System.Collections.Generic;
using System.Diagnostics;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;
using Voice;

public class PlayerVoice : MonoBehaviour
{
	public enum Options : uint
	{
		None = 0u,
		AllowDuringCinematic = 1u,
		AllowEqualPriorityOverride = 2u,
		AllowHeavyBreathing = 4u,
		AllowWhenAiming = 8u,
		AllowWhenClimbing = 0x10u,
		AllowWhenHeavingBreathing = 0x20u,
		IgnoreNonCriticalDelay = 0x40u,
		AllowWhenAllSpeechDisable = 0x80u
	}

	public enum Reason
	{
		Failed,
		Finished,
		Ignored,
		Interrupted,
		Queued,
		Start
	}

	public delegate void RequestEventDelegate(Request request, Reason reason);

	public delegate void VoicePersonaChangedDelegate(VoicePersona persona);

	private static readonly LogFilter s_logFilter;

	public RequestEventDelegate m_EventTrigger;

	public VoicePersonaChangedDelegate m_VoicePersonaChanged;

	public float m_MinSecondsBetweenNonCriticalLines;

	public float m_NonCriticalVoiceQueueTimeout;

	public float m_ForcedSubtitleDelayTime;

	public float m_TimeoutBufferDuration;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	public float m_LastPlayTime;

	public static bool s_DebugVerbose;

	private float m_BlockNonCriticalLineTime;

	private float m_NextNonCriticalLineTime;

	private bool m_HasUpdatedFirstFrame;

	private Priority m_RestrictedPriority;

	private float m_SubtitleEventDelay;

	private bool m_WasCinematicActive;

	private ActiveRequest m_ActiveRequest;

	private Request m_NextRequest;

	private List<Request> m_Queue;

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Action_BlockNonCriticalVoiceOver), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void BlockNonCriticalVoiceForDuration(float duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public ActiveRequest GetActiveRequest()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public float GetNonCriticalDelayTime()
	{
		return default(float);
	}

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public List<Request> GetQueue()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public Priority GetRestrictedPriority()
	{
		return default(Priority);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSpeaking()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 65)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingTeethChatter")]
	[CalledBy(Type = typeof(Fatigue), Member = "CatchBreath")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	public uint Play(uint eventID, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "PlayDelayedVoiceOver")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public bool Queue(AK.Wwise.Event audioEvent, Priority priority, Action completionCallback = null)
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Action_PlayerSay), Member = "DoSay")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	public bool Queue(string eventName, Priority priority, Action completionCallback = null)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void RestrictBelowPriority(Priority priority)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_female")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_male")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public void SetPlayerVoicePersona()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	public void Stop(uint playingID)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 1)]
	public void StopBelowPriority(Priority priority)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Request), Member = "Copy")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StopBelowPriority")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Stop")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	private void CompleteActiveRequest()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayPlayerVoiceEvents")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNonCriticalVoiceLine")]
	private bool CanPlayNextRequest()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallsUnknownMethods(Count = 5)]
	private bool CanPlayNonCriticalVoiceLine()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	private bool CanPlayPlayerVoiceEvents()
	{
		return default(bool);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EventTrigger(Request request, Reason reason)
	{
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool HandleNextRequest()
	{
		return default(bool);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private void LogRequestIgnored(string reason)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(Request), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void MaybeHandleNextQueuedRequest()
	{
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void MaybeShowInitialSubtitle(string eventName)
	{
	}

	[Calls(Type = typeof(Request), Member = "Copy")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	private bool StartNextRequest()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	private void UpdateActive()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateQueued()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public PlayerVoice()
	{
	}
}
