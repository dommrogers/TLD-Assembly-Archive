using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AkEventTrack : TrackAsset
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableExtensions), Member = "SetInputCount")]
	[Calls(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[Calls(Type = typeof(AkEventTrack), Member = "setOwnerClips")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[CalledBy(Type = typeof(AkEventTrack), Member = "CreateTrackMixer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(AkEventTrack), Member = "getBlendInTime")]
	[Calls(Type = typeof(AkEventTrack), Member = "getBlendOutTime")]
	[Calls(Type = typeof(AkEventTrack), Member = "getEaseInTime")]
	[Calls(Type = typeof(AkEventTrack), Member = "getEaseOutTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void setFadeTimes()
	{
	}

	[CalledBy(Type = typeof(AkEventTrack), Member = "CreateTrackMixer")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void setOwnerClips()
	{
	}

	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_clipCaps")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public double getBlendInTime(AkEventPlayable playableClip)
	{
		return 0.0;
	}

	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_clipCaps")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public double getBlendOutTime(AkEventPlayable playableClip)
	{
		return 0.0;
	}

	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeInDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public double getEaseInTime(AkEventPlayable playableClip)
	{
		return 0.0;
	}

	[CalledBy(Type = typeof(AkEventTrack), Member = "setFadeTimes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TimelineClip), Member = "get_easeOutDuration")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public double getEaseOutTime(AkEventPlayable playableClip)
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkEventTrack()
	{
	}
}
