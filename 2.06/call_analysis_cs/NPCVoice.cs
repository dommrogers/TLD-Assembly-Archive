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

	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Action_NPCSay), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "PlayVoice")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[Calls(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	public void Stop(uint playingID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSpeaking()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(NPCVoice), Member = "AnyOtherSpeaking")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CalledBy(Type = typeof(NPCVoice), Member = "Stop")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 2)]
	private void CompleteActiveRequest()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static bool AnySpeaking()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool AnyOtherSpeaking()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[Calls(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CalledBy(Type = typeof(NPCVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private bool HandleNextRequest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "GetGameObjectPath")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanPlayNextRequest()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(Request), Member = "Copy")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	private bool StartNextRequest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdateAudioEmitterPosition()
	{
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	private void UpdateIndoorOutdoorSwitch(bool forced)
	{
	}

	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 3)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	public NPCVoice()
	{
	}
}
