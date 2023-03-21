using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AkEventTrack : TrackAsset
{
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[Calls(Type = typeof(AkEventTrack), Member = "setOwnerClips")]
	[CallsUnknownMethods(Count = 1)]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AkEventTrack), Member = "CreateTrackMixer")]
	[Calls(Type = typeof(AkEventTrack), Member = "getEaseOutTime")]
	[Calls(Type = typeof(AkEventTrack), Member = "getEaseInTime")]
	[Calls(Type = typeof(AkEventTrack), Member = "getBlendOutTime")]
	[Calls(Type = typeof(AkEventTrack), Member = "getBlendInTime")]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void setFadeTimes()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CalledBy(Type = typeof(AkEventTrack), Member = "CreateTrackMixer")]
	[CallsUnknownMethods(Count = 11)]
	public void setOwnerClips()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(TimelineClip), Member = "get_clipCaps")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	public double getBlendInTime(AkEventPlayable playableClip)
	{
		return default(double);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_clipCaps")]
	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallsUnknownMethods(Count = 9)]
	public double getBlendOutTime(AkEventPlayable playableClip)
	{
		return default(double);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeInDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	public double getEaseInTime(AkEventPlayable playableClip)
	{
		return default(double);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeOutDuration")]
	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallsUnknownMethods(Count = 9)]
	public double getEaseOutTime(AkEventPlayable playableClip)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	public AkEventTrack()
	{
	}
}
