using System;
using System.Collections.Generic;
using System.Diagnostics;
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

		[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 16)]
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
		[CallerCount(Count = 7)]
		public item_s()
		{
		}
	}

	public class ClusterDistance
	{
		public ClusterNode a;

		public ClusterNode b;

		[DeduplicatedMethod]
		[CallerCount(Count = 88)]
		public ClusterDistance(ClusterNode aa, ClusterNode bb)
		{
		}
	}

	public List<item_s> items;

	public ClusterNode[] clusters;

	public bool wasCanceled;

	private const int MAX_PRIORITY_Q_SIZE = 2048;

	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "_RefillPriorityQWithSome")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float euclidean_distance(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "BuildClusters")]
	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "TestRun")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "_RefillPriorityQWithSome")]
	[Calls(Type = typeof(ClusterNode), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "euclidean_distance")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 26)]
	[CallsUnknownMethods(Count = 147)]
	public bool agglomerate(ProgressUpdateCancelableDelegate progFunc)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "euclidean_distance")]
	[Calls(Type = typeof(ProgressUpdateCancelableDelegate), Member = "Invoke")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "NthSmallestElement")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 34)]
	private float _RefillPriorityQWithSome(PriorityQueue<float, ClusterDistance> pq, List<ClusterNode> unclustered, ClusterNode[] clusters, ProgressUpdateCancelableDelegate progFunc)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "agglomerate")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	public int TestRun(List<GameObject> gos)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_AgglomerativeClustering), Member = "NthSmallestElement")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static void Main()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "_RefillPriorityQWithSome")]
	[CalledBy(Type = typeof(MB3_AgglomerativeClustering), Member = "Main")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	public static T NthSmallestElement<T>(List<T> array, int n) where T : IComparable<T>
	{
		return default(T);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Random), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
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
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private static void Swap<T>(List<T> array, int index1, int index2)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCluster), Member = "BuildClusters")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public MB3_AgglomerativeClustering()
	{
	}
}
