using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSyncTransform : PlayableAsset
{
	public PlayableBehaviourSyncTransform m_Settings;

	private string m_CurrentPrefabName;

	[Calls(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	[Calls(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "CreatePlayable")]
	[CallsUnknownMethods(Count = 8)]
	private TLD_SpawnedAnimationTrack FindAnimationTrackForPrefab(PlayableDirector director, GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool IsTrackMatching(TLD_SpawnedAnimationTrack track)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public PlayableAssetSyncTransform()
	{
	}
}
