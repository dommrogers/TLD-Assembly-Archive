using System.Collections.Generic;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_MeshBakerGrouper), Member = "CreateGrouper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDrawGizmosSelected()
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouper), Member = "OnDrawGizmosSelected")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCluster), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 36)]
	public MB3_MeshBakerGrouperCore CreateGrouper(ClusterType t, GrouperData data)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public MB3_MeshBakerGrouper()
	{
	}
}
