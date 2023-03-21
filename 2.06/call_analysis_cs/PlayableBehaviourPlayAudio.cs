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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromAudio")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourPlayAudio), Member = "PlayAudio")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySoundWithPositionTracking")]
	[Calls(Type = typeof(AkCallbackManager.EventCallback), Member = ".ctor")]
	[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "ProcessFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	private void PlayAudio(float seekTime)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallerCount(Count = 0)]
	private void StopAudio()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 1)]
	private uint PostStopAudioEvent()
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	[CallsUnknownMethods(Count = 1)]
	private bool TryToSeekAudio()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = "get_fEstimatedDuration")]
	[CallerCount(Count = 0)]
	private void AudioCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Seek")]
	private static void AudioSeek(int audioMs, string audioEventStart, uint audioId, GameObject audioEmitterNode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayableBehaviourPlayAudio()
	{
	}
}
