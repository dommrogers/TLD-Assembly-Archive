using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using SpecialEvents;
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

	public RequestEventDelegate m_EventTrigger;

	public VoicePersonaChangedDelegate m_VoicePersonaChanged;

	public float m_MinSecondsBetweenNonCriticalLines;

	public float m_NonCriticalVoiceQueueTimeout;

	public float m_ForcedSubtitleDelayTime;

	public float m_TimeoutBufferDuration;

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

	[CalledBy(Type = typeof(Action_BlockNonCriticalVoiceOver), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
	[CallerCount(Count = 0)]
	public float GetNonCriticalDelayTime()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public List<Request> GetQueue()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 10)]
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

	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CalledBy(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fatigue), Member = "CatchBreath")]
	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	public uint Play(uint eventID, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_PlayerSay), Member = "DoSay")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "PlayDelayedVoiceOver")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
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
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_male")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	public void SetPlayerVoicePersona()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
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
	[Calls(Type = typeof(PlayerVoice), Member = "UpdateQueued")]
	[Calls(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(GunItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StopBelowPriority")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Stop")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	private void CompleteActiveRequest()
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNonCriticalVoiceLine")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayPlayerVoiceEvents")]
	private bool CanPlayNextRequest()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsClimbing")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallsUnknownMethods(Count = 10)]
	private bool CanPlayNonCriticalVoiceLine()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsMainMenuEnabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	private bool CanPlayPlayerVoiceEvents()
	{
		return default(bool);
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EventTrigger(Request request, Reason reason)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	private bool HandleNextRequest()
	{
		return default(bool);
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void LogRequestIgnored(string reason)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(Request), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	private void MaybeHandleNextQueuedRequest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeShowInitialSubtitle(string eventName)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Request), Member = "Copy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	private bool StartNextRequest()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	private void UpdateActive()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	private void UpdateQueued()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public PlayerVoice()
	{
	}
}
