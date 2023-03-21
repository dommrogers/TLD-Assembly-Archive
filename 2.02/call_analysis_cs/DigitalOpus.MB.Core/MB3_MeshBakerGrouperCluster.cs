using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MeshBakerGrouperCluster : MB3_MeshBakerGrouperCore
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public List<GameObject> gos;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public int i;

		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal bool _003CBuildClusters_003Eb__0(MB3_AgglomerativeClustering.item_s x)
		{
			return false;
		}
	}

	public MB3_AgglomerativeClustering cluster;

	private float _lastMaxDistBetweenClusters;

	public float _ObjsExtents;

	public float _minDistBetweenClusters;

	private List<MB3_AgglomerativeClustering.ClusterNode> _clustersToDraw;

	private float[] _radii;

	[CalledBy(Type = typeof(MB3_MeshBakerGrouper), Member = "CreateGrouper")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MB3_MeshBakerGrouperCluster(GrouperData data, List<GameObject> gos)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 33)]
	public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "_BuildListOfClustersToDraw")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 65)]
	public void BuildClusters(List<GameObject> gos, ProgressUpdateCancelableDelegate progFunc)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "BuildClusters")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "DrawGizmos")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 53)]
	private void _BuildListOfClustersToDraw(ProgressUpdateCancelableDelegate progFunc, out float smallest, out float largest)
	{
		smallest = default(float);
		largest = default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "_BuildListOfClustersToDraw")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public override void DrawGizmos(Bounds sceneObjectBounds)
	{
	}
}
