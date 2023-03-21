using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourSay : PlayableBehaviour
{
	public VoiceOverItem m_VoiceOver;

	public VoiceInstigatorType m_InstigatorType;

	public float m_StartTime;

	public float m_PlayTime;

	private bool m_PlayRequested;

	private bool m_HasStarted;

	private bool m_ReturnToStartPending;

	private bool m_ReturnToStartRequested;

	private uint m_AudioId;

	private GameObject m_NPCObject;

	private NPCVoice m_NPCVoice;

	private const PlayerVoice.Options PLAYER_VOICE_OPTIONS = (PlayerVoice.Options)131u;

	private const NPCVoice.Options NPC_VOICE_OPTIONS = (NPCVoice.Options)3u;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		currentTime = default(float);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetTime")]
	[Calls(Type = typeof(PlayableBehaviourSay), Member = "PlayVoice")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(PlayerVoice), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSay), Member = "ProcessFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void PlayVoice(float playTime)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayableBehaviourSay()
	{
	}
}
