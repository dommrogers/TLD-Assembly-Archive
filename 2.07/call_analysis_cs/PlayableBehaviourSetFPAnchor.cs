using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableBehaviourSetFPAnchor : PlayableBehaviour
{
	public string m_ObjectName;

	public bool m_AttemptToFindObjectInChildren;

	public GameObject m_Anchor;

	public List<TLD_IFPAnchoredTrack> m_Tracks;

	public string m_SyncNodeInfoId;

	public PlayableDirector m_Director;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[CallsUnknownMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSetAnchor(TLD_TimelineDirector timelineDirector)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private GameObject FindAnchor(TLD_TimelineDirector timelineDirector)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public PlayableBehaviourSetFPAnchor()
	{
	}
}
