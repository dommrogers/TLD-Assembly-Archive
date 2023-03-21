using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerCough : MonoBehaviour
{
	public float m_DelayBetweenCaptions;

	public float m_CaptionDisplayTime;

	private float m_NextCaptionDisplayTime;

	private uint m_PlayingID;

	[CallerCount(Count = 0)]
	public bool IsActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CalledBy(Type = typeof(ToxicFog), Member = "StartAffliction")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void MaybeStart(string eventName)
	{
	}

	[CalledBy(Type = typeof(Suffocating), Member = "StopAudio")]
	[CalledBy(Type = typeof(ToxicFog), Member = "StopAffliction")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerCough()
	{
	}
}
