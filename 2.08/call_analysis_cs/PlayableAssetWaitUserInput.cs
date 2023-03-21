using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetWaitUserInput : PlayableAsset
{
	public LocalizedString m_LocalizationId;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetWaitUserInput()
	{
	}
}
