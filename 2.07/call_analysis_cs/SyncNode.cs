using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncNode : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[CalledBy(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CallsUnknownMethods(Count = 10)]
	public bool OverlapsObjects()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SyncNode()
	{
	}
}
