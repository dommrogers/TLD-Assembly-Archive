using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetWaitUserInput : PlayableAsset
{
	public LocalizedString m_LocalizationId;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptPlayable<>), Member = "Create")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "FindClip")]
	[Calls(Type = typeof(PlayableHandle), Member = "GetObject")]
	[CallsUnknownMethods(Count = 3)]
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
