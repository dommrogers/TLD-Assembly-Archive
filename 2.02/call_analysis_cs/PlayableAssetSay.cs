using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSay : PlayableAsset
{
	public VoiceOverItem m_VoiceOver;

	private TLD_SayTrack m_Track;

	private PlayableBehaviourSay m_PlayableBehaviour;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 41)]
	public void SetTrack(TLD_SayTrack sayTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	public TLD_SayTrack GetTrack()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref currentTime) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSay()
	{
	}
}
