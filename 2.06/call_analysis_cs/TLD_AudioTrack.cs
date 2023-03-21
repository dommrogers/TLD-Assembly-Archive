using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_AudioTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	public string m_MissionObjectId;

	public string m_ChildObjectName;

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsUnknownMethods(Count = 13)]
	public void RefreshClips()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	public TLD_AudioTrack()
	{
	}
}
