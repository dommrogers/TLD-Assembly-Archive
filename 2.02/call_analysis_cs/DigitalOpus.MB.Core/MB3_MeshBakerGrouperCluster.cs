using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass8_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public int i;

		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallsUnknownMethods(Count = 3)]
		internal bool _003CBuildClusters_003Eb__0(MB3_AgglomerativeClustering.item_s x)
		{
			return default(bool);
		}
	}

	public MB3_AgglomerativeClustering cluster;

	private float _lastMaxDistBetweenClusters;

	public float _ObjsExtents;

	public float _minDistBetweenClusters;

	private List<MB3_AgglomerativeClustering.ClusterNode> _clustersToDraw;

	private float[] _radii;

	[CalledBy(Type = typeof(MB3_MeshBakerGrouper), Member = "CreateGrouper")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public MB3_MeshBakerGrouperCluster(GrouperData data, List<GameObject> gos)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 33)]
	public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
	{
		return null;
	}

	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "_BuildListOfClustersToDraw")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
	[CallsUnknownMethods(Count = 65)]
	public void BuildClusters(List<GameObject> gos, ProgressUpdateCancelableDelegate progFunc)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "BuildClusters")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "DrawGizmos")]
	[CallsUnknownMethods(Count = 53)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	private void _BuildListOfClustersToDraw(ProgressUpdateCancelableDelegate progFunc, out float smallest, out float largest)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref smallest) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref largest) = null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "_BuildListOfClustersToDraw")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	public override void DrawGizmos(Bounds sceneObjectBounds)
	{
	}
}
