using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class PlayableBehaviourSyncTransform : PlayableBehaviour
{
	public string m_SourceName;

	public string m_SourceMissionObjectID;

	public GameObject m_SourcePrefab;

	public string m_TargetName;

	public string m_TargetMissionObjectID;

	public GameObject m_TargetPrefab;

	public bool m_SyncInLocalSpace;

	public bool m_SyncPosition;

	public bool m_SyncRotation;

	public bool m_SyncScale;

	public TLD_SpawnedAnimationTrack m_SourceSpawnedAnimationTrack;

	public TLD_SpawnedAnimationTrack m_TargetSpawnedAnimationTrack;

	private Transform m_SourceTransform;

	private Transform m_TargetTransform;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourSyncTransform), Member = "GetParent")]
	[Calls(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[Calls(Type = typeof(PlayableBehaviourSyncTransform), Member = "GetParent")]
	[Calls(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "GetSpawnedObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private Transform GetParent(string missionObjectIdentifier, GameObject prefab, TLD_SpawnedAnimationTrack spawnedAnimationTrack)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private Transform FindTransform(Transform parent, string transformName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_localRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	public PlayableBehaviourSyncTransform()
	{
	}
}
