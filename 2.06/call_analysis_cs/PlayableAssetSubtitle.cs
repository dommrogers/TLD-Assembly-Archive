using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSubtitle : PlayableAsset
{
	public bool m_IsUnkownSpeaker;

	public LocalizedString m_LocalizationId;

	private TLD_SubtitleTrack m_Track;

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 36)]
	public void SetTrack(TLD_SubtitleTrack tldSubtitleTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 58)]
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
