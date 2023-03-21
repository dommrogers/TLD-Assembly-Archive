using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SWS;

public class PathManager : MonoBehaviour
{
	public Transform[] waypoints;

	public bool drawCurved;

	public Color color1;

	public Color color2;

	public Vector3 size;

	public float radius;

	public GameObject replaceObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WaypointManager), Member = "DrawCurved")]
	[Calls(Type = typeof(WaypointManager), Member = "DrawStraight")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 12)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float GetHandleSize(Vector3 pos)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public virtual Vector3[] GetPathPoints()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PathManager()
	{
	}
}
