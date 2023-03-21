using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSay : PlayableAsset
{
	public VoiceOverItem m_VoiceOver;

	private TLD_SayTrack m_Track;

	private PlayableBehaviourSay m_PlayableBehaviour;

	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	public void SetTrack(TLD_SayTrack sayTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 27)]
	public TLD_SayTrack GetTrack()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref currentTime) = null;
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayableAssetSay()
	{
	}
}
