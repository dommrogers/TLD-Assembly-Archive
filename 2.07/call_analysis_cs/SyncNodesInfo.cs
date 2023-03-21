using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncNodesInfo : MonoBehaviour
{
	public List<SyncNode> m_SyncNodes;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	public GameObject GetBestNode()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SyncNodesInfo()
	{
	}
}
