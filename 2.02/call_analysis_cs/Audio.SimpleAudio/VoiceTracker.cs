using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Audio.SimpleAudio;

public class VoiceTracker : LoopTracker
{
	private float m_CaptionDisplayTime;

	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public VoiceTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base(null, null, default(float), stopWhenDisabled: default(bool), position: default(bool))
	{
	}

	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetSwearFilterSwitchOnEmitter")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override void Start()
	{
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}
}
