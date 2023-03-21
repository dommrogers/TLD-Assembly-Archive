using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Timeline;

public class TLD_SubtitleTrack : PlayableTrack
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_SubtitleTrack), Member = "RefreshClips")]
	public void OnValidate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(TLD_SubtitleTrack), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 12)]
	public void RefreshClips()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableTrack), Member = ".ctor")]
	public TLD_SubtitleTrack()
	{
	}
}
