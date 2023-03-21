using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSay : PlayableAsset
{
	public VoiceOverItem m_VoiceOver;

	private TLD_SayTrack m_Track;

	private PlayableBehaviourSay m_PlayableBehaviour;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 44)]
	public void SetTrack(TLD_SayTrack sayTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public TLD_SayTrack GetTrack()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_TimelineDirector), Member = "TryGetTimeFromVoice")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetSourcePlayPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool TryGetCurrentTimelineTimeFromAudio(out float currentTime)
	{
		currentTime = default(float);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSay()
	{
	}
}
