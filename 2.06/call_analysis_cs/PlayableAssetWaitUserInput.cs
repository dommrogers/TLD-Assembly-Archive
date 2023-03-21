using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetWaitUserInput : PlayableAsset
{
	public LocalizedString m_LocalizationId;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[CallsUnknownMethods(Count = 3)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlayableAssetWaitUserInput()
	{
	}
}
