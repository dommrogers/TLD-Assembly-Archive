using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_SayTrack : PlayableTrack, TLD_IDynamicBindableTrack
{
	public string m_MissionObjectId;

	public string m_ChildObjectName;

	public VoiceInstigatorType m_InstigatorType;

	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "LocIdFromEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 12)]
	public void RefreshClips()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	public TLD_SayTrack()
	{
	}
}
