using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Timeline;

public class TLD_SubtitleTrack : PlayableTrack
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_SubtitleTrack), Member = "RefreshClips")]
	public void OnValidate()
	{
	}

	[CalledBy(Type = typeof(TLD_SubtitleTrack), Member = "OnValidate")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	public void RefreshClips()
	{
	}

	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TLD_SubtitleTrack()
	{
	}
}
