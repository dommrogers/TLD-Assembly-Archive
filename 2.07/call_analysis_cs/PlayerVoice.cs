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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_BlockNonCriticalVoiceOver), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	public List<Request> GetQueue()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 66)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingTeethChatter")]
	[CalledBy(Type = typeof(Fatigue), Member = "CatchBreath")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	public uint Play(uint eventID, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "PlayDelayedVoiceOver")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 2)]
	public bool Queue(AK.Wwise.Event audioEvent, Priority priority, Action completionCallback = null)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_PlayerSay), Member = "DoSay")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_female")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_male")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public void SetPlayerVoicePersona()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GunItem), Member = "ZoomStart")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StopBelowPriority")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Stop")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	private void CompleteActiveRequest()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayPlayerVoiceEvents")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNonCriticalVoiceLine")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanPlayNextRequest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private bool CanPlayNonCriticalVoiceLine()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[CallerCount(Count = 2)]
	private bool HandleNextRequest()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
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

	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeHandleNextQueuedRequest()
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void MaybeShowInitialSubtitle(string eventName)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(ActiveRequest), Member = "Start")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateQueued()
	{
	}

	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PlayerVoice()
	{
	}
}
