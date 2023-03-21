using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_SpawnedAnimationTrack : AnimationTrack, TLD_ITrack, TLD_IDynamicBindableTrack
{
	public enum LightProbeMode
	{
		Default,
		ForceOff,
		ForceOn
	}

	public GameObject m_PrefabObject;

	public bool m_KeepSpawnedObject;

	public string m_ParentId;

	public LightProbeMode m_LightProbeMode;

	protected GameObject m_RootObject;

	protected GameObject m_SpawnedObject;

	protected GameObject m_ParentGameObject;

	private static Dictionary<string, GameObject> m_SpawnedObjectMapping;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void LateUpdatePlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DeleteSpawnedObject")]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "GetSpawnedObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected virtual void PlayInternal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	protected virtual void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "MaybeApplyRendererSettings")]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 22)]
	public virtual GameObject SpawnObject()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "Stop")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public void DeleteSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasSpawned()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "OnBehaviourPause")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Activate(bool enabled)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "GetParent")]
	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DoDynamicBinding")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	public GameObject GetSpawnedObject()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "SpawnObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeApplyRendererSettings()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_SpawnedAnimationTrack()
	{
	}
}
