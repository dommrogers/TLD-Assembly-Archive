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

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public HuntedPart2Waypoint()
	{
	}
}
