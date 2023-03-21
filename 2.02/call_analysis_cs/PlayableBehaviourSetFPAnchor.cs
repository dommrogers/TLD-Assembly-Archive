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
	[CallAnalysisFailed]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 0)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSetAnchor(TLD_TimelineDirector timelineDirector)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private GameObject FindAnchor(TLD_TimelineDirector timelineDirector)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public PlayableBehaviourSetFPAnchor()
	{
	}
}
