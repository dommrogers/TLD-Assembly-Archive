using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SWS;

public class BezierPathManager : PathManager
{
	public Vector3[] pathPoints;

	public List<BezierPoint> bPoints;

	public bool showHandles;

	public Color color3;

	public float pathDetail;

	public bool customDetail;

	public List<float> segmentDetail;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BezierPathManager), Member = "CalculatePath")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(WaypointManager), Member = "DrawCurved")]
	[Calls(Type = typeof(WaypointManager), Member = "DrawStraight")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetHandleSize(Vector3 pos)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 20)]
	public override Vector3[] GetPathPoints()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(BezierPathManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BezierPathManager), Member = "GetPoints")]
	public void CalculatePath()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(BezierPathManager), Member = "CalculatePath")]
	[CallsUnknownMethods(Count = 13)]
	private List<Vector3> GetPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float detail)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BezierPathManager()
	{
	}
}
