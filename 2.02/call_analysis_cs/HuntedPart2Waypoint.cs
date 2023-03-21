using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HuntedPart2Waypoint : MissionWaypoint
{
	public enum WaypointType
	{
		AttackOnDetect,
		FleeOnDetect,
		RunThrough,
		FinalAmbush
	}

	public WaypointType m_WaypointType;

	public bool m_IncrementWeatherStage;

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HuntedPart2Waypoint()
	{
	}
}
