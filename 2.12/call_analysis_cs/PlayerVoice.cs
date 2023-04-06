using System;
using System.Collections.Generic;
using System.Diagnostics;
using AK.Wwise;
using Audio;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Logging;
using TLD.SaveState;
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

	private readonly ActiveRequest m_ActiveRequest;

	private readonly Request m_NextRequest;

	private readonly List<Request> m_Queue;

	[CalledBy(Type = typeof(Action_BlockNonCriticalVoiceOver), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
		return 0f;
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
		return false;
	}

	[CallerCount(Count = 53)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(AudioCallback), Member = "OnPlayerVoiceEvent")]
	[CalledBy(Type = typeof(Fatigue), Member = "CatchBreath")]
	[CalledBy(Type = typeof(Fire), Member = "ExitFireStarting")]
	[CalledBy(Type = typeof(Fire), Member = "PlayStartingFireVoiceEvent")]
	[CalledBy(Type = typeof(EmergencyStimItem), Member = "OnInject")]
	[CalledBy(Type = typeof(BloodLoss), Member = "BloodLossStart")]
	[CalledBy(Type = typeof(BrokenRib), Member = "PlayBrokenRibAudio")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateLimpAnimation")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "MaybeLimpOrStumbleWithFootStep")]
	[CalledBy(Type = typeof(Container), Member = "BeginContainerOpen")]
	[CalledBy(Type = typeof(Container), Member = "MaybePlayInspectionAudio")]
	[CalledBy(Type = typeof(PlayerManager), Member = "KnockedDownByAI")]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "MaybePlaceFootstep")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "SlipBegin")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "DoChangeWeapon")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "MaybeShowInitialSubtitle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public uint Play(uint eventID, Priority priority, Options options = Options.None, Action completionCallback = null, string eventName = null)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "DoAiming")]
	[CalledBy(Type = typeof(AudioCallback), Member = "OnPlayerVoiceEventWithArgs")]
	[CalledBy(Type = typeof(Condition), Member = "PlayPlayerDeathAudio")]
	[CalledBy(Type = typeof(Condition), Member = "PlayerDeath")]
	[CalledBy(Type = typeof(Condition), Member = "MaybePlayPlayerInjuredVoiceOver")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingTeethChatter")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybePlayPlayerFreezingVoiceOver")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "SprainedAnkleStart")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "MaybeDoLimpAudio")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "DoStumbleEffects")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PlayHoistEffortAudio")]
	[CalledBy(Type = typeof(Breath), Member = "PlayBreathEffect")]
	[CalledBy(Type = typeof(HandheldShortwaveAudio), Member = "UpdateAudio")]
	[CalledBy(Type = typeof(HandheldShortwaveAudio), Member = "UpdateRangeAudio")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public uint Play(AK.Wwise.Event audioEvent, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "Update")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "PlayDelayedVoiceOver")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public bool Queue(AK.Wwise.Event audioEvent, Priority priority, Action completionCallback = null)
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_PlayerSay), Member = "DoSay")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool Queue(string eventName, Priority priority, Action completionCallback = null)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void RestrictBelowPriority(Priority priority)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_female")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_voice_male")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Start")]
	[CalledBy(Type = typeof(PlayerManager), Member = "Deserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetSwitch")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[Calls(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[CalledBy(Type = typeof(BowItem), Member = "PressFire")]
	[CalledBy(Type = typeof(BowItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(GunItem), Member = "ZoomStart")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Stop")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StopBelowPriority")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "UpdateActive")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void CompleteActiveRequest()
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayPlayerVoiceEvents")]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNonCriticalVoiceLine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CanPlayNextRequest()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private bool CanPlayNonCriticalVoiceLine()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSleeping")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private bool CanPlayPlayerVoiceEvents()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EventTrigger(Request request, Reason reason)
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool HandleNextRequest()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private void LogRequestIgnored(string reason)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private void LogRequestPreempted(string reason)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "CanPlayNextRequest")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void MaybeHandleNextQueuedRequest()
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeShowInitialSubtitle(string eventName)
	{
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "HandleNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(ActiveRequest), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private bool StartNextRequest()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateActive()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateQueued()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallsUnknownMethods(Count = 3)]
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
