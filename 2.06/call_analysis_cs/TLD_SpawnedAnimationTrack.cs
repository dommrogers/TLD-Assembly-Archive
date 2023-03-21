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

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void UpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LateUpdatePlay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DeleteSpawnedObject")]
	public void Stop()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[Calls(Type = typeof(TLD_SpawnedAnimationTrack), Member = "GetSpawnedObject")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void PlayInternal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	protected virtual void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Transform), Member = "SetParent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	public virtual GameObject SpawnObject()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "Stop")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void DeleteSpawnedObject()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public bool HasSpawned()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "OnBehaviourPause")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourActivateSpawnedObject), Member = "ProcessFrame")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void Activate(bool enabled)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "GetParent")]
	[CalledBy(Type = typeof(TLD_SpawnedAnimationTrack), Member = "DoDynamicBinding")]
	public GameObject GetSpawnedObject()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeApplyRendererSettings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationTrack), Member = ".ctor")]
	public TLD_SpawnedAnimationTrack()
	{
	}
}
