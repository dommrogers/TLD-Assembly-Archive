using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(MB3_KMeansClustering), Member = ".ctor")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		public DataPoint(GameObject go)
		{
		}
	}

	private List<DataPoint> _normalizedDataToCluster;

	private Vector3[] _clusters;

	private int _numberOfClusters;

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DataPoint), Member = ".ctor")]
	public MB3_KMeansClustering(List<GameObject> gos, int numClusters)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "Cluster")]
	[CallsUnknownMethods(Count = 6)]
	private void InitializeCentroids()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "Cluster")]
	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "GetCluster")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "AnyAreEmpty")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private bool UpdateDataPointMeans(bool force)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[CallsUnknownMethods(Count = 9)]
	private bool AnyAreEmpty(List<DataPoint> data)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "Cluster")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "MinIndex")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "ElucidanDistance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private bool UpdateClusterMembership()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float ElucidanDistance(DataPoint dataPoint, Vector3 mean)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private int MinIndex(float[] distances)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperKMeans), Member = "FilterIntoGroups")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public List<Renderer> GetCluster(int idx, out Vector3 mean, out float size)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref mean) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref size) = null;
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "InitializeCentroids")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[CallsUnknownMethods(Count = 1)]
	public void Cluster()
	{
	}
}
