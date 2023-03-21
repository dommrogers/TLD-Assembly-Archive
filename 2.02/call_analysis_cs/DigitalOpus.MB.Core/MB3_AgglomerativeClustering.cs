using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_AgglomerativeClustering
{
	[Serializable]
	public class ClusterNode
	{
		public item_s leaf;

		public ClusterNode cha;

		public ClusterNode chb;

		public int height;

		public float distToMergedCentroid;

		public Vector3 centroid;

		public int[] leafs;

		public int idx;

		public bool isUnclustered;

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public ClusterNode(item_s ii, int index)
		{
		}

		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[CallsUnknownMethods(Count = 16)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		public ClusterNode(ClusterNode a, ClusterNode b, int index, int h, float dist, ClusterNode[] clusters)
		{
		}
	}

	[Serializable]
	public class item_s
	{
		public GameObject go;

		public Vector3 coord;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public item_s()
		{
		}
	}

	public class ClusterDistance
	{
		public ClusterNode a;

		public ClusterNode b;

		[DeduplicatedMethod]
		[CallerCount(Count = 83)]
		public ClusterDistance(ClusterNode aa, ClusterNode bb)
		{
		}
	}

	public List<item_s> items;

	public ClusterNode[] clusters;

	public bool wasCanceled;

	private const int MAX_PRIORITY_Q_SIZE = 2048;

	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "_RefillPriorityQWithSome")]
	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "_RefillPriorityQWithSome")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private float euclidean_distance(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "BuildClusters")]
	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "TestRun")]
	public bool agglomerate(ProgressUpdateCancelableDelegate progFunc)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "euclidean_distance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "euclidean_distance")]
	private float _RefillPriorityQWithSome(PriorityQueue<float, ClusterDistance> pq, List<ClusterNode> unclustered, ClusterNode[] clusters, ProgressUpdateCancelableDelegate progFunc)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 24)]
	public int TestRun(List<GameObject> gos)
	{
		return default(int);
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	public static void Main()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	public static T NthSmallestElement<T>(List<T> array, int n) where T : IComparable<T>
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static List<T> QuickSelectSmallest<T>(List<T> input, int n) where T : IComparable<T>
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private static int QuickSelectPartition<T>(List<T> array, int startIndex, int endIndex, int pivotIndex) where T : IComparable<T>
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static void Swap<T>(List<T> array, int index1, int index2)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "BuildClusters")]
	[CallsUnknownMethods(Count = 7)]
	public MB3_AgglomerativeClustering()
	{
	}
}
