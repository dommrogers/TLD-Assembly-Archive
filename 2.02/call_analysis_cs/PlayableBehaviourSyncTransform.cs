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
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "GetSpawnedObject")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private Transform GetParent(string missionObjectIdentifier, GameObject prefab, TLD_SpawnedAnimationTrack spawnedAnimationTrack)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private Transform FindTransform(Transform parent, string transformName)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_localPosition")]
	[Calls(Type = typeof(Transform), Member = "get_localRotation")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	public PlayableBehaviourSyncTransform()
	{
	}
}
