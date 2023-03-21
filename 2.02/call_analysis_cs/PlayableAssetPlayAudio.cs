using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetPlayAudio : PlayableAsset
{
	public string m_AudioEventStart;

	public string m_AudioEventStop;

	public bool m_AudioDrivesDirectorTime;

	public bool m_SeekAudioEnabled;

	private TLD_AudioTrack m_Track;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 7)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	public void SetTrack(TLD_AudioTrack tldAudioTrack)
	{
	}

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public TLD_AudioTrack GetTrack()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetPlayAudio()
	{
	}
}
