using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

namespace Audio.SimpleAudio;

public class VoiceTracker : LoopTracker
{
	private PanelReference<Panel_Subtitles> m_Subtitles;

	private float m_CaptionDisplayTime;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LoopTracker), Member = ".ctor")]
	public VoiceTracker(string eventId, GameObject go, float radius, bool stopWhenDisabled, bool position)
		: base((string)null, (GameObject)null, default(float), stopWhenDisabled: default(bool), position: default(bool))
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	protected override void Start()
	{
	}

	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}
}
