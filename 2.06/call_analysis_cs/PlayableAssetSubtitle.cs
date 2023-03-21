using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSubtitle : PlayableAsset
{
	public bool m_IsUnkownSpeaker;

	public LocalizedString m_LocalizationId;

	private TLD_SubtitleTrack m_Track;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[CallsUnknownMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 38)]
	public void SetTrack(TLD_SubtitleTrack tldSubtitleTrack)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 61)]
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
