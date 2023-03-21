using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_AudioTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	public string m_MissionObjectId;

	public string m_ChildObjectName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsUnknownMethods(Count = 12)]
	public void RefreshClips()
	{
	}

	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TLD_AudioTrack()
	{
	}
}
