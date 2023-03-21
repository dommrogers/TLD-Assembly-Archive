using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class PlayerCough : MonoBehaviour
{
	public float m_DelayBetweenCaptions;

	public float m_CaptionDisplayTime;

	private PanelReference<Panel_Subtitles> m_Subtitles;

	private float m_NextCaptionDisplayTime;

	private uint m_PlayingID;

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CalledBy(Type = typeof(ToxicFog), Member = "StartAffliction")]
	[CalledBy(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public void MaybeStart(string eventName)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Suffocating), Member = "StopAudio")]
	[CalledBy(Type = typeof(ToxicFog), Member = "StopAffliction")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	public PlayerCough()
	{
	}
}
