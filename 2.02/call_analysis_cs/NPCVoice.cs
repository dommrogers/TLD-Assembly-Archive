using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsUnknownMethods(Count = 5)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CallerCount(Count = 0)]
	public void DoUpdate()
	{
	}

	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Action_NPCSay), Member = "OnExecute")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "PlayVoice")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[Calls(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
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

	[CalledBy(Type = typeof(NPCVoice), Member = "Stop")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCVoice), Member = "AnyOtherSpeaking")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CompleteActiveRequest()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 5)]
	public static bool AnySpeaking()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private bool AnyOtherSpeaking()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[Calls(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CallsUnknownMethods(Count = 1)]
	private bool HandleNextRequest()
	{
		return default(bool);
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DebugUtils), Member = "GetGameObjectPath")]
	[CallsUnknownMethods(Count = 1)]
	private void LogRequestIgnored(string reason)
	{
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeForceSubtitles(string eventName, bool applyDelay)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanPlayNextRequest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(Request), Member = "Copy")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[CalledBy(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	private bool StartNextRequest()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdateAudioEmitterPosition()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIndoorOutdoorSwitch(bool forced)
	{
	}

	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[CallerCount(Count = 0)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public NPCVoice()
	{
	}
}
