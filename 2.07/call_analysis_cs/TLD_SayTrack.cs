using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_SayTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	public string m_MissionObjectId;

	public string m_ChildObjectName;

	public VoiceInstigatorType m_InstigatorType;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallsUnknownMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	public void RefreshClips()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	[DeduplicatedMethod]
	public TLD_SayTrack()
	{
	}
}
