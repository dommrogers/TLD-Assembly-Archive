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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "ProcessFrame")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void MaybeSetAnchor(TLD_TimelineDirector timelineDirector)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private GameObject FindAnchor(TLD_TimelineDirector timelineDirector)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public PlayableBehaviourSetFPAnchor()
	{
	}
}
