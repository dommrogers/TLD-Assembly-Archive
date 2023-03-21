using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourSay : PlayableBehaviour
{
	public VoiceOverItem m_VoiceOver;

	public VoiceInstigatorType m_InstigatorType;

	public float m_StartTime;

	public float m_PlayTime;

	private PanelReference<Panel_Subtitles> m_Subtitles;

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
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref currentTime) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(NPCVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NPCVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	private void PlayVoice(float playTime)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourSay()
	{
	}
}
