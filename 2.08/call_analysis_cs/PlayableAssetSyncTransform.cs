using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSyncTransform : PlayableAsset
{
	public PlayableBehaviourSyncTransform m_Settings;

	private string m_CurrentPrefabName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	[Calls(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	[CallsUnknownMethods(Count = 4)]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "CreatePlayable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "CreatePlayable")]
	private TLD_SpawnedAnimationTrack FindAnimationTrackForPrefab(PlayableDirector director, GameObject prefab)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
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
