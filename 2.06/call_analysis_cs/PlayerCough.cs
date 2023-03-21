using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
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
		return false;
	}

	[CalledBy(Type = typeof(Suffocating), Member = "StartSuffocating")]
	[CalledBy(Type = typeof(ToxicFog), Member = "StartAffliction")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 6)]
	public void MaybeStart(string eventName)
	{
	}

	[CalledBy(Type = typeof(Suffocating), Member = "StopAudio")]
	[CalledBy(Type = typeof(ToxicFog), Member = "StopAffliction")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "MaybeReducePlayerCondition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = "get_strLabel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "MaybeShowSubtitleForAudioEvent")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	public PlayerCough()
	{
	}
}
