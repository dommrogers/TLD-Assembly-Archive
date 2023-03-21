using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class MB3_MeshBakerGrouperKMeans : MB3_MeshBakerGrouperCore
{
	public int numClusters;

	public Vector3[] clusterCenters;

	public float[] clusterSizes;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public MB3_MeshBakerGrouperKMeans(GrouperData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = ".ctor")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "InitializeCentroids")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateDataPointMeans")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "UpdateClusterMembership")]
	[Calls(Type = typeof(MB3_KMeansClustering), Member = "GetCluster")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 42)]
	public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void DrawGizmos(Bounds sceneObjectBounds)
	{
	}
}
