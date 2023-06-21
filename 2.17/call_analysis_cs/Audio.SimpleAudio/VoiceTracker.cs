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
		: base((string)null, (GameObject)null, 0f, stopWhenDisabled: false, position: false)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetOutdoorEnvironmentSwitch")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetIndoorEnvironmentSwitch")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(LoopTracker), Member = "SetupDynamicProxy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}
}
