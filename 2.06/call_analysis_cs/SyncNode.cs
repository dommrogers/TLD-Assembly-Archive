using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncNode : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CalledBy(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 10)]
	public bool OverlapsObjects()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SyncNode()
	{
	}
}
