using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSubtitle : PlayableAsset
{
	public bool m_IsUnkownSpeaker;

	public LocalizedString m_LocalizationId;

	private TLD_SubtitleTrack m_Track;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
	public void SetTrack(TLD_SubtitleTrack tldSubtitleTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TLD_SubtitleTrack GetTrack()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSubtitle()
	{
	}
}
