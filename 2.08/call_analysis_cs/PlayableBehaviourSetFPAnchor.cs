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

	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[CallerCount(Count = 0)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "OnBehaviourPlay")]
	[Calls(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSetAnchor(TLD_TimelineDirector timelineDirector)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "TryGetFPAnchorTargetOverride")]
	[Calls(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "MaybeSetAnchor")]
	[CallsUnknownMethods(Count = 2)]
	private GameObject FindAnchor(TLD_TimelineDirector timelineDirector)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PlayableBehaviourSetFPAnchor()
	{
	}
}
