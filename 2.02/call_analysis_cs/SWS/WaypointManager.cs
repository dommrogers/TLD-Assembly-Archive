using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Holoville.HOTween;
using UnityEngine;

namespace SWS;

public class WaypointManager : MonoBehaviour
{
	public static readonly Dictionary<string, PathManager> Paths;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(WaypointManager), Member = "AddPath")]
	[Calls(Type = typeof(HOTween), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(WaypointManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void AddPath(GameObject path)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(BezierPathManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(PathManager), Member = "OnDrawGizmos")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void DrawStraight(Vector3[] waypoints)
	{
	}

	[CalledBy(Type = typeof(BezierPathManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(PathManager), Member = "OnDrawGizmos")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(WaypointManager), Member = "GetPoint")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	public static void DrawCurved(Vector3[] waypoints)
	{
	}

	[CalledBy(Type = typeof(PathRenderer), Member = "DrawCurved")]
	[CalledBy(Type = typeof(WaypointManager), Member = "DrawCurved")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static Vector3 GetPoint(Vector3[] gizmoPoints, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static float GetPathLength(Vector3[] waypoints)
	{
		return 0f;
	}

	[CalledBy(TypeFullName = "SWS.bezierMove.<MoveToPath>d__29", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 28)]
	public static List<Vector3> SmoothCurve(List<Vector3> pathToCurve, int interpolations)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WaypointManager()
	{
	}
}
