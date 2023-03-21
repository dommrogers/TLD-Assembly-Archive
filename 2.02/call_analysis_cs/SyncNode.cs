using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SyncNode : MonoBehaviour
{
	private Bounds m_Bounds;

	private static Collider[] s_Results;

	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "SelectApproachSide")]
	[CalledBy(Type = typeof(SyncNodesInfo), Member = "GetBestNode")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Collider), Member = "get_isTrigger")]
	public bool OverlapsObjects()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SyncNode()
	{
	}
}
