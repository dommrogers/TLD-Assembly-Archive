using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_KMeansClustering
{
	private class DataPoint
	{
		public Vector3 center;

		public GameObject gameObject;

		public int Cluster;

		[CalledBy(Type = typeof(MB3_KMeansClustering), Member = ".ctor")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		public DataPoint(GameObject go)
		{
		}
	}

	private List<DataPoint> _normalizedDataToCluster;

	private Vector3[] _clusters;

	private int _numberOfClusters;

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(DataPoint), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public MB3_KMeansClustering(List<GameObject> gos, int numClusters)
	{
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "Cluster")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeCentroids()
	{
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "GetCluster")]
	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "Cluster")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "AnyAreEmpty")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private bool UpdateDataPointMeans(bool force)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	private bool AnyAreEmpty(List<DataPoint> data)
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "Cluster")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "ElucidanDistance")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "MinIndex")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private bool UpdateClusterMembership()
	{
		return false;
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float ElucidanDistance(DataPoint dataPoint, Vector3 mean)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private int MinIndex(float[] distances)
	{
		return 0;
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	public List<Renderer> GetCluster(int idx, out Vector3 mean, out float size)
	{
		mean = default(Vector3);
		size = default(float);
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "InitializeCentroids")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Cluster()
	{
	}
}
