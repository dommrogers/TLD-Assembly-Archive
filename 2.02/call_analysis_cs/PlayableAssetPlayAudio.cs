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
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 23)]
	public void SetTrack(TLD_AudioTrack tldAudioTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 17)]
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
