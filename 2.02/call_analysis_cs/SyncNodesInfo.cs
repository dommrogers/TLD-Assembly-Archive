using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncNodesInfo : MonoBehaviour
{
	public List<SyncNode> m_SyncNodes;

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(SyncNode), Member = "OverlapsObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public GameObject GetBestNode()
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SyncNodesInfo()
	{
	}
}
