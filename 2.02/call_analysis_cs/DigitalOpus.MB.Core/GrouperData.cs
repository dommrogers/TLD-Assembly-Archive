using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public class GrouperData
{
	public bool clusterOnLMIndex;

	public bool clusterByLODLevel;

	public Vector3 origin;

	public Vector3 cellSize;

	public int pieNumSegments;

	public Vector3 pieAxis;

	public int height;

	public float maxDistBetweenClusters;

	public bool includeCellsWithOnlyOneRenderer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GrouperData()
	{
	}
}
