using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.UI.Generics;
using UnityEngine;
using Voice;

public class NPCVoice : MonoBehaviour
{
	public enum Options : uint
	{
		None,
		AllowEqualPriorityOverride,
		EnableSourcePlayPosition
	}

	private PanelReference<Panel_Subtitles> m_Subtitles;

	public float m_ForcedSubtitleDelayTime;

	public GameObject m_EmitterPositionOverride;

	[NonSerialized]
	public NPC m_NPC;

	private ActiveRequest m_ActiveRequest;

	private Request m_NextRequest;

	private GameObject m_Emitter;

	private bool m_WasIndoors;

	private static List<NPCVoice> s_NPCVoiceList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	public void DoUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "PlayVoice")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(Action_NPCSay), Member = "OnExecute")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[Calls(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CallerCount(Count = 12)]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop(uint playingID)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsSpeaking()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(NPCVoice), Member = "AnyOtherSpeaking")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CalledBy(Type = typeof(NPCVoice), Member = "Stop")]
	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 2)]
	private void CompleteActiveRequest()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool AnySpeaking()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 6)]
	private bool AnyOtherSpeaking()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private bool HandleNextRequest()
	{
		return default(bool);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "GetGameObjectPath")]
	[CallsUnknownMethods(Count = 1)]
	private void LogRequestIgnored(string reason)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanPlayNextRequest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(ActiveRequest), Member = "Start")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	private bool StartNextRequest()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateAudioEmitterPosition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	private void UpdateIndoorOutdoorSwitch(bool forced)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public NPCVoice()
	{
	}
}
