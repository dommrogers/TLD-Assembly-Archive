using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetJumpToTime : PlayableAsset
{
	public bool m_allowSkipIfNotSeen;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayableDirector), Member = "get_playableAsset")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetJumpToTime()
	{
	}
}
