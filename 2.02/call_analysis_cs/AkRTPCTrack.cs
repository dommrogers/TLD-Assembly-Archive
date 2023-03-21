using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AkRTPCTrack : TrackAsset
{
	public RTPC Parameter;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkRTPCTrack), Member = "setPlayableProperties")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CalledBy(Type = typeof(AkRTPCTrack), Member = "CreateTrackMixer")]
	[CallsUnknownMethods(Count = 10)]
	public void setPlayableProperties()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallsUnknownMethods(Count = 11)]
	public void OnValidate()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public AkRTPCTrack()
	{
	}
}
