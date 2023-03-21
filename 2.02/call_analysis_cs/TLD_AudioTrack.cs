using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_AudioTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	public string m_MissionObjectId;

	public string m_ChildObjectName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void RefreshClips()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableTrack), Member = ".ctor")]
	public TLD_AudioTrack()
	{
	}
}
