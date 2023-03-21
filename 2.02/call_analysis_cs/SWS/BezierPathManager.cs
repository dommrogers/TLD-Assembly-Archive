using System.Collections.Generic;
using System.Linq;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaypointManager), Member = "DrawCurved")]
	[Calls(Type = typeof(WaypointManager), Member = "DrawStraight")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 24)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetHandleSize(Vector3 pos)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 40)]
	public override Vector3[] GetPathPoints()
	{
		return null;
	}

	[CalledBy(Type = typeof(BezierPathManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BezierPathManager), Member = "GetPoints")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	public void CalculatePath()
	{
	}

	[CalledBy(Type = typeof(BezierPathManager), Member = "CalculatePath")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private List<Vector3> GetPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float detail)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public BezierPathManager()
	{
	}
}
