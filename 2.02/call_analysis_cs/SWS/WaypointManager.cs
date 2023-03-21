using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using Holoville.HOTween;
using UnityEngine;

namespace SWS;

public class WaypointManager : MonoBehaviour
{
	public static readonly Dictionary<string, PathManager> Paths;

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(WaypointManager), Member = "AddPath")]
	[Calls(Type = typeof(HOTween), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(WaypointManager), Member = "Awake")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static void AddPath(GameObject path)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BezierPathManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(PathManager), Member = "OnDrawGizmos")]
	[CallsUnknownMethods(Count = 6)]
	public static void DrawStraight(Vector3[] waypoints)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(WaypointManager), Member = "GetPoint")]
	[CalledBy(Type = typeof(BezierPathManager), Member = "OnDrawGizmos")]
	[CalledBy(Type = typeof(PathManager), Member = "OnDrawGizmos")]
	[CallsUnknownMethods(Count = 19)]
	public static void DrawCurved(Vector3[] waypoints)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(WaypointManager), Member = "DrawCurved")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PathRenderer), Member = "DrawCurved")]
	public static Vector3 GetPoint(Vector3[] gizmoPoints, float t)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsUnknownMethods(Count = 5)]
	public static float GetPathLength(Vector3[] waypoints)
	{
		return default(float);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(bezierMove._003CMoveToPath_003Ed__29), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(Mathf), Member = "InverseLerp")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
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
