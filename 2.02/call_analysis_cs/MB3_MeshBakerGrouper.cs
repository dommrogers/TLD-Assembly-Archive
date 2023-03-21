using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_MeshBakerGrouper : MonoBehaviour
{
	public enum ClusterType
	{
		none,
		grid,
		pie,
		agglomerative
	}

	public MB3_MeshBakerGrouperCore grouper;

	public ClusterType clusterType;

	public GrouperData data;

	public Bounds sourceObjectBounds;

	[Calls(Type = typeof(MB3_MeshBakerGrouper), Member = "CreateGrouper")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDrawGizmosSelected()
	{
	}

	[Calls(Type = typeof(MB3_MeshBakerGrouperCluster), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouper), Member = "OnDrawGizmosSelected")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 36)]
	public MB3_MeshBakerGrouperCore CreateGrouper(ClusterType t, GrouperData data)
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 0)]
	public MB3_MeshBakerGrouper()
	{
	}
}
