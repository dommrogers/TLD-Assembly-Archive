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

	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 21)]
	public void SetTrack(TLD_AudioTrack tldAudioTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 53)]
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
