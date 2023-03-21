using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncNode : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CalledBy(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	public bool OverlapsObjects()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SyncNode()
	{
	}
}
