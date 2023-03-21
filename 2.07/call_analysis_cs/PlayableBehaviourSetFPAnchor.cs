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

	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "OnBehaviourPlay")]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeSetAnchor(TLD_TimelineDirector timelineDirector)
	{
	}

	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[Calls(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
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
