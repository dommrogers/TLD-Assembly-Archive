using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TLD_ActivationTrack : ActivationTrack, TLD_IDynamicBindableTrack, TLD_ITrack
{
	public string m_MissionObjectId;

	public string m_ChildObjectName;

	public bool m_PersistState;

	private GameObject m_BindingObject;

	private bool m_InitialBindingObjectState;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(CustomManagedObject), Member = "UpdateManagedObject")]
	[CallsUnknownMethods(Count = 4)]
	public void Stop()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private bool GetPersistedState()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Play()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void UpdatePlay()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void LateUpdatePlay()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TrackAsset), Member = ".ctor")]
	public TLD_ActivationTrack()
	{
	}
}
