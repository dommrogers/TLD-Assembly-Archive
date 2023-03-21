using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSpeakerName : PlayableAsset
{
	public enum SourceType
	{
		Phone,
		CommunitySpeaker
	}

	public bool m_IsUnkownSpeaker;

	public LocalizedString m_LocalizationId;

	public SourceType m_SourceType;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSpeakerName()
	{
	}
}
