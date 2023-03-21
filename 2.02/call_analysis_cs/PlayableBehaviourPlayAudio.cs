using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourPlayAudio : PlayableBehaviour
{
	public string m_AudioEventStart;

	public string m_AudioEventStop;

	public bool m_AudioDrivesDirectorTime;

	public TLD_TimelineDirector m_TLD_Director;

	public double m_StartTime;

	public double m_ClipDuration;

	public string m_AssetName;

	private uint m_AudioID;

	private float m_AudioDuration;

	private bool m_HasStarted;

	private bool m_HasFailed;

	private bool m_HasLoggedLengthWarning;

	private GameObject m_AudioEmitterNode;

	private bool m_SeekRequested;

	private float m_SeekTimeRequested;

	private bool m_PlayRequested;

	internal bool m_SeekAudioEnabled;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	[Calls(Type = typeof(PlayableBehaviourPlayAudio), Member = "TryToSeekAudio")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayableBehaviourPlayAudio), Member = "StopAudio")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void PlayAudio(float seekTime)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 2)]
	private void StopAudio()
	{
	}

	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	private uint PostStopAudioEvent()
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	private bool TryToSeekAudio()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public PlayableBehaviourPlayAudio()
	{
	}
}
