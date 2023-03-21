using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Timeline;

public class TLD_SubtitleTrack : PlayableTrack
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_SubtitleTrack), Member = "RefreshClips")]
	public void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(TLD_SubtitleTrack), Member = "OnValidate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TrackAsset), Member = "get_clips")]
	[CallerCount(Count = 1)]
	public void RefreshClips()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	public TLD_SubtitleTrack()
	{
	}
}
