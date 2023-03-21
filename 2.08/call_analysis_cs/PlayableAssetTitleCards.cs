using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetTitleCards : PlayableAsset
{
	public PlayableBehaviourTitleCards template;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetTitleCards()
	{
	}
}
