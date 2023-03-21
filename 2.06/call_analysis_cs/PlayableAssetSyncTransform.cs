using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableAssetSyncTransform : PlayableAsset
{
	public PlayableBehaviourSyncTransform m_Settings;

	private string m_CurrentPrefabName;

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableAssetSyncTransform), Member = "FindAnimationTrackForPrefab")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "CreatePlayable")]
	[CalledBy(Type = typeof(PlayableAssetSyncTransform), Member = "CreatePlayable")]
	private TLD_SpawnedAnimationTrack FindAnimationTrackForPrefab(PlayableDirector director, GameObject prefab)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool IsTrackMatching(TLD_SpawnedAnimationTrack track)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayableAssetSyncTransform()
	{
	}
}
