using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.SaveState;
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	public void DoUpdate()
	{
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "MaybePlayVO")]
	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "UpdateAmbientVoiceOver")]
	[CalledBy(Type = typeof(NPCCondition), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(NPCCondition), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "MaybePlayVoiceOver")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "PlayVoice")]
	[CalledBy(Type = typeof(Action_NPCSay), Member = "OnExecute")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetIDFromString")]
	[Calls(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public uint Play(string eventName, Priority priority, Options options = Options.None, Action completionCallback = null)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 1)]
	public void Stop(uint playingID)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsSpeaking()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "Stop")]
	[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "OnBehaviourPause")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(NPCVoice), Member = "AnyOtherSpeaking")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	public static bool AnySpeaking()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	private bool AnyOtherSpeaking()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ActiveRequest), Member = "Stop")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[Calls(Type = typeof(uint), Member = "ToString")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 2)]
	private bool HandleNextRequest()
	{
		return false;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetGameObjectPath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LogRequestIgnored(string reason)
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool CanPlayNextRequest()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "HandleNextRequest")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(ActiveRequest), Member = "Start")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool StartNextRequest()
	{
		return false;
	}

	[CalledBy(Type = typeof(NPC), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCVoice), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(NPCVoice), Member = "UpdateIndoorOutdoorSwitch")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAudioEmitterPosition()
	{
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "UpdateAudioEmitterPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPC), Member = "IsIndoors")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateIndoorOutdoorSwitch(bool forced)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[CallsUnknownMethods(Count = 3)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public NPCVoice()
	{
	}
}
