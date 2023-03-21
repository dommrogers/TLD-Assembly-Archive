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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public virtual void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void LateUpdatePlay()
	{
	}

	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DeleteSpawnedObject")]
	[CallerCount(Count = 0)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "GetSpawnedObject")]
	[CallsUnknownMethods(Count = 3)]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected virtual void PlayInternal()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected virtual void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "MaybeApplyRendererSettings")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public virtual GameObject SpawnObject()
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "Stop")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void DeleteSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public bool HasSpawned()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "OnBehaviourPause")]
	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Activate(bool enabled)
	{
	}

	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "GetParent")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public GameObject GetSpawnedObject()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "SpawnObject")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private void MaybeApplyRendererSettings()
	{
	}

	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public TLD_SpawnedAnimationTrack()
	{
	}
}
