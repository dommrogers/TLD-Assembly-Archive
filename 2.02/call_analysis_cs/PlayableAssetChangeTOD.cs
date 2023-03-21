using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetChangeTOD : PlayableAsset
{
	public PlayableBehaviourChangeTOD m_Settings;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PlayableAssetChangeTOD()
	{
	}
}
