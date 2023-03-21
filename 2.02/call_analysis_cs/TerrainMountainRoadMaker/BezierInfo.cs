using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TerrainMountainRoadMaker;

[Serializable]
public struct BezierInfo
{
	public string label;

	public Vector3 startPoint;

	public Vector3 startTangent;

	public Vector3 endPoint;

	public Vector3 endTangent;

	[CallerCount(Count = 0)]
	public BezierInfo(string Label, Vector3 StartPoint, Vector3 EndPoint, Vector3 StartTangent, Vector3 EndTangent)
	{
	}
}
